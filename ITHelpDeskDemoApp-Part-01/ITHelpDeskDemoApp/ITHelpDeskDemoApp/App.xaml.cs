﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace ITHelpDeskDemoApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        //protected override void OnStartup(StartupEventArgs e)
        //{

        //    base.OnStartup(e);

        //    ITHelpDeskBootstrapper bootstrapper = new ITHelpDeskBootstrapper();
        //    bootstrapper.Run();
        //}

        public App()
        {
            ITHelpDeskBootstrapper bootstrapper = new ITHelpDeskBootstrapper();
            bootstrapper.Run();
        }
    }
}
