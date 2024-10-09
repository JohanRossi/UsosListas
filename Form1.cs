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
    public partial class frmInicio : Form
    {
        private List<Pessoa> listaPessoas = new List<Pessoa>();
        private Pessoa pessoaSelecionada;
        public frmInicio()
        {
            InitializeComponent();
        }
        private void AtualizarListaTelefones() {
            lsbTelefones.Items.Clear();
            lsbTelefones.Items.AddRange(pessoaSelecionada.Telefones.ToArray());
        }
        private void SalvarContato()
        {
            if (txbNome.Text.Length == 0 )
            {
                MessageBox.Show("Nome é obrigatorio", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (txbEndereço.Text.Length == 0 )
            {
                MessageBox.Show("Endereço é obrigatorio", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Pessoa pessoa = new Pessoa(txbNome.Text);
            pessoa.Endereco = txbEndereço.Text;

            listaPessoas.Add(pessoa);
            MessageBox.Show($"Contato {pessoa.Nome} salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparCadastroContato();
            AtualizaListaContatos();    
        }

        private void LimparCadastroContato()
        {
            txbNome.Clear();
            txbEndereço.Clear();

            txbNome.Focus();
        }
        private void AtualizaListaContatos()
        {
            lsbContatos.Items.Clear();
            lsbContatos.Items.AddRange(listaPessoas.ToArray());
        }

        private void lsbContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbContatos.SelectedItem != null)
            {
                pessoaSelecionada = (Pessoa)lsbContatos.SelectedItem;
                

                lblNomeDigitado.Text = pessoaSelecionada.Nome;
                lblEndereçoDigitado.Text = pessoaSelecionada.Endereco;
                AtualizarListaTelefones();

                MostraOcultaDetalhesContato(true);
            }
            else
            {
                MostraOcultaDetalhesContato(false);
            }

        }
        private void MostraOcultaDetalhesContato(bool visivel)
        {
            lsbTelefones.Visible = visivel;
            btnEditar.Visible = visivel;
            btnApagar.Visible = visivel;
            btnNovoTelefone.Visible = visivel;
            lblNome2.Visible = visivel;
            lblEndereço2.Visible = visivel;
            lblNomeDigitado.Visible = visivel;
            lblEndereçoDigitado.Visible = visivel;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarContato();
        }
        private void txbNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SalvarContato();
            }
        }

        private void txbEndereço_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SalvarContato();
            }
        }

        private void btnNovoTelefone_Click(object sender, EventArgs e)
        {
            frmNovoTelefone novoTelefone = new frmNovoTelefone();
            DialogResult resposta = novoTelefone.ShowDialog();
            
            if (resposta == DialogResult.OK)
            {
                pessoaSelecionada.AdicionarTelefone(novoTelefone.Ddd, novoTelefone.Numero, novoTelefone.Tipo);
                AtualizaListaContatos();
            }
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            listaPessoas = Arquivosjson.ImportarPessoasJson();
            AtualizaListaContatos();
        }

        private void frmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Arquivosjson.ExportarPessoasParaJson(listaPessoas);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditaPessoa editaPessoa = new frmEditaPessoa(pessoaSelecionada.Nome, pessoaSelecionada.Endereco);
            DialogResult resposta = editaPessoa.ShowDialog();

            if (resposta == DialogResult.OK)
            {

                pessoaSelecionada.Nome = editaPessoa.Nome;
                pessoaSelecionada.Endereco = editaPessoa.Endereco;

                AtualizaListaContatos();
                lblNome.Text = pessoaSelecionada.Nome;
                lblEndereço.Text = pessoaSelecionada.Endereco;
                
            }
        }
    }
}
