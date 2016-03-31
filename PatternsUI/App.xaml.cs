using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using PatternsUI.Controller;

namespace PatternsUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, EventArgs e)
        {
            MainController controller = new MainController();
            controller.ShowView();
        }
    }
}
