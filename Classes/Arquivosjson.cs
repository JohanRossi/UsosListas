using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsosListas.Classes
{
    internal class Arquivosjson
    {
        private static string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pessoas.json");
        public static void ExportarPessoasParaJson(List<Pessoa> listapessoas) 
        {
            string caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "pessoas.json");

            if (File.Exists(caminhoArquivo))
            {
                File.WriteAllText(caminhoArquivo, string.Empty);
            }
            else
            {
                using (FileStream fileStream = File.Create(caminhoArquivo)) 
                {
                    fileStream.Close();
                }
            }
            
            string dadosJson = JsonConvert.SerializeObject(listapessoas, Formatting.Indented);
            File.WriteAllText(caminhoArquivo, dadosJson);
        }
        public static List<Pessoa> ImportarPessoasJson()
        {
            if (File.Exists(caminhoArquivo))
            {
                string dadosJson = File.ReadAllText(caminhoArquivo);

                List<Pessoa> listaPessoas = JsonConvert.DeserializeObject<List<Pessoa>>(dadosJson);

                return listaPessoas;
            }
            else
            {
                return new List<Pessoa>();
            }
        }
    }
}
