using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers
{
    public partial class RuleList : Form
    {
        public RuleList()
        {
            InitializeComponent();
        }

        // opens rules window when an instance is created
        public RuleList(string type)
        {
            if (type == "Open")
            {
                RuleList rulesWindow = new RuleList();
                rulesWindow.Show();
            }
        }

        // closes from
        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --------------------------------------------------------------------------------------------------------------------
        // unused functions
        // --------------------------------------------------------------------------------------------------------------------
        public void RuleList_Load(object sender, EventArgs e)
        {            
        }

        private void ruleBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void ruleBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void ruleBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void ruleBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void ruleTitle_TextChanged(object sender, EventArgs e)
        {
        }

        private void ruleBox2_TextChanged(object sender, EventArgs e)
        {
        } 
    }
}
