﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connected_Son_Proje
{
    class Tools
    {
        public static string ConnectionString
        {
            get
            {
                return @"Data Source=NIHAN-PC\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True";
            }
        }
    }
}
