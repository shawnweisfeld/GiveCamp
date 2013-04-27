using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using GiveCamp.Models;

namespace GiveCamp
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            OAuthWebSecurity.RegisterMicrosoftClient(
                clientId: "00000000480F23C3",
                clientSecret: "7gxxbXdv3SX4scRc2fy2SeIT9SSYFhKt");

            //OAuthWebSecurity.RegisterTwitterClient(
            //    consumerKey: "",
            //    consumerSecret: "");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "537189859660330",
                appSecret: "456906fe477196b3d9da9c078c47c0b8");

            //OAuthWebSecurity.RegisterGoogleClient();
        }
    }
}
