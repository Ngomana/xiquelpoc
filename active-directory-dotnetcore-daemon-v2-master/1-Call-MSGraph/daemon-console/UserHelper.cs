using System;
using System.Net.Http;

namespace daemon_console
{

    //always call a protected api
    public class UserProtectApiHelper
    {

        //constructor
        public UserProtectApiHelper(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }

        protected HttpClient HttpClient { get; private set; }

    }
}