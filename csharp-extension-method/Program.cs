using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_extension_method
{
    class Program
    {
        static void Main(string[] args)
        {
            var listaPessoa = new List<PessoaDto>(){
                new PessoaDto() { Codigo = 1, Nome = "Claudio Roberto", EstaAtivo = true },
                new PessoaDto() { Codigo = 2, Nome = "Roberto Duarte", EstaAtivo = null },
                new PessoaDto() { Codigo = 3, Nome = "João do Pulo", EstaAtivo = false }
            };

            foreach (var pessoa in listaPessoa.Where(w => w.EstaAtivo.IsValid()))
            {
                Console.WriteLine(String.Format("A pessoa de nome {0} está ativa!", pessoa.Nome));
            }

            Console.ReadLine();
        }
    }
}
