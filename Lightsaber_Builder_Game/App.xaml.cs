﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Lightsaber_Builder_Game.Business;

namespace Lightsaber_Builder_Game
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e) 
        {
            GameBusiness gameBusiness = new GameBusiness();
        }
    }
}
