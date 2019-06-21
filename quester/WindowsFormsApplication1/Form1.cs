using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        DataTable Dt = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dt.Columns.Add("type");
            Dt.Columns.Add("question");
            Dt.Columns.Add("link");
            Dt.Columns.Add("coast");
            Dt.Columns.Add("answer");
            dataGridView1.DataSource = Dt.DefaultView;
            dataGridView1.AutoSize = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog Sfd = new SaveFileDialog();
            Sfd.ShowDialog();
            try
            {
                DataSet DS = new DataSet();
                Dt.TableName = "puck";
                DS.Tables.Add(Dt.Copy());
                DS.WriteXml(Sfd.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
