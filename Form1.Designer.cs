namespace UsosListas
{
    partial class frmInicio
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
            this.grbLista = new System.Windows.Forms.GroupBox();
            this.lsbContatos = new System.Windows.Forms.ListBox();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.txbEndereço = new System.Windows.Forms.TextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.btnNovoTelefone = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblEndereçoDigitado = new System.Windows.Forms.Label();
            this.lblNomeDigitado = new System.Windows.Forms.Label();
            this.lblEndereço2 = new System.Windows.Forms.Label();
            this.lblNome2 = new System.Windows.Forms.Label();
            this.lsbTelefones = new System.Windows.Forms.ListBox();
            this.grbLista.SuspendLayout();
            this.grbCadastrar.SuspendLayout();
            this.grbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbLista
            // 
            this.grbLista.BackColor = System.Drawing.Color.Gold;
            this.grbLista.Controls.Add(this.lsbContatos);
            this.grbLista.Location = new System.Drawing.Point(471, 12);
            this.grbLista.Name = "grbLista";
            this.grbLista.Size = new System.Drawing.Size(424, 535);
            this.grbLista.TabIndex = 0;
            this.grbLista.TabStop = false;
            this.grbLista.Text = "Lista de contatos";
            // 
            // lsbContatos
            // 
            this.lsbContatos.FormattingEnabled = true;
            this.lsbContatos.ItemHeight = 20;
            this.lsbContatos.Location = new System.Drawing.Point(6, 25);
            this.lsbContatos.Name = "lsbContatos";
            this.lsbContatos.Size = new System.Drawing.Size(415, 504);
            this.lsbContatos.TabIndex = 0;
            this.lsbContatos.SelectedIndexChanged += new System.EventHandler(this.lsbContatos_SelectedIndexChanged);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.BackColor = System.Drawing.Color.Gold;
            this.grbCadastrar.Controls.Add(this.btnSalvar);
            this.grbCadastrar.Controls.Add(this.btnLimpar);
            this.grbCadastrar.Controls.Add(this.lblEndereço);
            this.grbCadastrar.Controls.Add(this.txbEndereço);
            this.grbCadastrar.Controls.Add(this.txbNome);
            this.grbCadastrar.Controls.Add(this.lblNome);
            this.grbCadastrar.Location = new System.Drawing.Point(55, 12);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(410, 222);
            this.grbCadastrar.TabIndex = 1;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastrar Pessoa";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(146, 166);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 39);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(255, 166);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 39);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // lblEndereço
            // 
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.Location = new System.Drawing.Point(25, 85);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(78, 20);
            this.lblEndereço.TabIndex = 3;
            this.lblEndereço.Text = "Endereço";
            // 
            // txbEndereço
            // 
            this.txbEndereço.Location = new System.Drawing.Point(29, 108);
            this.txbEndereço.Name = "txbEndereço";
            this.txbEndereço.Size = new System.Drawing.Size(301, 26);
            this.txbEndereço.TabIndex = 2;
            this.txbEndereço.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbEndereço_KeyPress);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(29, 56);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(301, 26);
            this.txbNome.TabIndex = 1;
            this.txbNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNome_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(25, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // grbDados
            // 
            this.grbDados.BackColor = System.Drawing.Color.Gold;
            this.grbDados.Controls.Add(this.btnNovoTelefone);
            this.grbDados.Controls.Add(this.btnApagar);
            this.grbDados.Controls.Add(this.btnEditar);
            this.grbDados.Controls.Add(this.lblEndereçoDigitado);
            this.grbDados.Controls.Add(this.lblNomeDigitado);
            this.grbDados.Controls.Add(this.lblEndereço2);
            this.grbDados.Controls.Add(this.lblNome2);
            this.grbDados.Controls.Add(this.lsbTelefones);
            this.grbDados.Location = new System.Drawing.Point(55, 240);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(410, 307);
            this.grbDados.TabIndex = 1;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados da Pessoa";
            // 
            // btnNovoTelefone
            // 
            this.btnNovoTelefone.BackColor = System.Drawing.Color.Khaki;
            this.btnNovoTelefone.Location = new System.Drawing.Point(13, 267);
            this.btnNovoTelefone.Name = "btnNovoTelefone";
            this.btnNovoTelefone.Size = new System.Drawing.Size(125, 34);
            this.btnNovoTelefone.TabIndex = 8;
            this.btnNovoTelefone.Text = "Novo Telefone";
            this.btnNovoTelefone.UseVisualStyleBackColor = false;
            this.btnNovoTelefone.Visible = false;
            this.btnNovoTelefone.Click += new System.EventHandler(this.btnNovoTelefone_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.Red;
            this.btnApagar.Location = new System.Drawing.Point(248, 261);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 40);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Visible = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditar.Location = new System.Drawing.Point(329, 261);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 40);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Visible = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblEndereçoDigitado
            // 
            this.lblEndereçoDigitado.AutoSize = true;
            this.lblEndereçoDigitado.Location = new System.Drawing.Point(87, 64);
            this.lblEndereçoDigitado.Name = "lblEndereçoDigitado";
            this.lblEndereçoDigitado.Size = new System.Drawing.Size(51, 20);
            this.lblEndereçoDigitado.TabIndex = 5;
            this.lblEndereçoDigitado.Text = "label2";
            this.lblEndereçoDigitado.Visible = false;
            // 
            // lblNomeDigitado
            // 
            this.lblNomeDigitado.AutoSize = true;
            this.lblNomeDigitado.Location = new System.Drawing.Point(67, 35);
            this.lblNomeDigitado.Name = "lblNomeDigitado";
            this.lblNomeDigitado.Size = new System.Drawing.Size(51, 20);
            this.lblNomeDigitado.TabIndex = 4;
            this.lblNomeDigitado.Text = "label1";
            this.lblNomeDigitado.Visible = false;
            // 
            // lblEndereço2
            // 
            this.lblEndereço2.AutoSize = true;
            this.lblEndereço2.Location = new System.Drawing.Point(6, 64);
            this.lblEndereço2.Name = "lblEndereço2";
            this.lblEndereço2.Size = new System.Drawing.Size(82, 20);
            this.lblEndereço2.TabIndex = 3;
            this.lblEndereço2.Text = "Endereço:";
            // 
            // lblNome2
            // 
            this.lblNome2.AutoSize = true;
            this.lblNome2.Location = new System.Drawing.Point(6, 35);
            this.lblNome2.Name = "lblNome2";
            this.lblNome2.Size = new System.Drawing.Size(55, 20);
            this.lblNome2.TabIndex = 2;
            this.lblNome2.Text = "Nome:";
            // 
            // lsbTelefones
            // 
            this.lsbTelefones.FormattingEnabled = true;
            this.lsbTelefones.ItemHeight = 20;
            this.lsbTelefones.Location = new System.Drawing.Point(0, 97);
            this.lsbTelefones.Name = "lsbTelefones";
            this.lsbTelefones.Size = new System.Drawing.Size(409, 164);
            this.lsbTelefones.TabIndex = 1;
            this.lsbTelefones.Visible = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(950, 598);
            this.Controls.Add(this.grbDados);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.grbLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmInicio";
            this.Text = "Aprenda InovTec";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInicio_FormClosing);
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.grbLista.ResumeLayout(false);
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbLista;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.TextBox txbEndereço;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.ListBox lsbContatos;
        private System.Windows.Forms.Label lblEndereço2;
        private System.Windows.Forms.Label lblNome2;
        private System.Windows.Forms.ListBox lsbTelefones;
        private System.Windows.Forms.Button btnNovoTelefone;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblEndereçoDigitado;
        private System.Windows.Forms.Label lblNomeDigitado;
    }
}

