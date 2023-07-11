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
        public bool entry_end = false; 
        List<Control> groups = new List<Control>();
        public List<int> cB_values = new List<int>();
        private int seed;
        public int Seed
        {
            get { return seed; }
            set { seed = value; }
        }
        private int amount_masters;

        public int Amount_masters 
        { 
            get { return amount_masters; }
            set { amount_masters = value; }
        }
        public Start_menu()
        {
            InitializeComponent();
        }

        private void Start_menu_Load(object sender, EventArgs e)
        {
            groups.AddRange(new Control[] { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5, groupBox6, groupBox7, groupBox8 });
        }

        private void EntryButton_Click(object sender, EventArgs e)
        {
            List<ComboBox> cB_qual = new List<ComboBox>() { comboBox_qual1, comboBox_qual2, comboBox_qual3, comboBox_qual4, comboBox_qual5, comboBox_qual6, comboBox_qual7, comboBox_qual8 };
            List<ComboBox> cB_prof = new List<ComboBox>() { comboBox_prof1, comboBox_prof2, comboBox_prof3, comboBox_prof4, comboBox_prof5, comboBox_prof6, comboBox_prof7, comboBox_prof8 };
            
            for (int i = 0; i < trackBar_amount.Value; i++)
                cB_values.AddRange(new int[] { cB_qual[i].SelectedIndex, cB_prof[i].SelectedIndex});
            
            Seed = textBox_seed.Text.GetHashCode();
            Amount_masters = trackBar_amount.Value;
            entry_end = true;
        }
        private void trackBar_amount_Scroll(object sender, EventArgs e)
        {
            foreach (Control group in groups)
                group.Enabled = false;

            for (int i = 0; i < trackBar_amount.Value; i++)
                groups[i].Enabled = true;

        }

    }
}
