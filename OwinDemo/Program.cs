﻿using Microsoft.Owin.Hosting;
using System;

namespace OwinDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            using (WebApp.Start<Startup>(url: "http://localhost:9000/"))
            {
                Console.WriteLine("Listening on Port {0}", 9000);
                Console.WriteLine("Press [enter] to quit...");
                Console.ReadLine();
            }        
        }
    }
}
