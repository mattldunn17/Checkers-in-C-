using System;
using System.IO;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            // creates the game
            Game g = new Game(redname.Text, bluename.Text);
            g.Show();
        }
        
        private void closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
