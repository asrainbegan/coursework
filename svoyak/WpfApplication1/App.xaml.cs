using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
   
    public partial class App : Application
    {
        public static Uri Avatarpath;
        public static string username;
        public static string Packetpath;
        public static DataTable DataPuck = new DataTable();
        public static int score = new int();
        public static int selected = -1;
    } 
}
