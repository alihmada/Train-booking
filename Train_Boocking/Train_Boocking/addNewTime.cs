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
    public partial class addNewTime : Form
    {
        private Point lastLocation;

        DataView dataView;

        public addNewTime(string name, string id, DataTable dataTable)
        {
            InitializeComponent();

            txtName.Text = name;
            txtID.Text = id;
            dataView = new DataView(dataTable);
            dataView.RowFilter = $"TrainID LIKE '%{id}%'";
            populateListView(dataView);
        }

        private void addNewTime_Load(object sender, EventArgs e)
        {
            txtMove.Select();
        }

        private void btnAddNewTime_MouseEnter(object sender, EventArgs e)
        {
            btnAddNewTime.ForeColor = Color.White;
        }

        private void btnAddNewTime_MouseLeave(object sender, EventArgs e)
        {
            btnAddNewTime.ForeColor = Color.Black;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
            this.Opacity = 0.85;
        }

        private void _MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void _MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
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
                        row[4].ToString(),
                        row[2].ToString(),
                        row[3].ToString(),
                    }));
            }
        }

        private void btnAddNewTime_Click(object sender, EventArgs e)
        {
            try
            {
                Train train = new Train(txtName.Text,
                    int.Parse(txtID.Text),
                    DateTime.Parse(txtMove.Text),
                    DateTime.Parse(txtArrive.Text),
                    int.Parse(txtDeiverID.Text));

                Train.Trains_Table.Rows.Add(train.Train_ID,
                            train.Train_Name,
                            train.Moving_Time,
                            train.Arriving_Time,
                            train.Driver_ID);

                dataView = new DataView(Train.Trains_Table);
                dataView.RowFilter = $"TrainID LIKE '%{txtID.Text}%'";
                populateListView(dataView);

                txtMove.Select();
                txtMove.SelectAll();
            }
            catch
            {
                MessageBox.Show("Invalid inputes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMove_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtArrive.Select();
                txtArrive.SelectAll();
            }
        }

        private void txtArrive_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDeiverID.Select();
                txtDeiverID.SelectAll();
            }
        }

        private void txtDeiverID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddNewTime.PerformClick();
            }
        }

    }
}
