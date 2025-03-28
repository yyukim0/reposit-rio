namespace ProjetoPi
{
    partial class Form2
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.botão_jogar;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(35, 162);
            button1.Name = "button1";
            button1.Size = new Size(190, 63);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(35, 335);
            label1.Name = "label1";
            label1.Size = new Size(373, 37);
            label1.TabIndex = 1;
            label1.Text = "Nenhuma Partida Selecionada";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.GrayText;
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(46, 399);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 27);
            textBox1.TabIndex = 2;
            textBox1.Text = "Scriptores de Chartres";
            // 
            // button2
            // 
            button2.Location = new Point(164, -117);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.botão_fechar;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Location = new Point(35, 242);
            button3.Name = "button3";
            button3.Size = new Size(190, 60);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.logo;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(35, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BackgroundImage = Properties.Resources.wallpaper;
            ClientSize = new Size(775, 459);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            MinimizeBox = false;
            MinimumSize = new Size(501, 498);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Panel panel1;
    }
}