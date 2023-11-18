namespace appBanco
{
    partial class banco
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(banco));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSaldo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNomeCliente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonDepositar = new System.Windows.Forms.Button();
            this.TextBoxDepositar = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonSacar = new System.Windows.Forms.Button();
            this.TextBoxSacar = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(905, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvaToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.arquivoToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(91, 31);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.abrirToolStripMenuItem.Text = "Abrir";
            // 
            // salvaToolStripMenuItem
            // 
            this.salvaToolStripMenuItem.Name = "salvaToolStripMenuItem";
            this.salvaToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.salvaToolStripMenuItem.Text = "Salvar";
            this.salvaToolStripMenuItem.Click += new System.EventHandler(this.salvaToolStripMenuItem_Click);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(180, 32);
            this.fecharToolStripMenuItem.Text = "Fechar";
            // 
            // labelSaldo
            // 
            this.labelSaldo.AutoSize = true;
            this.labelSaldo.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSaldo.Location = new System.Drawing.Point(56, 34);
            this.labelSaldo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSaldo.Name = "labelSaldo";
            this.labelSaldo.Size = new System.Drawing.Size(67, 33);
            this.labelSaldo.TabIndex = 2;
            this.labelSaldo.Text = "0,00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNomeCliente);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(18, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(435, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nome:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelNomeCliente
            // 
            this.labelNomeCliente.AutoSize = true;
            this.labelNomeCliente.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeCliente.Location = new System.Drawing.Point(9, 34);
            this.labelNomeCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelNomeCliente.Name = "labelNomeCliente";
            this.labelNomeCliente.Size = new System.Drawing.Size(243, 30);
            this.labelNomeCliente.TabIndex = 4;
            this.labelNomeCliente.Text = "Lucas Bassora da Silva";
            this.labelNomeCliente.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.labelSaldo);
            this.groupBox2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(462, 71);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size(425, 88);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saldo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "R$";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonDepositar);
            this.groupBox3.Controls.Add(this.TextBoxDepositar);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox3.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(8, 33);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox3.Size = new System.Drawing.Size(435, 95);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Depósito:";
            // 
            // buttonDepositar
            // 
            this.buttonDepositar.BackColor = System.Drawing.Color.Beige;
            this.buttonDepositar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.buttonDepositar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDepositar.Location = new System.Drawing.Point(297, 34);
            this.buttonDepositar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonDepositar.Name = "buttonDepositar";
            this.buttonDepositar.Size = new System.Drawing.Size(129, 26);
            this.buttonDepositar.TabIndex = 1;
            this.buttonDepositar.Text = "Depositar";
            this.buttonDepositar.UseVisualStyleBackColor = false;
            this.buttonDepositar.Click += new System.EventHandler(this.buttonDepositar_Click);
            // 
            // TextBoxDepositar
            // 
            this.TextBoxDepositar.Location = new System.Drawing.Point(5, 34);
            this.TextBoxDepositar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextBoxDepositar.Name = "TextBoxDepositar";
            this.TextBoxDepositar.Size = new System.Drawing.Size(281, 26);
            this.TextBoxDepositar.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonSacar);
            this.groupBox4.Controls.Add(this.TextBoxSacar);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox4.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(449, 33);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox4.Size = new System.Drawing.Size(404, 95);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Saque:";
            // 
            // buttonSacar
            // 
            this.buttonSacar.BackColor = System.Drawing.Color.Beige;
            this.buttonSacar.FlatAppearance.BorderSize = 4;
            this.buttonSacar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSacar.Location = new System.Drawing.Point(256, 34);
            this.buttonSacar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonSacar.Name = "buttonSacar";
            this.buttonSacar.Size = new System.Drawing.Size(129, 26);
            this.buttonSacar.TabIndex = 2;
            this.buttonSacar.Text = "Sacar";
            this.buttonSacar.UseVisualStyleBackColor = false;
            this.buttonSacar.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxSacar
            // 
            this.TextBoxSacar.Location = new System.Drawing.Point(9, 34);
            this.TextBoxSacar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TextBoxSacar.Name = "TextBoxSacar";
            this.TextBoxSacar.Size = new System.Drawing.Size(237, 26);
            this.TextBoxSacar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(257, 353);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(419, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lucas Bassora da Silva - © Todos os direitos reservados";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox3);
            this.groupBox5.Controls.Add(this.groupBox4);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(18, 168);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(869, 164);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "opções";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(905, 392);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "banco";
            this.Text = "Aplicativo Banco Offline";
            this.Load += new System.EventHandler(this.banco_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.Label labelSaldo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelNomeCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonDepositar;
        private System.Windows.Forms.MaskedTextBox TextBoxDepositar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox TextBoxSacar;
        private System.Windows.Forms.Button buttonSacar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

