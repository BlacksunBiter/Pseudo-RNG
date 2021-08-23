using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoRandomNumberGenerator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        MiddleSquare nG;
        private void MSM_StartBut_Click(object sender, EventArgs e)
        {
            nG = new MiddleSquare();
            MSM_FirstRandNum.Text += nG.SeedNumber;
        }
        public static string SplitToLines(string str, int n)
        {
            return Regex.Replace(str, ".{" + n + "}(?!$)", "$0\r\n");
        }

        private void TestBut_Click(object sender, EventArgs e)
        {
            PullRandNum.Text += SplitToLines("a1b2s3dqwertyuionb\b\f\a", 10);
        }

        private void ClearButPullRandNum_Click(object sender, EventArgs e)
        {
            PullRandNum.Clear();
        }

        private void PushBut_Click(object sender, EventArgs e)
        {
            PullRandNum.Text += nG.Counter + ") " + nG.MiddleMiddle() + "\r\n";

        }

        private void TakeBut_Click(object sender, EventArgs e)
        {
            nG = new MiddleSquare(Int64.Parse(MSM_FirstNum.Text));
        }

        private void AllPullbut_Click(object sender, EventArgs e)
        {
            Int64 temp = 0;
            List<Int64> alreadySeen = new List<Int64>();
            bool notIn = true;
            do
            {
                temp = nG.MiddleMiddle();
                PullRandNum.Text += nG.Counter + ") " + temp + "\r\n";
                if (alreadySeen.Contains(temp))
                    notIn = false;
                alreadySeen.Add(temp);
            } while (notIn);
        }
    }
}
