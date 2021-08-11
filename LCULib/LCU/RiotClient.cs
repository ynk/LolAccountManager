using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using LCULib.Exceptions;
using LCULib.LCU;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LCULib
{
    public class RiotClient
    {
        public string Port { get; set; }
        public string Password { get; set; }

        private Process RiotProcess { get; set; }

        public RiotAccount RiotAccount { get; set; }

        public RiotClientResponseAccount RiotResponseAccount { get; set; }

        public RiotClient()
        {
            CheckIfOtherClientIsRunning();
            GetCommandLineProperties();
        }

        private void CheckIfOtherClientIsRunning()
        {
            Process[] client = Process.GetProcessesByName("RiotClientUx");
            if (client.Length == 0)
            {
                throw new RiotClientExceptions("Client not running");
            }

            if (client.Length != 1)
            {
                throw new RiotClientExceptions(
                    $"Too many clients({client.Length}) are running, make sure only 1 client is running");
            }

            RiotProcess = client[0];
        }

        public void Login(RiotAccount account)
        {
            RiotAccount = account;
            ResetSession();

            string auth = $"{{\"username\":\"{account.LoginName}\"," +
                          $"\"password\": \"{account.Password}\"," +
                          "\"persistLogin\": false" +
                          "}";


            var httpWebRequest =
                (HttpWebRequest) WebRequest.Create($"https://127.0.0.1:{Port}/rso-auth/v1/session/credentials");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "PUT";

            httpWebRequest.Headers.Add("Authorization", $"Basic {Password}");


            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(auth);
            }

            var httpWebResponse = (HttpWebResponse) httpWebRequest.GetResponse();

            if (httpWebResponse.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new RiotClientExceptions("401 Unauthorized");
            }

            using (var streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                dynamic jsonResponse = JsonConvert.DeserializeObject(result);


                string error = jsonResponse.error;
                switch (error)
                {
                    case "auth_failure":
                        throw new RiotClientExceptions("Account details invalid");
                    default:
                        Debug.WriteLine(error);
                        break;
                }

                GetSummonerDetailsSingedIn();

            }
        }

        public void ResetSession()
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback =
                (senderX, certificate, chain, sslPolicyErrors) => { return true; };

            var httpWebRequest =
                (HttpWebRequest) WebRequest.Create($"https://127.0.0.1:{Port}/rso-auth/v2/authorizations");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "POST";

            httpWebRequest.Headers.Add("Authorization", $"Basic {Password}");


            using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
            {
                string json = "{\"" +
                              "clientId\":\"riot-client\"," +
                              "\"trustLevels\":[\"always_trusted\"]" +
                              "}";


                streamWriter.Write(json);
            }

            var httpResponse = (HttpWebResponse) httpWebRequest.GetResponse();

            if (httpResponse.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new RiotClientExceptions("401 Unauthorized");
            }

            if (httpResponse.StatusCode == HttpStatusCode.BadRequest)
            {
                throw new RiotClientExceptions(
                    "The request is invalid, either you are already signed in or something went wrong");
            }

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

            }
        }

        private void GetCommandLineProperties()
        {
            string wmiQuery = string.Format("select CommandLine from Win32_Process where Name='{0}'",
                "RiotClientUx.exe");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wmiQuery);
            ManagementObjectCollection retObjectCollection = searcher.Get();

            var data = retObjectCollection.Cast<ManagementBaseObject>().SingleOrDefault()["CommandLine"].ToString();


            //var path = RiotProcess.MainModule.FileName;

            var token = Regex.Match(data, "(?<=--remoting-auth-token=)([\\w-]+)").Value;


            Port = Regex.Match(data, "(?<=--app-port=)([\\w-]+)").Value;
            Password = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"riot:{token}"));
        }


        private void GetSummonerDetailsSingedIn()
        {
            var httpWebRequest =
                (HttpWebRequest) WebRequest.Create($"https://127.0.0.1:{Port}/riot-client-auth/v1/userinfo");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            httpWebRequest.Headers.Add("Authorization", $"Basic {Password}");


            var httpResponse = (HttpWebResponse) httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {

                var result = streamReader.ReadToEnd();
                dynamic jsonResponse = JsonConvert.DeserializeObject(result);
                RiotResponseAccount = new RiotClientResponseAccount();

                RiotResponseAccount.Server = GetSignedInServer();
                RiotResponseAccount.SummonerName = jsonResponse.lol_account.summoner_name;




            }
        }

        private string GetSignedInServer()
        {
            var httpWebRequest =
                (HttpWebRequest)WebRequest.Create($"https://127.0.0.1:{Port}/rso-auth/v1/authorization");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            httpWebRequest.Headers.Add("Authorization", $"Basic {Password}");


            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {

                var result = streamReader.ReadToEnd();
                dynamic jsonResponse = JsonConvert.DeserializeObject(result);

                string response =  jsonResponse.currentPlatformId;



                switch (response.ToLower())
                {
                    case "euw1":
                        return "EUW";
                    case "na1":
                        return "NA";
                    case "br1":
                        return "BR";
                    case "eun1":
                        return "EUNE";
                    case "la1":
                        return "LAN";
                    case "la2":
                        return "LAS";
                    case "oc1":
                        return "OC";
                    case "tr1":
                        return "TR";
                    case "jp1":
                        return "JP";
                    case "kr":
                        return "KR";
                    case "ru":
                        return "RU";
                    case "pbe1":
                        return "PBE";
                    default:
                        return "***";
                }



            }

            return "error";



        }


        public override string ToString()
        {
            return $"RiotClientUx | Port: {Port} | Password: {Password}";
        }
    }
}
