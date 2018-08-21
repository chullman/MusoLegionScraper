using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Facebook
{
    public class FacebookService
    {
        private readonly FacebookClient _facebookClient;
 
        public FacebookService(FacebookClient facebookClient)
        {
            _facebookClient = facebookClient;
        }
 
        public async Task<RootObject> GetFeedModelAsync(string accessToken)
        {
            return await _facebookClient.GetAsync<RootObject>(accessToken, @"450217962125948/feed", "fields=attachments,link,message");
        }
 
    }  
}
