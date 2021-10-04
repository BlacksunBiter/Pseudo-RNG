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
        #region MiddleSquare
        MiddleSquare nG;
        private void MSM_StartBut_Click(object sender, EventArgs e)
        {
            nG = new MiddleSquare();
            MSM_FirstRandNum.AppendText(nG._seed + "");
        }

        private void ClearButPullRandNum_Click(object sender, EventArgs e)
        {
            PullRandNum.Clear();
        }

        private void PushBut_Click(object sender, EventArgs e)
        {
            PullRandNum.AppendText(nG._counter + ") " + nG.Rand() + "\r\n");

        }

        private void TakeBut_Click(object sender, EventArgs e)
        {
            nG = new MiddleSquare(ulong.Parse(MSM_FirstValue.Text));
        }

        private void AllPullbut_Click(object sender, EventArgs e)
        {
            ulong temp = 0;
            List<ulong> alreadySeen = new List<ulong>();
            bool notIn = true;
            do
            {
                temp = nG.Rand();
                PullRandNum.AppendText(nG._counter + ") " + temp + "\r\n");
                if (alreadySeen.Contains(temp))
                    notIn = false;
                alreadySeen.Add(temp);
            } while (notIn);
        }
        #endregion

        #region LinearCongruential
        LinearCongruential lC;
        private void LCG_TakeSeedButt_Click(object sender, EventArgs e)
        {
            ulong m = ulong.Parse(ModulusText.Text);
            ulong a = ulong.Parse(MultiplierText.Text);
            ulong c = ulong.Parse(IncrementText.Text);
            ulong s = ulong.Parse(StartValueText.Text);
            if (m < 2)
                MessageBox.Show("m<2");
            else
            if (a <= 0 && a >= m)
                MessageBox.Show("a<=0 or a>=m");
            else
            if (c < 0 && c >= m)
                MessageBox.Show("c<0 or c>=m");
            else
            if (s >= m)
                MessageBox.Show("s>=m");
            else
                lC = new LinearCongruential(m, a, c, s);
        }

        private void LCG_GetSeedButt_Click(object sender, EventArgs e)
        {
            lC = new LinearCongruential();
        }        

        private void LCG_PushButt_Click(object sender, EventArgs e)
        {
            LCG_PullRandNum.AppendText(lC._counter + ") " + lC.Rand() + "\r\n");
        }

        private void LCG_AllPullButt_Click(object sender, EventArgs e)
        {
            ulong temp = 0;
            List<ulong> alreadySeen = new List<ulong>();
            bool notIn = true;
            do
            {
                temp = lC.Rand();
                LCG_PullRandNum.AppendText(lC._counter + ") " + temp + "\r\n");
                LCG_PullRandNum.Update();
                if (alreadySeen.Contains(temp))
                    notIn = false;
                alreadySeen.Add(temp);
            } while (notIn);
        }        

        private void LCG_ClearBut_Click(object sender, EventArgs e)
        {
            LCG_PullRandNum.Clear();
        }
        #endregion

        #region LaggedFibonacciFibonacci
        LaggedFibonacci lF;
        private void LFGF_TakeSeedButt_Click(object sender, EventArgs e)
        {
            lF = new LaggedFibonacci(ulong.Parse(LfGF_textBox_m.Text), ulong.Parse(LfGF_textBox_Xn.Text), ulong.Parse(LfGF_textBox_Xn1.Text));
        }

        private void LFGF_PushButt_Click(object sender, EventArgs e)
        {
            LFG_PullRandNum.AppendText(lF._counter + ") " + lF.Rand() + "\r\n");
        }

        private void LFGF__AllPullButt_Click(object sender, EventArgs e)
        {
            ulong temp = 0;
            List<ulong> alreadySeen = new List<ulong>();
            bool notIn = true;
            do
            {
                temp = lF.Rand();
                LFG_PullRandNum.AppendText(lF._counter + ") " + temp + "\r\n");
                LFG_PullRandNum.Update();
                if (alreadySeen.Contains(temp))
                    notIn = false;
                alreadySeen.Add(temp);
            } while (notIn);
        }

        private void LFGF_ClearButt_Click(object sender, EventArgs e)
        {
            LFG_PullRandNum.Clear();
        }
        #endregion



























        private static string SplitToLines(string str, int n)
        {
            return Regex.Replace(str, ".{" + n + "}(?!$)", "$0\r\n");
        }
        private void TestBut_Click(object sender, EventArgs e)
        {
            PullRandNum.AppendText(SplitToLines("a1b2s3dqwertyuionb\b\f\a", 10));
        }

    }
}
