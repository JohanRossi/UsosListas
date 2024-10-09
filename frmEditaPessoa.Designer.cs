namespace UsosListas
{
    partial class frmEditaPessoa
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
            this.lblEditarEndereço = new System.Windows.Forms.Label();
            this.txtNomeEditar = new System.Windows.Forms.TextBox();
            this.txtEndereçoEditar = new System.Windows.Forms.TextBox();
            this.lblNomeEditar = new System.Windows.Forms.Label();
            this.btnSalvarEdit = new System.Windows.Forms.Button();
            this.btnEditarCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEditarEndereço
            // 
            this.lblEditarEndereço.AutoSize = true;
            this.lblEditarEndereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditarEndereço.Location = new System.Drawing.Point(32, 199);
            this.lblEditarEndereço.Name = "lblEditarEndereço";
            this.lblEditarEndereço.Size = new System.Drawing.Size(96, 25);
            this.lblEditarEndereço.TabIndex = 1;
            this.lblEditarEndereço.Text = "Endereço";
            // 
            // txtNomeEditar
            // 
            this.txtNomeEditar.Location = new System.Drawing.Point(37, 133);
            this.txtNomeEditar.Name = "txtNomeEditar";
            this.txtNomeEditar.Size = new System.Drawing.Size(364, 26);
            this.txtNomeEditar.TabIndex = 2;
            // 
            // txtEndereçoEditar
            // 
            this.txtEndereçoEditar.Location = new System.Drawing.Point(37, 241);
            this.txtEndereçoEditar.Name = "txtEndereçoEditar";
            this.txtEndereçoEditar.Size = new System.Drawing.Size(364, 26);
            this.txtEndereçoEditar.TabIndex = 3;
            // 
            // lblNomeEditar
            // 
            this.lblNomeEditar.AutoSize = true;
            this.lblNomeEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEditar.Location = new System.Drawing.Point(32, 90);
            this.lblNomeEditar.Name = "lblNomeEditar";
            this.lblNomeEditar.Size = new System.Drawing.Size(64, 25);
            this.lblNomeEditar.TabIndex = 4;
            this.lblNomeEditar.Text = "Nome";
            // 
            // btnSalvarEdit
            // 
            this.btnSalvarEdit.Location = new System.Drawing.Point(75, 355);
            this.btnSalvarEdit.Name = "btnSalvarEdit";
            this.btnSalvarEdit.Size = new System.Drawing.Size(75, 48);
            this.btnSalvarEdit.TabIndex = 5;
            this.btnSalvarEdit.Text = "Salvar";
            this.btnSalvarEdit.UseVisualStyleBackColor = true;
            this.btnSalvarEdit.Click += new System.EventHandler(this.btnSalvarEdit_Click);
            // 
            // btnEditarCancelar
            // 
            this.btnEditarCancelar.Location = new System.Drawing.Point(277, 355);
            this.btnEditarCancelar.Name = "btnEditarCancelar";
            this.btnEditarCancelar.Size = new System.Drawing.Size(80, 48);
            this.btnEditarCancelar.TabIndex = 6;
            this.btnEditarCancelar.Text = "Cancelar";
            this.btnEditarCancelar.UseVisualStyleBackColor = true;
            // 
            // frmEditaPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(445, 450);
            this.Controls.Add(this.btnEditarCancelar);
            this.Controls.Add(this.btnSalvarEdit);
            this.Controls.Add(this.lblNomeEditar);
            this.Controls.Add(this.txtEndereçoEditar);
            this.Controls.Add(this.txtNomeEditar);
            this.Controls.Add(this.lblEditarEndereço);
            this.Name = "frmEditaPessoa";
            this.Text = "frmEditaPessoa";
            this.Load += new System.EventHandler(this.frmEditaPessoa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblEditarEndereço;
        private System.Windows.Forms.TextBox txtNomeEditar;
        private System.Windows.Forms.TextBox txtEndereçoEditar;
        private System.Windows.Forms.Label lblNomeEditar;
        private System.Windows.Forms.Button btnSalvarEdit;
        private System.Windows.Forms.Button btnEditarCancelar;
    }
}