using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project4.Code
{
    public partial class Start_menu : Form
    {

        private int seed;
        public int Seed
        {
            get { return seed; }
            set { seed = value; }
        }
        public Start_menu()
        {
            InitializeComponent();
        }

        private void EntryButton_Click(object sender, EventArgs e)
        {
        }

        private void trackBar_amount_Scroll(object sender, EventArgs e)
        {
            List<Control> groups = new List<Control>() { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5, groupBox6, groupBox7, groupBox8 };
            foreach (Control group in groups)
            {
                group.Enabled = false;
            }
            for (int i = 0; i < trackBar_amount.Value; i++)
            {
                groups[i].Enabled = true;
            }
        }

    }
}
