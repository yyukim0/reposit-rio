namespace ProjetoPi
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
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox2 = new ListBox();
            label4 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            lblCartas = new Label();
            button5 = new Button();
            txtRequestSala = new TextBox();
            lblPedirSala = new Label();
            lblPedirSenha = new Label();
            txtRequestSenha = new TextBox();
            lblPedirGrupo = new Label();
            txtRequestGrupo = new TextBox();
            lblPedirNome = new Label();
            txtRequestNome = new TextBox();
            lblPedirId = new Label();
            txtRequestId = new TextBox();
            lblSenhaId = new Label();
            button6 = new Button();
            txtRequestIdJogador = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtRequestSenhaJogador = new TextBox();
            btnVerificarVez = new Button();
            lstSetores = new ListBox();
            lstPersonagens = new ListBox();
            lblSetores = new Label();
            lblPersonagens = new Label();
            lblRequestSetores = new Label();
            lblRequestPersonagem = new Label();
            txtRequestSetor = new TextBox();
            txtRequestPersonagem = new TextBox();
            btnColocarPersonagem = new Button();
            txtTabuleiro = new TextBox();
            lblIdJogadorVez = new Label();
            lblNomeJogadorVez = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 206);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 51);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 269);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(181, 79);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(386, 396);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 423);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 455);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "label3";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(12, 352);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(181, 79);
            listBox2.TabIndex = 6;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1118, 620);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 7;
            label4.Text = "label4";
            // 
            // button2
            // 
            button2.Location = new Point(20, 514);
            button2.Name = "button2";
            button2.Size = new Size(150, 56);
            button2.TabIndex = 8;
            button2.Text = "Entrar na Partida";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(989, 575);
            button1.Name = "button1";
            button1.Size = new Size(117, 56);
            button1.TabIndex = 9;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(20, 452);
            button3.Name = "button3";
            button3.Size = new Size(150, 56);
            button3.TabIndex = 10;
            button3.Text = "Criar Partida";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(20, 576);
            button4.Name = "button4";
            button4.Size = new Size(150, 59);
            button4.TabIndex = 11;
            button4.Text = "Iniciar Partida";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(386, 491);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 12;
            label5.Text = "label5";
            // 
            // lblCartas
            // 
            lblCartas.AutoSize = true;
            lblCartas.Location = new Point(214, 605);
            lblCartas.Name = "lblCartas";
            lblCartas.Size = new Size(38, 15);
            lblCartas.TabIndex = 13;
            lblCartas.Text = "label6";
            // 
            // button5
            // 
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 0;
            // 
            // txtRequestSala
            // 
            txtRequestSala.Location = new Point(31, 60);
            txtRequestSala.Name = "txtRequestSala";
            txtRequestSala.Size = new Size(100, 23);
            txtRequestSala.TabIndex = 14;
            txtRequestSala.TextChanged += textBox2_TextChanged;
            // 
            // lblPedirSala
            // 
            lblPedirSala.AutoSize = true;
            lblPedirSala.Location = new Point(31, 42);
            lblPedirSala.Name = "lblPedirSala";
            lblPedirSala.Size = new Size(70, 15);
            lblPedirSala.TabIndex = 15;
            lblPedirSala.Text = "Dgite a sala:";
            lblPedirSala.Click += label7_Click_1;
            // 
            // lblPedirSenha
            // 
            lblPedirSenha.AutoSize = true;
            lblPedirSenha.Location = new Point(165, 42);
            lblPedirSenha.Name = "lblPedirSenha";
            lblPedirSenha.Size = new Size(84, 15);
            lblPedirSenha.TabIndex = 17;
            lblPedirSenha.Text = "Digite a senha:";
            // 
            // txtRequestSenha
            // 
            txtRequestSenha.Location = new Point(165, 60);
            txtRequestSenha.Name = "txtRequestSenha";
            txtRequestSenha.Size = new Size(100, 23);
            txtRequestSenha.TabIndex = 16;
            // 
            // lblPedirGrupo
            // 
            lblPedirGrupo.AutoSize = true;
            lblPedirGrupo.Location = new Point(306, 42);
            lblPedirGrupo.Name = "lblPedirGrupo";
            lblPedirGrupo.Size = new Size(86, 15);
            lblPedirGrupo.TabIndex = 19;
            lblPedirGrupo.Text = "Digite o grupo:";
            lblPedirGrupo.Click += lblGrupo_Click;
            // 
            // txtRequestGrupo
            // 
            txtRequestGrupo.Location = new Point(306, 60);
            txtRequestGrupo.Name = "txtRequestGrupo";
            txtRequestGrupo.Size = new Size(100, 23);
            txtRequestGrupo.TabIndex = 18;
            // 
            // lblPedirNome
            // 
            lblPedirNome.AutoSize = true;
            lblPedirNome.Location = new Point(438, 42);
            lblPedirNome.Name = "lblPedirNome";
            lblPedirNome.Size = new Size(85, 15);
            lblPedirNome.TabIndex = 21;
            lblPedirNome.Text = "Digite o nome:";
            lblPedirNome.Click += lblPedirNome_Click_1;
            // 
            // txtRequestNome
            // 
            txtRequestNome.Location = new Point(438, 60);
            txtRequestNome.Name = "txtRequestNome";
            txtRequestNome.Size = new Size(100, 23);
            txtRequestNome.TabIndex = 20;
            // 
            // lblPedirId
            // 
            lblPedirId.AutoSize = true;
            lblPedirId.Location = new Point(572, 42);
            lblPedirId.Name = "lblPedirId";
            lblPedirId.Size = new Size(105, 15);
            lblPedirId.TabIndex = 23;
            lblPedirId.Text = "Digite o ID da Sala:";
            // 
            // txtRequestId
            // 
            txtRequestId.Location = new Point(572, 60);
            txtRequestId.Name = "txtRequestId";
            txtRequestId.Size = new Size(100, 23);
            txtRequestId.TabIndex = 22;
            // 
            // lblSenhaId
            // 
            lblSenhaId.AutoSize = true;
            lblSenhaId.Location = new Point(386, 519);
            lblSenhaId.Name = "lblSenhaId";
            lblSenhaId.Size = new Size(38, 15);
            lblSenhaId.TabIndex = 24;
            lblSenhaId.Text = "label6";
            // 
            // button6
            // 
            button6.Location = new Point(273, 594);
            button6.Name = "button6";
            button6.Size = new Size(102, 37);
            button6.TabIndex = 27;
            button6.Text = "Ver Carta";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click_1;
            // 
            // txtRequestIdJogador
            // 
            txtRequestIdJogador.Location = new Point(18, 123);
            txtRequestIdJogador.Name = "txtRequestIdJogador";
            txtRequestIdJogador.Size = new Size(127, 23);
            txtRequestIdJogador.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 99);
            label6.Name = "label6";
            label6.Size = new Size(127, 15);
            label6.TabIndex = 29;
            label6.Text = "Digite o ID do Jogador:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(168, 99);
            label7.Name = "label7";
            label7.Size = new Size(146, 15);
            label7.TabIndex = 30;
            label7.Text = "Digite a senha do Jogador:";
            // 
            // txtRequestSenhaJogador
            // 
            txtRequestSenhaJogador.Location = new Point(178, 123);
            txtRequestSenhaJogador.Name = "txtRequestSenhaJogador";
            txtRequestSenhaJogador.Size = new Size(127, 23);
            txtRequestSenhaJogador.TabIndex = 31;
            // 
            // btnVerificarVez
            // 
            btnVerificarVez.Location = new Point(214, 348);
            btnVerificarVez.Name = "btnVerificarVez";
            btnVerificarVez.Size = new Size(90, 31);
            btnVerificarVez.TabIndex = 33;
            btnVerificarVez.Text = "VerificarVez";
            btnVerificarVez.UseVisualStyleBackColor = true;
            btnVerificarVez.Click += btnVerificarVez_Click;
            // 
            // lstSetores
            // 
            lstSetores.FormattingEnabled = true;
            lstSetores.ItemHeight = 15;
            lstSetores.Location = new Point(986, 356);
            lstSetores.Name = "lstSetores";
            lstSetores.Size = new Size(120, 94);
            lstSetores.TabIndex = 34;
            lstSetores.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // lstPersonagens
            // 
            lstPersonagens.FormattingEnabled = true;
            lstPersonagens.ItemHeight = 15;
            lstPersonagens.Location = new Point(989, 475);
            lstPersonagens.Name = "lstPersonagens";
            lstPersonagens.Size = new Size(120, 94);
            lstPersonagens.TabIndex = 35;
            lstPersonagens.SelectedIndexChanged += listBox4_SelectedIndexChanged;
            // 
            // lblSetores
            // 
            lblSetores.AutoSize = true;
            lblSetores.Location = new Point(986, 338);
            lblSetores.Name = "lblSetores";
            lblSetores.Size = new Size(48, 15);
            lblSetores.TabIndex = 36;
            lblSetores.Text = "Setores:";
            // 
            // lblPersonagens
            // 
            lblPersonagens.AutoSize = true;
            lblPersonagens.Location = new Point(986, 457);
            lblPersonagens.Name = "lblPersonagens";
            lblPersonagens.Size = new Size(77, 15);
            lblPersonagens.TabIndex = 37;
            lblPersonagens.Text = "Personagens:";
            // 
            // lblRequestSetores
            // 
            lblRequestSetores.AutoSize = true;
            lblRequestSetores.Location = new Point(866, 403);
            lblRequestSetores.Name = "lblRequestSetores";
            lblRequestSetores.Size = new Size(88, 15);
            lblRequestSetores.TabIndex = 38;
            lblRequestSetores.Text = "adicionar setor:";
            // 
            // lblRequestPersonagem
            // 
            lblRequestPersonagem.AutoSize = true;
            lblRequestPersonagem.Location = new Point(855, 457);
            lblRequestPersonagem.Name = "lblRequestPersonagem";
            lblRequestPersonagem.Size = new Size(128, 15);
            lblRequestPersonagem.TabIndex = 39;
            lblRequestPersonagem.Text = "adicionar personagem:";
            // 
            // txtRequestSetor
            // 
            txtRequestSetor.Location = new Point(876, 421);
            txtRequestSetor.Name = "txtRequestSetor";
            txtRequestSetor.Size = new Size(76, 23);
            txtRequestSetor.TabIndex = 40;
            // 
            // txtRequestPersonagem
            // 
            txtRequestPersonagem.Location = new Point(876, 475);
            txtRequestPersonagem.Name = "txtRequestPersonagem";
            txtRequestPersonagem.Size = new Size(75, 23);
            txtRequestPersonagem.TabIndex = 41;
            // 
            // btnColocarPersonagem
            // 
            btnColocarPersonagem.Location = new Point(866, 504);
            btnColocarPersonagem.Name = "btnColocarPersonagem";
            btnColocarPersonagem.Size = new Size(102, 47);
            btnColocarPersonagem.TabIndex = 42;
            btnColocarPersonagem.Text = "Adicionar Personagem";
            btnColocarPersonagem.UseVisualStyleBackColor = true;
            btnColocarPersonagem.Click += btnColocarPersonagem_Click;
            // 
            // txtTabuleiro
            // 
            txtTabuleiro.Location = new Point(214, 385);
            txtTabuleiro.Multiline = true;
            txtTabuleiro.Name = "txtTabuleiro";
            txtTabuleiro.Size = new Size(161, 176);
            txtTabuleiro.TabIndex = 43;
            txtTabuleiro.TextChanged += txtTabuleiro_TextChanged;
            // 
            // lblIdJogadorVez
            // 
            lblIdJogadorVez.AutoSize = true;
            lblIdJogadorVez.Location = new Point(325, 330);
            lblIdJogadorVez.Name = "lblIdJogadorVez";
            lblIdJogadorVez.Size = new Size(38, 15);
            lblIdJogadorVez.TabIndex = 44;
            lblIdJogadorVez.Text = "label8";
            // 
            // lblNomeJogadorVez
            // 
            lblNomeJogadorVez.AutoSize = true;
            lblNomeJogadorVez.Location = new Point(325, 356);
            lblNomeJogadorVez.Name = "lblNomeJogadorVez";
            lblNomeJogadorVez.Size = new Size(38, 15);
            lblNomeJogadorVez.TabIndex = 45;
            lblNomeJogadorVez.Text = "label9";
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Andar0;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(471, 563);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 73);
            panel1.TabIndex = 46;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.andar1;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(470, 491);
            panel2.Name = "panel2";
            panel2.Size = new Size(371, 73);
            panel2.TabIndex = 47;
            // 
            // panel3
            // 
            panel3.BackgroundImage = Properties.Resources.andar2;
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(470, 415);
            panel3.Name = "panel3";
            panel3.Size = new Size(371, 79);
            panel3.TabIndex = 47;
            // 
            // panel4
            // 
            panel4.BackgroundImage = Properties.Resources.andar_3;
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(470, 345);
            panel4.Name = "panel4";
            panel4.Size = new Size(371, 73);
            panel4.TabIndex = 47;
            // 
            // panel5
            // 
            panel5.BackgroundImage = Properties.Resources.andar4;
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(470, 272);
            panel5.Name = "panel5";
            panel5.Size = new Size(371, 73);
            panel5.TabIndex = 47;
            // 
            // panel6
            // 
            panel6.BackgroundImage = Properties.Resources.andar5;
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(470, 203);
            panel6.Name = "panel6";
            panel6.Size = new Size(371, 73);
            panel6.TabIndex = 47;
            // 
            // panel7
            // 
            panel7.BackgroundImage = Properties.Resources.andar10;
            panel7.BackgroundImageLayout = ImageLayout.Stretch;
            panel7.Location = new Point(572, 112);
            panel7.Name = "panel7";
            panel7.Size = new Size(158, 92);
            panel7.TabIndex = 47;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1168, 644);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblNomeJogadorVez);
            Controls.Add(lblIdJogadorVez);
            Controls.Add(txtTabuleiro);
            Controls.Add(btnColocarPersonagem);
            Controls.Add(txtRequestPersonagem);
            Controls.Add(txtRequestSetor);
            Controls.Add(lblRequestPersonagem);
            Controls.Add(lblRequestSetores);
            Controls.Add(lblPersonagens);
            Controls.Add(lblSetores);
            Controls.Add(lstPersonagens);
            Controls.Add(lstSetores);
            Controls.Add(btnVerificarVez);
            Controls.Add(txtRequestSenhaJogador);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtRequestIdJogador);
            Controls.Add(button6);
            Controls.Add(lblSenhaId);
            Controls.Add(lblPedirId);
            Controls.Add(txtRequestId);
            Controls.Add(lblPedirNome);
            Controls.Add(txtRequestNome);
            Controls.Add(lblPedirGrupo);
            Controls.Add(txtRequestGrupo);
            Controls.Add(lblPedirSenha);
            Controls.Add(txtRequestSenha);
            Controls.Add(lblPedirSala);
            Controls.Add(txtRequestSala);
            Controls.Add(button5);
            Controls.Add(lblCartas);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox2;
        private Label label4;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Label label5;
        private Label lblCartas;
        private Button button5;
        private TextBox txtRequestSala;
        private Label lblPedirSala;
        private Label lblPedirSenha;
        private TextBox txtRequestSenha;
        private Label lblPedirGrupo;
        private TextBox txtRequestGrupo;
        private Label lblPedirNome;
        private TextBox txtRequestNome;
        private Label lblPedirId;
        private TextBox txtRequestId;
        private Label lblSenhaId;
        private Button button6;
        private TextBox txtRequestIdJogador;
        private Label label6;
        private Label label7;
        private TextBox txtRequestSenhaJogador;
        private Button btnVerificarVez;
        private ListBox lstSetores;
        private ListBox lstPersonagens;
        private Label lblSetores;
        private Label lblPersonagens;
        private Label lblRequestSetores;
        private Label lblRequestPersonagem;
        private TextBox txtRequestSetor;
        private TextBox txtRequestPersonagem;
        private Button btnColocarPersonagem;
        private TextBox txtTabuleiro;
        private Label lblIdJogadorVez;
        private Label lblNomeJogadorVez;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
    }
}
