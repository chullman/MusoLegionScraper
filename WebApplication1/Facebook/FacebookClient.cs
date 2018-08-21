﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Newtonsoft.Json;

namespace WebApplication1.Facebook
{
    public class FacebookClient
    {
        private readonly HttpClient _httpClient;

        public FacebookClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(@"https://graph.facebook.com/3.1")
            };


            _httpClient.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }


                
        public async Task<T> GetAsync<T>(string accessToken, string endpoint, string args = null)
        {
            var response = await _httpClient.GetAsync($"{endpoint}?access_token={accessToken}&{args}");
            if (!response.IsSuccessStatusCode)
                return default(T);
 
            var result = await response.Content.ReadAsStringAsync();
 
            return JsonConvert.DeserializeObject<T>(result);
        }

        /*
        public async Task<T> GetAsync<T>(string accessToken, string endpoint, string args = null)
        {
            var response = await _httpClient.GetAsync($"{endpoint}?access_token={accessToken}&{args}");
            if (!response.IsSuccessStatusCode)
                return default(T);
 
            var result = await response.Content.ReadAsStringAsync();
 
            return JsonConvert.DeserializeObject<T>(result);
        }
        */
 
 
        private static StringContent GetPayload(object data)
        {
            var json = JsonConvert.SerializeObject(data);
 
            return new StringContent(json, Encoding.UTF8, "application/json");
        }
    }
}
