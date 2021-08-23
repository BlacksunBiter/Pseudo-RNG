
namespace PseudoRandomNumberGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControlAllGen = new System.Windows.Forms.TabControl();
            this.MiddleSquareMethod = new System.Windows.Forms.TabPage();
            this.ClearButPullRandNum = new System.Windows.Forms.Button();
            this.TestBut = new System.Windows.Forms.Button();
            this.PullRandNum = new System.Windows.Forms.TextBox();
            this.MSM_FirstNum = new System.Windows.Forms.TextBox();
            this.MSM_StartBut = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PushBut = new System.Windows.Forms.Button();
            this.TakeBut = new System.Windows.Forms.Button();
            this.AllPullbut = new System.Windows.Forms.Button();
            this.MSM_FirstRandNum = new System.Windows.Forms.TextBox();
            this.TabControlAllGen.SuspendLayout();
            this.MiddleSquareMethod.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControlAllGen
            // 
            this.TabControlAllGen.Controls.Add(this.MiddleSquareMethod);
            this.TabControlAllGen.Controls.Add(this.tabPage2);
            this.TabControlAllGen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlAllGen.Location = new System.Drawing.Point(0, 0);
            this.TabControlAllGen.Name = "TabControlAllGen";
            this.TabControlAllGen.SelectedIndex = 0;
            this.TabControlAllGen.Size = new System.Drawing.Size(1308, 776);
            this.TabControlAllGen.TabIndex = 0;
            // 
            // MiddleSquareMethod
            // 
            this.MiddleSquareMethod.Controls.Add(this.MSM_FirstRandNum);
            this.MiddleSquareMethod.Controls.Add(this.AllPullbut);
            this.MiddleSquareMethod.Controls.Add(this.TakeBut);
            this.MiddleSquareMethod.Controls.Add(this.PushBut);
            this.MiddleSquareMethod.Controls.Add(this.ClearButPullRandNum);
            this.MiddleSquareMethod.Controls.Add(this.TestBut);
            this.MiddleSquareMethod.Controls.Add(this.PullRandNum);
            this.MiddleSquareMethod.Controls.Add(this.MSM_FirstNum);
            this.MiddleSquareMethod.Controls.Add(this.MSM_StartBut);
            this.MiddleSquareMethod.Location = new System.Drawing.Point(4, 22);
            this.MiddleSquareMethod.Name = "MiddleSquareMethod";
            this.MiddleSquareMethod.Padding = new System.Windows.Forms.Padding(3);
            this.MiddleSquareMethod.Size = new System.Drawing.Size(1300, 750);
            this.MiddleSquareMethod.TabIndex = 0;
            this.MiddleSquareMethod.Text = "Middle-SquareMethod";
            this.MiddleSquareMethod.UseVisualStyleBackColor = true;
            // 
            // ClearButPullRandNum
            // 
            this.ClearButPullRandNum.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButPullRandNum.Location = new System.Drawing.Point(420, 623);
            this.ClearButPullRandNum.Name = "ClearButPullRandNum";
            this.ClearButPullRandNum.Size = new System.Drawing.Size(122, 38);
            this.ClearButPullRandNum.TabIndex = 4;
            this.ClearButPullRandNum.Text = "Clear";
            this.ClearButPullRandNum.UseVisualStyleBackColor = true;
            this.ClearButPullRandNum.Click += new System.EventHandler(this.ClearButPullRandNum_Click);
            // 
            // TestBut
            // 
            this.TestBut.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestBut.Location = new System.Drawing.Point(61, 527);
            this.TestBut.Name = "TestBut";
            this.TestBut.Size = new System.Drawing.Size(122, 38);
            this.TestBut.TabIndex = 3;
            this.TestBut.Text = "Test";
            this.TestBut.UseVisualStyleBackColor = true;
            this.TestBut.Click += new System.EventHandler(this.TestBut_Click);
            // 
            // PullRandNum
            // 
            this.PullRandNum.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PullRandNum.Location = new System.Drawing.Point(548, 16);
            this.PullRandNum.Multiline = true;
            this.PullRandNum.Name = "PullRandNum";
            this.PullRandNum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PullRandNum.Size = new System.Drawing.Size(684, 645);
            this.PullRandNum.TabIndex = 2;
            // 
            // MSM_FirstNum
            // 
            this.MSM_FirstNum.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MSM_FirstNum.Location = new System.Drawing.Point(17, 37);
            this.MSM_FirstNum.Name = "MSM_FirstNum";
            this.MSM_FirstNum.Size = new System.Drawing.Size(113, 31);
            this.MSM_FirstNum.TabIndex = 1;
            this.MSM_FirstNum.Text = "1234";
            // 
            // MSM_StartBut
            // 
            this.MSM_StartBut.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MSM_StartBut.Location = new System.Drawing.Point(136, 90);
            this.MSM_StartBut.Name = "MSM_StartBut";
            this.MSM_StartBut.Size = new System.Drawing.Size(122, 38);
            this.MSM_StartBut.TabIndex = 0;
            this.MSM_StartBut.Text = "GetRandom";
            this.MSM_StartBut.UseVisualStyleBackColor = true;
            this.MSM_StartBut.Click += new System.EventHandler(this.MSM_StartBut_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1300, 750);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PushBut
            // 
            this.PushBut.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PushBut.Location = new System.Drawing.Point(264, 65);
            this.PushBut.Name = "PushBut";
            this.PushBut.Size = new System.Drawing.Size(122, 38);
            this.PushBut.TabIndex = 5;
            this.PushBut.Text = "GetPush";
            this.PushBut.UseVisualStyleBackColor = true;
            this.PushBut.Click += new System.EventHandler(this.PushBut_Click);
            // 
            // TakeBut
            // 
            this.TakeBut.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TakeBut.Location = new System.Drawing.Point(136, 37);
            this.TakeBut.Name = "TakeBut";
            this.TakeBut.Size = new System.Drawing.Size(122, 38);
            this.TakeBut.TabIndex = 6;
            this.TakeBut.Text = "Take";
            this.TakeBut.UseVisualStyleBackColor = true;
            this.TakeBut.Click += new System.EventHandler(this.TakeBut_Click);
            // 
            // AllPullbut
            // 
            this.AllPullbut.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllPullbut.Location = new System.Drawing.Point(392, 65);
            this.AllPullbut.Name = "AllPullbut";
            this.AllPullbut.Size = new System.Drawing.Size(122, 38);
            this.AllPullbut.TabIndex = 7;
            this.AllPullbut.Text = "GetAllPull";
            this.AllPullbut.UseVisualStyleBackColor = true;
            this.AllPullbut.Click += new System.EventHandler(this.AllPullbut_Click);
            // 
            // MSM_FirstRandNum
            // 
            this.MSM_FirstRandNum.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MSM_FirstRandNum.Location = new System.Drawing.Point(17, 97);
            this.MSM_FirstRandNum.Name = "MSM_FirstRandNum";
            this.MSM_FirstRandNum.ReadOnly = true;
            this.MSM_FirstRandNum.Size = new System.Drawing.Size(113, 31);
            this.MSM_FirstRandNum.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 776);
            this.Controls.Add(this.TabControlAllGen);
            this.Name = "MainForm";
            this.Text = "PRNG";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControlAllGen.ResumeLayout(false);
            this.MiddleSquareMethod.ResumeLayout(false);
            this.MiddleSquareMethod.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControlAllGen;
        private System.Windows.Forms.TabPage MiddleSquareMethod;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox PullRandNum;
        private System.Windows.Forms.TextBox MSM_FirstNum;
        private System.Windows.Forms.Button MSM_StartBut;
        private System.Windows.Forms.Button TestBut;
        private System.Windows.Forms.Button ClearButPullRandNum;
        private System.Windows.Forms.Button PushBut;
        private System.Windows.Forms.Button TakeBut;
        private System.Windows.Forms.Button AllPullbut;
        private System.Windows.Forms.TextBox MSM_FirstRandNum;
    }
}

