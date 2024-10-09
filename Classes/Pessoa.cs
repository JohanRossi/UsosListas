using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsosListas.Classes
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set;}
        public List<Telefone> Telefones { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
            Telefones = new List<Telefone>();
        }

        public Pessoa(string nome, string endereco) : this(nome)
        {
        }

        public void AdicionarTelefone(string ddd, string numero, string tipo)
        {
            try
            {
                Telefones.Add(new Telefone(ddd, numero, tipo));
            }
            catch (ArgumentException ex) {
                MessageBox.Show(ex.Message, "Erro de Tipo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public override string ToString()
        {
            return Nome;
        }
    }
}
