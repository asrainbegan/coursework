using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для Records.xaml
    /// </summary>
    public partial class Records : Window
    {
        public Records()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfApplication1.Database1DataSet database1DataSet = ((WpfApplication1.Database1DataSet)(this.FindResource("database1DataSet")));
            // Загрузить данные в таблицу MainTable. Можно изменить этот код как требуется.
            WpfApplication1.Database1DataSetTableAdapters.MainTableTableAdapter database1DataSetMainTableTableAdapter = new WpfApplication1.Database1DataSetTableAdapters.MainTableTableAdapter();
            database1DataSetMainTableTableAdapter.Fill(database1DataSet.MainTable);
            System.Windows.Data.CollectionViewSource mainTableViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("mainTableViewSource")));
            mainTableViewSource.View.MoveCurrentToFirst();
        }
    }
}
