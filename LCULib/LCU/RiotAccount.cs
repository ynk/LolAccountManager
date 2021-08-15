using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LCULib.Exceptions;

namespace LCULib.LCU
{
    public class RiotAccount
    {
        public string
            LoginName { get; set; } // Set is set to public because of file reading, normally this would be private.

        public string Password { get; set; }
        public string Server { get; set; } = "?";
        public string SummonerName { get; set; } = "No Name";
        public string Solo_Duo_Rank { get; set; } = "Unranked";
        public string Flex_Rank { get; set; } = "Unranked";

        public int be { get; set; } = 0;
        public int rp { get; set; } = 0;


        public RiotAccount(string loginName, string password)
        {
            SetLoginName(loginName);
            SetPassword(password);
        }


        public void SetLoginName(string loginName)
        {
            if (loginName.Length <= 0)
            {
                throw new RiotClientExceptions("Login name is too short");
            }

            LoginName = loginName;
        }

        public void SetPassword(string password)
        {
            if (password.Length <= 0)
            {
                throw new RiotClientExceptions("Password is too short");
            }

            Password = password;
        }

        public void SetServer(string server)
        {
            if (server.Length <= 0)
            {
                throw new RiotClientExceptions("Server is too short");
            }

            Server = server;
        }

        public void SetSummonerName(string summonerName)
        {
            if (summonerName.Length <= 0)
            {
                throw new RiotClientExceptions("summonerName is too short");
            }

            SummonerName = summonerName;
        }
    }
}