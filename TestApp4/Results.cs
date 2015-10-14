using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestApp
{
    public partial class Results : Form
    {
        Dictionary<string, int> userMap = GameWindow.getMap();
        public Results()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FinalScreen f3 = new FinalScreen();
            f3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            label1.Text = userMap["Box of Matches"].ToString();
        }
    }
}
