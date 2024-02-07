using Client_WinUI_MVVM.Models;
using Client_WinUI_MVVM.Services;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Client_WinUI_MVVM
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }
        public async void recupSerie()
        {
            WSService Ws = new WSService("http://localhost:44316/api/");
            Series serieee = await Ws.GetSeriesAsync("Series/", 5);


            if (serieee == null) 
            {
                myButton.Content = "prout";
            }
            else
            {
                myButton.Content = serieee;
            }
        }
        public async void postSerie()
        {
            WSService Ws = new WSService("http://localhost:44316/api/");
            HttpResponseMessage serieee = await Ws.PostSerieAsync(new Series(789789,"MeuMeu","kjqhsfd",7,8,9,"qjfh"),"Series");
        }
        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            recupSerie();
           
        }
        
        private void myButton_Click_Post(object sender, RoutedEventArgs e)
        {
            postSerie();

        }
    }
}
