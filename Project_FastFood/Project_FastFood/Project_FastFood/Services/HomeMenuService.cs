﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_FastFood.Adapters;
using Project_FastFood.Models;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;

namespace Project_FastFood.Services
{
    class HomeMenuService
    {
        private Adapter _adapter = Adapter.GetAdapter();

        public async Task<HomeMenuData> GetHomeMenu()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(_adapter.GetHomeMenuApi);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                HomeMenuData homeMenuData = JsonConvert.DeserializeObject<HomeMenuData>(stringContent);
                return homeMenuData;
            }
            return null;
        }
    }
}
