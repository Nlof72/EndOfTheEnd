using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        Model model;
        public Form1()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            model = new Model((double)Lambda.Value, (double)Mu.Value, (int)N.Value, (double)T.Value, (int)Operators.Value);
            model.Simulate();
            Dictionary<int, double> Freq = model.Freq;
            Dictionary<int, double> Stat = model.Stat;

            foreach (int i in Freq.Keys)
            {
                chart1.Series[0].Points.AddXY(i, Freq[i]);
            }
            foreach (int i in Stat.Keys)
            {
                chart1.Series[1].Points.AddXY(i, Stat[i]);
            }
        }
    }
}
