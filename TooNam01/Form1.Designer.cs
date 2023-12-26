namespace TooNam01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BlackCofBut = new Button();
            MochaBut = new Button();
            LatteBut = new Button();
            ChocoBut = new Button();
            OutRaw = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)OutRaw).BeginInit();
            SuspendLayout();
            // 
            // BlackCofBut
            // 
            BlackCofBut.BackgroundImage = Properties.Resources.BlackCof;
            BlackCofBut.Location = new Point(219, 187);
            BlackCofBut.Name = "BlackCofBut";
            BlackCofBut.Size = new Size(120, 120);
            BlackCofBut.TabIndex = 0;
            BlackCofBut.UseVisualStyleBackColor = true;
            BlackCofBut.Click += BlackCofBut_Click;
            // 
            // MochaBut
            // 
            MochaBut.BackgroundImage = Properties.Resources.Mocha;
            MochaBut.Location = new Point(345, 188);
            MochaBut.Name = "MochaBut";
            MochaBut.Size = new Size(120, 120);
            MochaBut.TabIndex = 1;
            MochaBut.UseVisualStyleBackColor = true;
            MochaBut.Click += MochaBut_Click;
            // 
            // LatteBut
            // 
            LatteBut.BackgroundImage = Properties.Resources.Latte;
            LatteBut.Location = new Point(219, 359);
            LatteBut.Name = "LatteBut";
            LatteBut.Size = new Size(120, 120);
            LatteBut.TabIndex = 2;
            LatteBut.UseVisualStyleBackColor = true;
            LatteBut.Click += LatteBut_Click;
            // 
            // ChocoBut
            // 
            ChocoBut.BackgroundImage = Properties.Resources.Choco;
            ChocoBut.Location = new Point(345, 359);
            ChocoBut.Name = "ChocoBut";
            ChocoBut.Size = new Size(120, 120);
            ChocoBut.TabIndex = 3;
            ChocoBut.UseVisualStyleBackColor = true;
            ChocoBut.Click += ChocoBut_Click;
            // 
            // OutRaw
            // 
            OutRaw.BackgroundImage = Properties.Resources.OutRaw;
            OutRaw.Location = new Point(290, 599);
            OutRaw.Name = "OutRaw";
            OutRaw.Size = new Size(114, 160);
            OutRaw.TabIndex = 4;
            OutRaw.TabStop = false;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Restack;
            button1.Location = new Point(547, 829);
            button1.Name = "button1";
            button1.Size = new Size(120, 120);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Taobid_bg1;
            ClientSize = new Size(691, 961);
            Controls.Add(button1);
            Controls.Add(OutRaw);
            Controls.Add(ChocoBut);
            Controls.Add(LatteBut);
            Controls.Add(MochaBut);
            Controls.Add(BlackCofBut);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)OutRaw).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button BlackCofBut;
        private Button MochaBut;
        private Button LatteBut;
        private Button ChocoBut;
        private PictureBox OutRaw;
        private Button button1;
    }
}