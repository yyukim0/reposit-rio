namespace ProjetoPi
{
    partial class Tabuleiro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlA = new Panel();
            pnlB = new Panel();
            pnlC = new Panel();
            pnlD = new Panel();
            pnlK = new Panel();
            pnlH = new Panel();
            pnlG = new Panel();
            pnlE = new Panel();
            pnlR = new Panel();
            pnlQ = new Panel();
            pnlM = new Panel();
            pnlL = new Panel();
            SuspendLayout();
            // 
            // pnlA
            // 
            pnlA.BackgroundImage = Properties.Resources.Adilson;
            pnlA.BackgroundImageLayout = ImageLayout.Stretch;
            pnlA.Location = new Point(133, 391);
            pnlA.Name = "pnlA";
            pnlA.Size = new Size(51, 49);
            pnlA.TabIndex = 0;
            pnlA.Visible = false;
            // 
            // pnlB
            // 
            pnlB.BackgroundImage = Properties.Resources.Beatriz;
            pnlB.BackgroundImageLayout = ImageLayout.Stretch;
            pnlB.Location = new Point(190, 391);
            pnlB.Name = "pnlB";
            pnlB.Size = new Size(51, 49);
            pnlB.TabIndex = 1;
            pnlB.Visible = false;
            // 
            // pnlC
            // 
            pnlC.BackgroundImage = Properties.Resources.Claro;
            pnlC.BackgroundImageLayout = ImageLayout.Stretch;
            pnlC.Location = new Point(247, 391);
            pnlC.Name = "pnlC";
            pnlC.Size = new Size(51, 49);
            pnlC.TabIndex = 2;
            pnlC.Visible = false;
            pnlC.Paint += pnlC_Paint;
            // 
            // pnlD
            // 
            pnlD.BackgroundImage = Properties.Resources.D;
            pnlD.BackgroundImageLayout = ImageLayout.Stretch;
            pnlD.Location = new Point(304, 391);
            pnlD.Name = "pnlD";
            pnlD.Size = new Size(51, 49);
            pnlD.TabIndex = 3;
            pnlD.Visible = false;
            // 
            // pnlK
            // 
            pnlK.BackgroundImage = Properties.Resources.K;
            pnlK.BackgroundImageLayout = ImageLayout.Stretch;
            pnlK.Location = new Point(304, 320);
            pnlK.Name = "pnlK";
            pnlK.Size = new Size(51, 49);
            pnlK.TabIndex = 7;
            pnlK.Visible = false;
            pnlK.Paint += panel4_Paint;
            // 
            // pnlH
            // 
            pnlH.BackgroundImage = Properties.Resources.H;
            pnlH.BackgroundImageLayout = ImageLayout.Stretch;
            pnlH.Location = new Point(247, 320);
            pnlH.Name = "pnlH";
            pnlH.Size = new Size(51, 49);
            pnlH.TabIndex = 6;
            pnlH.Visible = false;
            // 
            // pnlG
            // 
            pnlG.BackgroundImage = Properties.Resources.G;
            pnlG.BackgroundImageLayout = ImageLayout.Stretch;
            pnlG.Location = new Point(190, 320);
            pnlG.Name = "pnlG";
            pnlG.Size = new Size(51, 49);
            pnlG.TabIndex = 5;
            pnlG.Visible = false;
            // 
            // pnlE
            // 
            pnlE.BackgroundImage = Properties.Resources.E;
            pnlE.BackgroundImageLayout = ImageLayout.Stretch;
            pnlE.Location = new Point(133, 320);
            pnlE.Name = "pnlE";
            pnlE.Size = new Size(51, 49);
            pnlE.TabIndex = 4;
            pnlE.Visible = false;
            // 
            // pnlR
            // 
            pnlR.BackgroundImage = Properties.Resources.R;
            pnlR.BackgroundImageLayout = ImageLayout.Stretch;
            pnlR.Location = new Point(304, 250);
            pnlR.Name = "pnlR";
            pnlR.Size = new Size(51, 49);
            pnlR.TabIndex = 11;
            pnlR.Visible = false;
            // 
            // pnlQ
            // 
            pnlQ.BackgroundImage = Properties.Resources.Q;
            pnlQ.BackgroundImageLayout = ImageLayout.Stretch;
            pnlQ.Location = new Point(247, 250);
            pnlQ.Name = "pnlQ";
            pnlQ.Size = new Size(51, 49);
            pnlQ.TabIndex = 10;
            pnlQ.Visible = false;
            // 
            // pnlM
            // 
            pnlM.BackgroundImage = Properties.Resources.M;
            pnlM.BackgroundImageLayout = ImageLayout.Stretch;
            pnlM.Location = new Point(190, 250);
            pnlM.Name = "pnlM";
            pnlM.Size = new Size(51, 49);
            pnlM.TabIndex = 9;
            pnlM.Visible = false;
            // 
            // pnlL
            // 
            pnlL.BackgroundImage = Properties.Resources.L;
            pnlL.BackgroundImageLayout = ImageLayout.Stretch;
            pnlL.Location = new Point(133, 250);
            pnlL.Name = "pnlL";
            pnlL.Size = new Size(51, 49);
            pnlL.TabIndex = 8;
            pnlL.Visible = false;
            // 
            // Tabuleiro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.tabuleiro;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(469, 520);
            Controls.Add(pnlR);
            Controls.Add(pnlK);
            Controls.Add(pnlQ);
            Controls.Add(pnlM);
            Controls.Add(pnlD);
            Controls.Add(pnlL);
            Controls.Add(pnlH);
            Controls.Add(pnlC);
            Controls.Add(pnlG);
            Controls.Add(pnlE);
            Controls.Add(pnlB);
            Controls.Add(pnlA);
            DoubleBuffered = true;
            Name = "Tabuleiro";
            Text = "Tabuleiro";
            Load += Tabuleiro_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlA;
        private Panel pnlB;
        private Panel pnlC;
        private Panel pnlD;
        private Panel pnlK;
        private Panel pnlH;
        private Panel pnlG;
        private Panel pnlE;
        private Panel pnlR;
        private Panel pnlQ;
        private Panel pnlM;
        private Panel pnlL;
    }
}