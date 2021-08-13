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
using LCULib.ResponseClasses;
using Newtonsoft.Json;

namespace LCULib.LCU
{
    public class LeagueClient
    {
        private string Port { get; set; }
        private string Password { get; set; }

        public LeagueClientRankedResponse LeagueClientRanked { get; private set; }// used for lp
        private Process LeagueProcess { get; set; }

        public LeagueClient()
        {
            GetClientProcess();
            GetCommandLineProperties();
        }

        public void GetClientProcess()
        {
            Process[] client = Process.GetProcessesByName("LeagueClientUx");
            if (client.Length == 0)
            {
                throw new InvalidEnumArgumentException("League client Is not running");
            }

            if (client.Length != 1)
            {
                throw new InvalidEnumArgumentException("Too many League clients are running, only 1 client is supported.");
            }

            LeagueProcess = client[0];
        }

        private void GetCommandLineProperties()
        {
            string wmiQuery = string.Format("select CommandLine from Win32_Process where Name='{0}'",
                "LeagueClientUx.exe");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(wmiQuery);
            ManagementObjectCollection retObjectCollection = searcher.Get();

            var data = retObjectCollection.Cast<ManagementBaseObject>().SingleOrDefault()["CommandLine"].ToString();


            var token = Regex.Match(data, "(?<=--remoting-auth-token=)([\\w-]+)").Value;


            Port = Regex.Match(data, "(?<=--app-port=)([\\w-]+)").Value;
            Password = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes($"riot:{token}"));
        }

        public void GetCurrentRankedStats()
        {
            System.Net.ServicePointManager.ServerCertificateValidationCallback =
                (senderX, certificate, chain, sslPolicyErrors) => { return true; };

            var httpWebRequest =
                (HttpWebRequest) WebRequest.Create($"https://127.0.0.1:{Port}/lol-ranked/v1/current-ranked-stats");
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";
            httpWebRequest.Headers.Add("Authorization", $"Basic {Password}");


            var httpResponse = (HttpWebResponse) httpWebRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
                dynamic jsonResponse = JsonConvert.DeserializeObject(result);//Current queue map 
                var flex_rank = jsonResponse.queueMap.RANKED_FLEX_SR;
                var solo_duo_rank = jsonResponse.queueMap.RANKED_SOLO_5x5;


                LeagueClientRanked = new LeagueClientRankedResponse();

                if (flex_rank.tier == "NONE")
                {
                    LeagueClientRanked.Flex_Queue = "Unranked";
                }
                else
                {
                    LeagueClientRanked.Flex_Queue = $"{flex_rank.tier} {flex_rank.division} (Lp: {flex_rank.leaguePoints}) (W:{flex_rank.wins}) (L:{flex_rank.losses})";

                }

                if (solo_duo_rank.tier == "NONE")
                {

                    LeagueClientRanked.Solo_Queue = "Unranked";
                }
                else
                {
   
                    LeagueClientRanked.Solo_Queue = $"{solo_duo_rank.tier} {solo_duo_rank.division} (Lp: {solo_duo_rank.leaguePoints}) (W:{solo_duo_rank.wins}) (L:{solo_duo_rank.losses})";
                }
            }
        }

        public override string ToString()
        {
            return $"LeagueClientUx | Port: {Port} | Password: Basic {Password} ";
        }
    }
}