﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_UI.Services
{
    internal class API_Connection
    {
        private static API_Connection instancia;
        private HttpClient client;
        private API_Connection()
        {
            client = new HttpClient();
        }
        public static API_Connection GetInstance()
        {
            if (instancia == null)
                instancia = new API_Connection();
            return instancia;
        }
        public async Task<string> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var response = await result.Content.ReadAsStringAsync();
            return response;
        }
        public async Task<string> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8,
            "application/json");
            var result = await client.PostAsync(url, content);
            var response = await result.Content.ReadAsStringAsync();
            return response;
        }
        public async Task<string> PutAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8,
            "application/json");
            var result = await client.PutAsync(url, content);
            var response = await result.Content.ReadAsStringAsync();
            return response;
        }
        public async Task<string> DeleteAsync(string url)
        {
            var result = await client.DeleteAsync(url);
            var response = await result.Content.ReadAsStringAsync();
            return response;
        }
    }
}
