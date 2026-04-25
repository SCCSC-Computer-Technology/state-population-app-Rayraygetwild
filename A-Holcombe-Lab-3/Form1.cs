using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_Holcombe_Lab_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.statesDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'statesDBDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.statesDBDataSet.Table);

        }

        private void buttNext_Click(object sender, EventArgs e)
        {

                StatesInfo statesInfo = new StatesInfo();//Navigation to another form
                statesInfo.ShowDialog();

        }

        private void buttExit_Click(object sender, EventArgs e)
        {
            //this closes the form
            //Configuring MessageBox
            MessageBox.Show("Until Next Time!", "We Hate To See You Go!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Close();
        }
    }
}
