using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_Boocking
{
    public partial class home : Form
    {
        private DataTable dataTable;
        private DataView dataView;
        private int selestedItemIndex = 0;
        private bool run = false;
        
        public home(ref DataTable dataTable)
        {
            InitializeComponent();
            
            cmbSearch.SelectedIndex = 0;

            this.dataTable = dataTable;
            
            dataView = new DataView(dataTable);
            populateListView(dataView);
        }

        private void home_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();
            txtSearch.Select();
        }

        private void populateListView(DataView dv)
        {
            listView1.Items.Clear();
            foreach (DataRow row in dv.ToTable().Rows)
            {
                listView1.Items.Add(
                    new ListViewItem(
                    new String[]
                    {
                        row[0].ToString(),
                        row[1].ToString(),
                        row[2].ToString(),
                        row[3].ToString(),
                        row[4].ToString()
                    }));
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            switch (selestedItemIndex)
            {
                case 0:
                    dataView.RowFilter = $"TrainID LIKE '%{txtSearch.Text}%'";
                    break;
                case 1:
                    dataView.RowFilter = $"TrainName LIKE '%{txtSearch.Text}%'";
                    break;
                case 2:
                    dataView.RowFilter = $"TrainMove LIKE '%{txtSearch.Text}%'";
                    break;
                case 3:
                    dataView.RowFilter = $"TrainArrive LIKE '%{txtSearch.Text}%'";
                    break;
                case 4:
                    dataView.RowFilter = $"DriverID LIKE '%{txtSearch.Text}%'";
                    break;
                default:
                    break;
            }
            populateListView(dataView);
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            selestedItemIndex = cmbSearch.SelectedIndex;
            if (run)
                txtSearch_TextChanged(sender, e);
            run = true;
            txtSearch.Select();
            txtSearch.SelectAll();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtSearch.Select();
            txtSearch.SelectAll();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("T");
        }
    }
}
