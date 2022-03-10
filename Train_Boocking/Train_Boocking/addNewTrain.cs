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
    public partial class addNewTrain : Form
    {
        private Point lastLocation;

        public addNewTrain()
        {
            InitializeComponent();
        }

        private void addNewTrain_Load(object sender, EventArgs e)
        {
            txtName.Select();
        }

        private void btnAddNewTrain_Click(object sender, EventArgs e)
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

                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid inputes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtID.Select();
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMove.Select();
            }
        }

        private void txtMove_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtArrive.Select();
            }
        }

        private void txtArrive_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDeiverID.Select();
            }
        }

        private void txtDeiverID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddNewTrain.PerformClick();
            }
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

        private void btnAddNewTrain_MouseEnter(object sender, EventArgs e)
        {
            btnAddNewTrain.ForeColor = Color.White;
        }

        private void btnAddNewTrain_MouseLeave(object sender, EventArgs e)
        {
            btnAddNewTrain.ForeColor = Color.Black;
        }
    }
}