﻿using System;
using CCPDemo.Core.Exception;
using UIKit;

namespace CCPDemo
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            try
            {
                // if you want to use a different Application Delegate class from "AppDelegate"  you can specify it here.
                UIApplication.Main(args, null, "AppDelegate");
            }
            catch (Exception ex)
            {
                ExceptionHandler.LogException(ex);
                throw;
            }
        }
    }
}
