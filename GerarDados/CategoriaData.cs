using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_Padaria.Model;

namespace WindowsForm_Padaria.GerarDados
{
    public class CategoriaData
    {
        public static List<Categoria> GetCategorias()
        {
            return new List<Categoria>
        {
            new Categoria { Nome = "Pães", Descricao = "Diversos tipos de pães frescos" },
            new Categoria { Nome = "Bolos", Descricao = "Bolos caseiros e industriais" },
            new Categoria { Nome = "Salgados", Descricao = "Salgados assados e fritos" },
            new Categoria { Nome = "Doces", Descricao = "Doces caseiros e industrializados" },
            new Categoria { Nome = "Biscoitos", Descricao = "Biscoitos diversos" },
            new Categoria { Nome = "Tortas", Descricao = "Tortas doces e salgadas" },
            new Categoria { Nome = "Sanduíches", Descricao = "Sanduíches naturais e especiais" },
            new Categoria { Nome = "Confeitaria", Descricao = "Produtos de confeitaria fina" },
            new Categoria { Nome = "Sem Glúten", Descricao = "Produtos para dieta sem glúten" },
            new Categoria { Nome = "Sem Lactose", Descricao = "Produtos para dieta sem lactose" }
        };
        }
    }
}
