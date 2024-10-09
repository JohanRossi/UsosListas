using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsosListas.Classes
{
    internal class Telefone
    {
        public string Numero {  get; set; }

        public string Ddd { get; set; }

        public string Tipo { get; set; }

        private static readonly List<string> TiposPermitidos = new List<string>
            {
                "Celular",
                "Fixo",
                "Empresa",
                "Fax",
                "WhatsApp"
            };

        public Telefone(string ddd, string numero, string tipo) {

            if (!TiposPermitidos.Contains(tipo))
            {
                throw new ArgumentException($"Tipo de telefone '{tipo}' não é valido." +
                    $"Tipos permitidos: {string.Join(",", TiposPermitidos)}");
            }

            Ddd = ddd;
            Tipo = tipo;
            Numero = numero;
        }
        public override string ToString()
        {
            return $"{Tipo}: ({Ddd}) {Numero}";
        }
    }
}
