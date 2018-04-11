using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyWpfApp
{
    using MyWpfApp.Helpers;
    using MyWpfApp.ViewModels;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public void Application_Startup(object sender, StartupEventArgs args)
        {
            var mainVm = new MainVm();
            mainVm.Show("Hello Apllication", height:100, width:100);
        }
    }
}
