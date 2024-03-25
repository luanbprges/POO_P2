namespace Prova2
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
            RB_onibus = new RadioButton();
            RB_caminhao = new RadioButton();
            lb_placa = new Label();
            lb_ano = new Label();
            lb_assentos = new Label();
            mtb_placa = new MaskedTextBox();
            mtb_ano = new MaskedTextBox();
            mtb_assentos = new MaskedTextBox();
            B_cadastrar = new Button();
            listView1 = new ListView();
            B_limpar = new Button();
            pic_imagem = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pic_imagem).BeginInit();
            SuspendLayout();
            // 
            // RB_onibus
            // 
            RB_onibus.AutoSize = true;
            RB_onibus.Location = new Point(49, 29);
            RB_onibus.Name = "RB_onibus";
            RB_onibus.Size = new Size(76, 24);
            RB_onibus.TabIndex = 0;
            RB_onibus.TabStop = true;
            RB_onibus.Text = "Ônibus";
            RB_onibus.UseVisualStyleBackColor = true;
            RB_onibus.CheckedChanged += RB_onibus_CheckedChanged;
            // 
            // RB_caminhao
            // 
            RB_caminhao.AutoSize = true;
            RB_caminhao.Location = new Point(269, 29);
            RB_caminhao.Name = "RB_caminhao";
            RB_caminhao.Size = new Size(97, 24);
            RB_caminhao.TabIndex = 0;
            RB_caminhao.TabStop = true;
            RB_caminhao.Text = "Caminhão";
            RB_caminhao.UseVisualStyleBackColor = true;
            RB_caminhao.CheckedChanged += RB_caminhao_CheckedChanged;
            // 
            // lb_placa
            // 
            lb_placa.AutoSize = true;
            lb_placa.Location = new Point(101, 109);
            lb_placa.Name = "lb_placa";
            lb_placa.Size = new Size(44, 20);
            lb_placa.TabIndex = 1;
            lb_placa.Text = "Placa";
            // 
            // lb_ano
            // 
            lb_ano.AutoSize = true;
            lb_ano.Location = new Point(109, 159);
            lb_ano.Name = "lb_ano";
            lb_ano.Size = new Size(36, 20);
            lb_ano.TabIndex = 1;
            lb_ano.Text = "Ano";
            // 
            // lb_assentos
            // 
            lb_assentos.AutoSize = true;
            lb_assentos.Location = new Point(49, 209);
            lb_assentos.Name = "lb_assentos";
            lb_assentos.Size = new Size(96, 20);
            lb_assentos.TabIndex = 1;
            lb_assentos.Text = "Qtd Assentos";
            // 
            // mtb_placa
            // 
            mtb_placa.Location = new Point(168, 110);
            mtb_placa.Name = "mtb_placa";
            mtb_placa.Size = new Size(287, 27);
            mtb_placa.TabIndex = 2;
            // 
            // mtb_ano
            // 
            mtb_ano.Location = new Point(168, 156);
            mtb_ano.Name = "mtb_ano";
            mtb_ano.Size = new Size(287, 27);
            mtb_ano.TabIndex = 2;
            // 
            // mtb_assentos
            // 
            mtb_assentos.Location = new Point(168, 202);
            mtb_assentos.Name = "mtb_assentos";
            mtb_assentos.Size = new Size(287, 27);
            mtb_assentos.TabIndex = 2;
            // 
            // B_cadastrar
            // 
            B_cadastrar.Location = new Point(49, 299);
            B_cadastrar.Name = "B_cadastrar";
            B_cadastrar.Size = new Size(149, 38);
            B_cadastrar.TabIndex = 3;
            B_cadastrar.Text = "Cadastrar";
            B_cadastrar.UseVisualStyleBackColor = true;
            B_cadastrar.Click += B_cadastrar_Click;
            // 
            // listView1
            // 
            listView1.Location = new Point(24, 373);
            listView1.Name = "listView1";
            listView1.Size = new Size(791, 162);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // B_limpar
            // 
            B_limpar.Location = new Point(306, 299);
            B_limpar.Name = "B_limpar";
            B_limpar.Size = new Size(149, 38);
            B_limpar.TabIndex = 3;
            B_limpar.Text = "Limpar";
            B_limpar.UseVisualStyleBackColor = true;
            B_limpar.Click += B_limpar_Click;
            // 
            // pic_imagem
            // 
            pic_imagem.BackColor = SystemColors.HighlightText;
            pic_imagem.Location = new Point(512, 49);
            pic_imagem.Name = "pic_imagem";
            pic_imagem.Size = new Size(303, 236);
            pic_imagem.TabIndex = 5;
            pic_imagem.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(850, 562);
            Controls.Add(pic_imagem);
            Controls.Add(listView1);
            Controls.Add(B_limpar);
            Controls.Add(B_cadastrar);
            Controls.Add(mtb_assentos);
            Controls.Add(mtb_ano);
            Controls.Add(mtb_placa);
            Controls.Add(lb_assentos);
            Controls.Add(lb_ano);
            Controls.Add(lb_placa);
            Controls.Add(RB_caminhao);
            Controls.Add(RB_onibus);
            Name = "Form1";
            Text = "Cadastro de Veículos";
            ((System.ComponentModel.ISupportInitialize)pic_imagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton RB_onibus;
        private RadioButton RB_caminhao;
        private Label lb_placa;
        private Label lb_ano;
        private Label lb_assentos;
        private MaskedTextBox mtb_placa;
        private MaskedTextBox mtb_ano;
        private MaskedTextBox mtb_assentos;
        private Button B_cadastrar;
        private ListView listView1;
        private Button B_limpar;
        private PictureBox pic_imagem;
    }
}
