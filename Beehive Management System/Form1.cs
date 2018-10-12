using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beehive_Management_System
{
    public partial class Form1 : Form
    {
        private Queen _queen;
        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" });
            _queen = new Queen(workers);
        }

        private void assign_Click(object sender, EventArgs e)
        {
            if (_queen.AssignWork(workerBeeJob.Text, (int) shifts.Value))
                MessageBox.Show(@"Job Assigned!");
            else
                MessageBox.Show(@"No available bees!");
        }

        private void nextShift_Click(object sender, EventArgs e)
        {

        }
    }
}
