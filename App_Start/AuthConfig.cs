using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Web.WebPages.OAuth;
using CustomizeOAuthLoginBranding.Models;

namespace CustomizeOAuthLoginBranding
{
    public static class AuthConfig
    {
        public static void RegisterAuth()
        {
            // To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
            // you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

            OAuthWebSecurity.RegisterTwitterClient(
                consumerKey: "x",
                consumerSecret: "x");

            OAuthWebSecurity.RegisterFacebookClient(
                appId: "x",
                appSecret: "x");

            OAuthWebSecurity.RegisterGoogleClient();

            OAuthWebSecurity.RegisterLinkedInClient(
                consumerKey: "x",
                consumerSecret: "x");

            OAuthWebSecurity.RegisterYahooClient();
        }
    }
}
