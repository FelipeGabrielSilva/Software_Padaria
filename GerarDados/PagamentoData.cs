using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_Padaria.Model;

namespace WindowsForm_Padaria.GerarDados
{
    public static class PagamentoData
    {
        public static List<Pagamento> GetPagamentos()
        {
            return new List<Pagamento>
            {
                new Pagamento { Id = 1, Nome = "Cartão de Crédito" }, // Importante que o ID seja 1
                new Pagamento { Id = 2, Nome = "Dinheiro" },
                new Pagamento { Id = 3, Nome = "Pix" }
            };
        }
    }
}
