using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsosListas
{
    public partial class frmNovoTelefone : Form
    {
        public string Ddd {  get; set; }
        public string Tipo {  get; set; }
        public string Numero {  get; set; }
        public frmNovoTelefone()
        {
            InitializeComponent();
        }


        private void btnSalvarNumero_Click(object sender, EventArgs e)
        {
            if (txbDdd.Text.Length < 3)
            {
                MessageBox.Show("O campo DDD é obrigatorio!");
                txbDdd.Focus();
                return;
            }
            if ((txbNumero2.Text.Length != 8) && (txbNumero2.Text.Length != 9))
            {
                MessageBox.Show("O campo Numero é obrigatorio!");
                txbNumero2.Focus();
                return;
            }

            if (cmbTipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione um tipo");
                cmbTipo.Focus();
                return;
            }
            Ddd = txbDdd.Text;
            Numero = txbNumero2.Text;
            Tipo = cmbTipo.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
