﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_FastFood.Adapters
{
    class Adapter
    {
        private string baseURL = "https://foodgroup.herokuapp.com";

        private static Adapter instance;

        private Adapter() { }

        public static Adapter GetAdapter()
        {
            if (instance == null)
            {
                instance = new Adapter();
            }
            return instance;
        }

        public string GetHomeMenuApi
        {
            get => String.Format(baseURL + "/api/today-special");
        }

        public string GetCategoryMenuAPI
        {
            get => String.Format(baseURL + "/api/category/" + App.getCategoryID.id);
        }

        public string GetCreateOrderAPI
        {
            get => String.Format(baseURL + "/api/create-order");
        }
    }
}
