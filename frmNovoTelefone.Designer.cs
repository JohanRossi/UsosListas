namespace UsosListas
{
    partial class frmNovoTelefone
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbDdd = new System.Windows.Forms.TextBox();
            this.txbNumero2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelarNumero = new System.Windows.Forms.Button();
            this.btnSalvarNumero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "DDD";
            // 
            // txbDdd
            // 
            this.txbDdd.Location = new System.Drawing.Point(14, 125);
            this.txbDdd.MaxLength = 3;
            this.txbDdd.Name = "txbDdd";
            this.txbDdd.Size = new System.Drawing.Size(80, 26);
            this.txbDdd.TabIndex = 1;
            // 
            // txbNumero2
            // 
            this.txbNumero2.Location = new System.Drawing.Point(122, 125);
            this.txbNumero2.MaxLength = 9;
            this.txbNumero2.Name = "txbNumero2";
            this.txbNumero2.Size = new System.Drawing.Size(233, 26);
            this.txbNumero2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tipo";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Fax",
            "Celular",
            "Empresa",
            "Fixo",
            "WhatsZapp"});
            this.cmbTipo.Location = new System.Drawing.Point(14, 216);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(341, 28);
            this.cmbTipo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Novo Telefone";
            // 
            // btnCancelarNumero
            // 
            this.btnCancelarNumero.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarNumero.Location = new System.Drawing.Point(259, 296);
            this.btnCancelarNumero.Name = "btnCancelarNumero";
            this.btnCancelarNumero.Size = new System.Drawing.Size(96, 37);
            this.btnCancelarNumero.TabIndex = 7;
            this.btnCancelarNumero.Text = "Cancelar";
            this.btnCancelarNumero.UseVisualStyleBackColor = true;
            // 
            // btnSalvarNumero
            // 
            this.btnSalvarNumero.Location = new System.Drawing.Point(14, 296);
            this.btnSalvarNumero.Name = "btnSalvarNumero";
            this.btnSalvarNumero.Size = new System.Drawing.Size(95, 37);
            this.btnSalvarNumero.TabIndex = 8;
            this.btnSalvarNumero.Text = "Salvar";
            this.btnSalvarNumero.UseVisualStyleBackColor = true;
            this.btnSalvarNumero.Click += new System.EventHandler(this.btnSalvarNumero_Click);
            // 
            // frmNovoTelefone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(374, 350);
            this.Controls.Add(this.btnSalvarNumero);
            this.Controls.Add(this.btnCancelarNumero);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbNumero2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbDdd);
            this.Controls.Add(this.label1);
            this.Name = "frmNovoTelefone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Adicionar Telefone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDdd;
        private System.Windows.Forms.TextBox txbNumero2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelarNumero;
        private System.Windows.Forms.Button btnSalvarNumero;
    }
}