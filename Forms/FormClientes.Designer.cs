﻿namespace P2
{
    partial class FormClientes
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
            dataClientes = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnCadastrar = new Button();
            btnBuscar = new Button();
            txtNome = new TextBox();
            txtLogradouro = new TextBox();
            txtEmail = new TextBox();
            txtCidade = new TextBox();
            txtEstado = new TextBox();
            txtBairro = new TextBox();
            txtNumero = new TextBox();
            mskCpf = new MaskedTextBox();
            mskTelefone = new MaskedTextBox();
            mskWhatsapp = new MaskedTextBox();
            mskCep = new MaskedTextBox();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataClientes).BeginInit();
            SuspendLayout();
            // 
            // dataClientes
            // 
            dataClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataClientes.Location = new Point(562, 12);
            dataClientes.Name = "dataClientes";
            dataClientes.RowHeadersWidth = 51;
            dataClientes.Size = new Size(585, 567);
            dataClientes.TabIndex = 0;
            dataClientes.CellClick += dataClientes_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(14, 11);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(14, 131);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Telefone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(14, 299);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 3;
            label3.Text = "Número";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(14, 381);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 4;
            label4.Text = "Estado";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.Location = new Point(14, 86);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.Location = new Point(14, 341);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 6;
            label6.Text = "Cidade";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F);
            label7.Location = new Point(184, 302);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 7;
            label7.Text = "Bairro";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F);
            label8.Location = new Point(14, 51);
            label8.Name = "label8";
            label8.Size = new Size(33, 20);
            label8.TabIndex = 8;
            label8.Text = "CPF";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F);
            label9.Location = new Point(14, 222);
            label9.Name = "label9";
            label9.Size = new Size(34, 20);
            label9.TabIndex = 9;
            label9.Text = "CEP";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F);
            label10.Location = new Point(14, 169);
            label10.Name = "label10";
            label10.Size = new Size(78, 20);
            label10.TabIndex = 10;
            label10.Text = "WhatsApp";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F);
            label11.Location = new Point(14, 258);
            label11.Name = "label11";
            label11.Size = new Size(87, 20);
            label11.TabIndex = 11;
            label11.Text = "Logradouro";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(14, 415);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(149, 43);
            btnCadastrar.TabIndex = 12;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += button1_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(263, 222);
            btnBuscar.Margin = new Padding(3, 4, 3, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(119, 32);
            btnBuscar.TabIndex = 13;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(73, 11);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(308, 27);
            txtNome.TabIndex = 14;
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(131, 258);
            txtLogradouro.Margin = new Padding(3, 4, 3, 4);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(250, 27);
            txtLogradouro.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(64, 90);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(318, 27);
            txtEmail.TabIndex = 18;
            // 
            // txtCidade
            // 
            txtCidade.Location = new Point(89, 342);
            txtCidade.Margin = new Padding(3, 4, 3, 4);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(292, 27);
            txtCidade.TabIndex = 19;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(88, 382);
            txtEstado.Margin = new Padding(3, 4, 3, 4);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(293, 27);
            txtEstado.TabIndex = 20;
            // 
            // txtBairro
            // 
            txtBairro.Location = new Point(244, 302);
            txtBairro.Margin = new Padding(3, 4, 3, 4);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(137, 27);
            txtBairro.TabIndex = 21;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(89, 301);
            txtNumero.Margin = new Padding(3, 4, 3, 4);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(96, 27);
            txtNumero.TabIndex = 25;
            // 
            // mskCpf
            // 
            mskCpf.Location = new Point(49, 51);
            mskCpf.Margin = new Padding(3, 4, 3, 4);
            mskCpf.Mask = "000,000,000-00";
            mskCpf.Name = "mskCpf";
            mskCpf.Size = new Size(332, 27);
            mskCpf.TabIndex = 26;
            // 
            // mskTelefone
            // 
            mskTelefone.Location = new Point(89, 131);
            mskTelefone.Margin = new Padding(3, 4, 3, 4);
            mskTelefone.Mask = "00 0000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(292, 27);
            mskTelefone.TabIndex = 27;
            // 
            // mskWhatsapp
            // 
            mskWhatsapp.Location = new Point(113, 170);
            mskWhatsapp.Margin = new Padding(3, 4, 3, 4);
            mskWhatsapp.Mask = "00 00000-0000";
            mskWhatsapp.Name = "mskWhatsapp";
            mskWhatsapp.Size = new Size(268, 27);
            mskWhatsapp.TabIndex = 28;
            // 
            // mskCep
            // 
            mskCep.Location = new Point(64, 223);
            mskCep.Margin = new Padding(3, 4, 3, 4);
            mskCep.Mask = "00000-000";
            mskCep.Name = "mskCep";
            mskCep.Size = new Size(194, 27);
            mskCep.TabIndex = 29;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(562, 585);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(109, 36);
            btnExcluir.TabIndex = 30;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Location = new Point(169, 416);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(149, 43);
            btnAtualizar.TabIndex = 31;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1159, 633);
            Controls.Add(btnAtualizar);
            Controls.Add(btnExcluir);
            Controls.Add(mskCep);
            Controls.Add(mskWhatsapp);
            Controls.Add(mskTelefone);
            Controls.Add(mskCpf);
            Controls.Add(txtNumero);
            Controls.Add(txtBairro);
            Controls.Add(txtEstado);
            Controls.Add(txtCidade);
            Controls.Add(txtEmail);
            Controls.Add(txtLogradouro);
            Controls.Add(txtNome);
            Controls.Add(btnBuscar);
            Controls.Add(btnCadastrar);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataClientes);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormClientes";
            Text = "FormClientes";
            Load += FormClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dataClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataClientes;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnCadastrar;
        private Button btnBuscar;
        private TextBox txtNome;
        private TextBox txtLogradouro;
        private TextBox txtEmail;
        private TextBox txtCidade;
        private TextBox txtEstado;
        private TextBox txtBairro;
        private TextBox txtNumero;
        private MaskedTextBox mskCpf;
        private MaskedTextBox mskTelefone;
        private MaskedTextBox mskWhatsapp;
        private MaskedTextBox mskCep;
        private Button btnExcluir;
        private Button btnAtualizar;
    }
}