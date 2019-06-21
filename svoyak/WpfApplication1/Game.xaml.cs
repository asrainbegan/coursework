using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Diagnostics;
using System.Windows.Threading;
using System.Data.SqlClient;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        DataTable DT = new DataTable();
        DispatcherTimer timer = new DispatcherTimer();
        DispatcherTimer timer1 = new DispatcherTimer();
        DispatcherTimer timer2 = new DispatcherTimer();
        DispatcherTimer timer3 = new DispatcherTimer();
        public Window1()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 5);
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = new TimeSpan(0, 0, 5);
            timer2.Tick += new EventHandler(timer2_Tick);
            timer2.Interval = new TimeSpan(0, 0, 5);
            timer3.Tick += new EventHandler(timer3_Tick);
            timer3.Interval = new TimeSpan(0, 0, 1);
            PG.Maximum = 15;
            PG.Value = 0;
            PG.Visibility = Visibility.Hidden;
            foreach (DataRow row in App.DataPuck.Rows)
            {
                siq.Items.Add(row["coast"]);
            }
            playerAvatar.Source = new BitmapImage(App.Avatarpath);
            ingamename.Content = App.username;
            AnswerBox.Visibility = Visibility.Hidden;
        }
        void timer3_Tick(object sender, EventArgs e)
        {
            if (PG.Value != 15)
            {
                PG.Visibility = Visibility.Visible;
                PG.Value += 1;
            }
            else
            {
                PG.Value = 0;
                Answer();
                
            }
        }

        void timer2_Tick(object sender, EventArgs e)
        {
            audioquest.Visibility = Visibility.Visible;
            questimage.Visibility = Visibility.Hidden;
            audioquest.LoadedBehavior = MediaState.Play;
            questionbox.Visibility = Visibility.Hidden;
            AnswerBox.Visibility = Visibility.Visible;
            timer2.Stop();
            timer3.Start();
           
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            questimage.Visibility = Visibility.Visible;
            audioquest.Visibility = Visibility.Hidden;
            questionbox.Visibility = Visibility.Hidden;
            AnswerBox.Visibility = Visibility.Visible;
            timer1.Stop();
            timer3.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            questimage.Visibility = Visibility.Visible;
            audioquest.Visibility = Visibility.Visible;
            audioquest.LoadedBehavior = MediaState.Play;
            questimage.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "\\" + "ef.png"));
            questionbox.Visibility = Visibility.Hidden;
            AnswerBox.Visibility = Visibility.Visible;
            timer.Stop();
            timer3.Start();
        }
        private void AnswerBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                Answer();
            }
        }
        private void Answer()
        {
            timer3.Stop();
            PG.Visibility = Visibility.Hidden;
            if (AnswerBox.Text == App.DataPuck.Rows[App.selected]["answer"].ToString())
            {
                App.score += Convert.ToInt32(App.DataPuck.Rows[App.selected]["coast"].ToString());
                siq.Visibility = Visibility.Visible;
                questionbox.Visibility = Visibility.Hidden;
                questimage.Visibility = Visibility.Hidden;
                audioquest.Visibility = Visibility.Hidden;
                audioquest.LoadedBehavior = MediaState.Pause;
                MessageBox.Show("Овет правильный" + Environment.NewLine + "+" + App.DataPuck.Rows[App.selected]["coast"].ToString());
                App.DataPuck.Rows.Remove(App.DataPuck.Rows[App.selected]);
                siq.Items.Remove(siq.Items[App.selected]);
                AnswerBox.Text = "";
                AnswerBox.Visibility = Visibility.Hidden;
                scorelabel.Content = App.score.ToString();
               


            }
            else
            {
                App.score -= Convert.ToInt32(App.DataPuck.Rows[App.selected]["coast"].ToString());
                siq.Visibility = Visibility.Visible;
                questionbox.Visibility = Visibility.Hidden;
                questimage.Visibility = Visibility.Hidden;
                audioquest.Visibility = Visibility.Hidden;
                audioquest.LoadedBehavior = MediaState.Pause;
                MessageBox.Show("Овет неправильный" + Environment.NewLine + "-" + App.DataPuck.Rows[App.selected]["coast"].ToString() + Environment.NewLine + "Правильный ответ - " + App.DataPuck.Rows[App.selected]["answer"].ToString());
                App.DataPuck.Rows.Remove(App.DataPuck.Rows[App.selected]);
                siq.Items.Remove(siq.Items[App.selected]);
                AnswerBox.Text = "";
                AnswerBox.Visibility = Visibility.Hidden;
                scorelabel.Content = App.score.ToString();

            }
            siq.SelectedIndex = -1;
            cost.Content = "";
            if (siq.Items.Count <= 0)

            {
                if (App.score > 0)
                {
                    MessageBox.Show("Вы выиграли со счетом " + App.score + "!");
                    recording();
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Вы проиграли со счетом " + App.score + "!");
                    recording();
                    MainWindow mw = new MainWindow();
                    mw.Show();
                    this.Close();
                }
            }
           
        }

        private void siq_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (siq.SelectedIndex != -1)
            {
                PG.Value = 0;
                int Selected = siq.SelectedIndex;
                DT = App.DataPuck;
                if (DT.Rows[Selected][0].ToString() == "Текстовый")
                {
                    questionbox.Text = DT.Rows[Selected]["question"].ToString();
                    AnswerBox.Visibility = Visibility.Visible;
                    siq.Visibility = Visibility.Hidden;
                    questionbox.Visibility = Visibility.Visible;
                    questimage.Visibility = Visibility.Hidden;
                    audioquest.Visibility = Visibility.Hidden;
                    cost.Content = DT.Rows[Selected]["coast"];
                    timer3.Start();
                }
                if (DT.Rows[Selected][0].ToString() == "Аудио")
                {
                    siq.Visibility = Visibility.Hidden;
                    questionbox.Visibility = Visibility.Visible;
                    questionbox.Text = DT.Rows[Selected]["question"].ToString();
                    audioquest.Source = new Uri(Environment.CurrentDirectory + "\\" + DT.Rows[Selected]["link"].ToString());
                    audioquest.LoadedBehavior = MediaState.Pause;
                    //audioquest.Play();
                    timer.Start();
                    cost.Content = DT.Rows[Selected]["coast"];
                }
                if (DT.Rows[Selected][0].ToString() == "Видео")
                {
                    siq.Visibility = Visibility.Hidden;
                    audioquest.Visibility = Visibility.Hidden;
                    questionbox.Visibility = Visibility.Visible;
                    questionbox.Text = DT.Rows[Selected]["question"].ToString();
                    audioquest.Source = new Uri(Environment.CurrentDirectory + "\\" + DT.Rows[Selected]["link"].ToString());
                    cost.Content = DT.Rows[Selected]["coast"];
                    audioquest.LoadedBehavior = MediaState.Pause;
                    timer2.Start();
                }
                if (DT.Rows[Selected][0].ToString() == "С картинкой")
                {
                    siq.Visibility = Visibility.Hidden;
                    questionbox.Visibility = Visibility.Visible;
                    questionbox.Text = DT.Rows[Selected]["question"].ToString();
                    questimage.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "\\" + DT.Rows[Selected]["link"].ToString()));
                    cost.Content = DT.Rows[Selected]["coast"];
                    questimage.Visibility = Visibility.Hidden;
                    timer1.Start();
                }
                App.selected = siq.SelectedIndex;
            }
            siq.SelectedIndex = -1;
        }
        private void recording()
        {
            SqlConnection connect = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM MainTable WHERE [Имя игрока] = '" + App.username + "' AND [Имя пакета] = '" + App.Packetpath +"'", connect);
            DataSet ds = new DataSet();
            da.Fill(ds, "Records");
            if (ds.Tables["Records"].Rows.Count > 0)
            {
                if(Convert.ToInt32(ds.Tables["Records"].Rows[0]["Счет"].ToString()) < App.score)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE [MainTable] SET Счет = '" + App.score + "' WHERE [Имя игрока] = '" + App.username + "' AND [Имя пакета] = '" + App.Packetpath + "' AND Счет < " + App.score + "", connect);
                    MessageBox.Show(cmd.CommandText);
                    connect.Open();
                    cmd.ExecuteNonQuery();
                    connect.Close();
                }

            }
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO MainTable ([Счет], [Имя игрока], [Имя пакета]) VALUES('" + App.score + "', '" + App.username + "', '" + App.Packetpath + "')", connect);
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();
            }
            //"UPDATE [MainTable] SET [Счет] = '" + App.score + "' WHERE [Имя игрока] = '" + App.username + "' AND [Имя пакета] = '" + App.Packetpath + "' AND [Cчет] < '" + App.score + "'"
            //' IF @@ROWCOUNT = 0 INSERT INTO MainTable ([Счет], [Имя игрока], [Имя пакета]) VALUES('" + App.score + "', '" + App.username + "', '" + App.Packetpath + "')"
        }

        private void audioquest_MediaEnded(object sender, RoutedEventArgs e)
        {
           
        }

        private void audioquest_MediaOpened(object sender, RoutedEventArgs e)
        {
            
        }
    }
}

