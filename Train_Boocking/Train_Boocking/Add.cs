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
    public partial class Add : Form
    {
        DataTable dataTable;

        public Add(ref DataTable dataTable)
        {
            InitializeComponent();

            this.dataTable = dataTable;
        }

        private void Add_Load(object sender, EventArgs e)
        {
            populateItems();
        }

        private void btnAddNewTrain_MouseEnter(object sender, EventArgs e)
        {
            btnAddNewTrain.ForeColor = Color.White;
        }

        private void btnAddNewTrain_MouseLeave(object sender, EventArgs e)
        {
            btnAddNewTrain.ForeColor = Color.Black;
        }

        private void populateItems()
        {
            flowLayoutPanel1.Controls.Clear();
            TrainDef[] trainDefs = new TrainDef[dataTable.Rows.Count];
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                trainDefs[i] = new TrainDef();
                trainDefs[i].Title = dataTable.Rows[i]["TrainName"].ToString();
                trainDefs[i].ID = dataTable.Rows[i]["TrainID"].ToString();
                trainDefs[i].Icon = Image.FromFile("train.png");
                trainDefs[i].Background = Color.Gray;
                
                flowLayoutPanel1.Controls.Add(trainDefs[i]);
            }
        }

        private void btnAddNewTrain_Click(object sender, EventArgs e)
        {
            addNewTrain ant = new addNewTrain();
            if (ant.ShowDialog() == DialogResult.Cancel)
                populateItems();
        }
    }
}
