using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsosListas.Classes;

namespace UsosListas
{
    public partial class frmEditaPessoa : Form
    {
        public string Nome {  get; set; }

        public string Endereco { get; set; }

      
        public frmEditaPessoa(string nome, string endereco)
        {
            InitializeComponent();

            this. Nome = nome;
            this.Endereco = endereco;
 
        }

        private void frmEditaPessoa_Load(object sender, EventArgs e)
        {
            txtNomeEditar.Text = Nome;
            txtEndereçoEditar.Text = Endereco;

        }

        private void btnSalvarEdit_Click(object sender, EventArgs e)
        {
            if (txtNomeEditar.Text.Length == 0)
            {
                MessageBox.Show("Nome é obrigatorio", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (txtEndereçoEditar.Text.Length == 0)
            {
                MessageBox.Show("Endereço é obrigatorio", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Nome = txtNomeEditar.Text;
            Endereco = txtEndereçoEditar.Text;

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
