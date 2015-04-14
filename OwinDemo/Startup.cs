﻿using System;
using Owin;

namespace OwinDemo
{
    public class Startup
    {
        public Startup()
        {
        }

        public void Configuration(IAppBuilder app)
        {
            // New code: Add the error page middleware to the pipeline. 
            app.UseErrorPage();

            app.Run(context =>
                {
                    // New code: Throw an exception for this URI path.
                    if (context.Request.Path.ToString() == "/fail")
                    {
                        throw new Exception("Random exception");
                    }

                    context.Response.ContentType = "text/plain";
                    return context.Response.WriteAsync("Hello, world.");
                });
        }
    }
}

