using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool Avatarset = false;
        bool Puckset = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void playerAvatar_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }

        private void startbutton_Click(object sender, RoutedEventArgs e)
        {
            string playername = namebox.Text;
            if (!string.IsNullOrEmpty(playername) && !string.IsNullOrWhiteSpace(playername))
            {
                App.username = playername;
            }
            else 
            {
                MessageBox.Show("Имя пользователя не корректно");
                return;
            }
            if (!Puckset)
            {
                MessageBox.Show("Пакет не выбран");
                return;
            }
            if (!Avatarset)
            {
                MessageBox.Show("Аватар не выбран");
                return;
            }
            Window1 game = new Window1();
            game.Show();
            this.Close();
        
        }

        private void avatar_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog Dialog = new System.Windows.Forms.OpenFileDialog();
            Dialog.ShowDialog();
            Uri Path;
            try
            {
                Path = new Uri(Dialog.FileName);
                Avatarimage.Source = new BitmapImage(Path);
                App.Avatarpath = Path;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Avatarset = false;
            }
            Avatarset = true;
        }
        private void puck_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.OpenFileDialog Dialog = new System.Windows.Forms.OpenFileDialog();
            Dialog.ShowDialog();
            Uri Path;
            try
            {
                
                
                Puckset = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                           }
            try
            {
                DataTable DT = new DataTable();
                DataSet DS = new DataSet();
                DT.Columns.Add("type");
                DT.Columns.Add("question");
                DT.Columns.Add("link");
                DT.Columns.Add("coast");
                DT.Columns.Add("answer");
                System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader(Dialog.FileName);
                DS.ReadXml(reader);
                App.DataPuck = DS.Tables["puck"].Copy();
                //MessageBox.Show(DS.Tables["puck"].Rows[0][0].ToString());
                App.Packetpath = System.IO.Path.GetFileNameWithoutExtension(Dialog.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Puckset = false;
            }
            pucklink.Text = Dialog.FileName;
        }

        private void record_Click(object sender, RoutedEventArgs e)
        {
            Records rv = new Records();
            rv.ShowDialog();

        }
    }
}
