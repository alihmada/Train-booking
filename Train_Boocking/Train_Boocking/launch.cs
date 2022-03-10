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
    public partial class launch : Form
    {
        private Point lastLocation;
        private List<Train> trains;

        public launch()
        {
            InitializeComponent();

            Train.Trains_Table.Columns.Add("TrainID");
            Train.Trains_Table.Columns.Add("TrainName");
            Train.Trains_Table.Columns.Add("TrainMove");
            Train.Trains_Table.Columns.Add("TrainArrive");
            Train.Trains_Table.Columns.Add("DriverID");
            fillData(generateData());

            home H = new home(ref Train.Trains_Table) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            click("Home", btnHome, H);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            home H = new home(ref Train.Trains_Table) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            click("Home", btnHome, H);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Add A = new Add(ref Train.Trains_Table) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            click("Add", btnAdd, A);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }

        private void pnlMove_MouseDown(object sender, MouseEventArgs e)
        {
            lastLocation = e.Location;
            this.Opacity = 0.85;
        }

        private void pnlMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void pnlMove_MouseUp(object sender, MouseEventArgs e)
        {
            this.Opacity = 1;
        }

        private void click(string Title, Button button, Form form)
        {
            lblTitle.Text = Title;
            Panal_Moving(button);
            this.pnlControls.Controls.Clear();
            this.pnlControls.Controls.Add(form);
            form.Show();
            Cursor.Current = Cursors.Default;
        }

        private void Panal_Moving(Button button)
        {
            pnlSide.Height = button.Height;
            pnlSide.Top = button.Top;
            pnlSide.Left = button.Left;
        }

        private List<Train> generateData()
        {
            trains = new List<Train>()
            {
                new Train("Agniveena Express",
                1001650,
                new DateTime(DateTime.Now.Year,DateTime.Now.Month, DateTime.Now.Day, 14, 30, 00),
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 00, 00),
                200557),

                new Train("Ahilyanagari Express",
                1001651,
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 06, 00, 00),
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 8, 00, 00),
                200558),

                new Train("Ahimsa Express",
                1001652,
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 00, 00),
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 00, 00),
                200559),

                new Train("Amarkantak Express",
                1001653,
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 00, 00),
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 00, 00),
                200560),

                new Train("Ajanta Express",
                1001654,
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 00, 00),
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 17, 20, 00),
                200561),

                new Train("Akal Takht Express",
                1001655,
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 18, 15, 00),
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 20, 00, 00),
                200562),

                new Train("Ala Hazrat Express",
                1001656,
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 7, 30, 00),
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 10, 00, 00),
                200563),

                new Train("Amarnath Express",
                1001657,
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 15, 00, 00),
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 16, 30, 00),
                200564),

                new Train("Amrapali Express",
                1001658,
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 00, 00),
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 14, 00, 00),
                200565),

                new Train("Amravathi Express",
                1001659,
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 9, 30, 00),
                new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 12, 00, 00),
                200566),
            };
            return trains;
        }

        private void fillData(List<Train> trains)
        {
            foreach (var train in trains)
                Train.Trains_Table.Rows.Add(train.Train_ID,
                            train.Train_Name,
                            train.Moving_Time,
                            train.Arriving_Time,
                            train.Driver_ID);
        }

    }
}
