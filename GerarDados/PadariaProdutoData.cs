using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_Padaria.Model;

namespace WindowsForm_Padaria.GerarDados
{
    public class PadariaProdutoData
    {
        public static List<Padaria_Produto> GetProdutos()
        {
            return new List<Padaria_Produto> {
            // Categoria 1 - Pães
            new Padaria_Produto { Codigo = 101, Nome = "Pão de Batata", Descricao = "Macio com leve sabor de batata", Preco = 1.50m, CategoriaId = 1 },
            new Padaria_Produto { Codigo = 102, Nome = "Pão de Queijo", Descricao = "Tradicional mineiro", Preco = 2.00m, CategoriaId = 1 },
            new Padaria_Produto { Codigo = 103, Nome = "Pão Australiano", Descricao = "Aromático e adocicado", Preco = 3.50m, CategoriaId = 1 },
            new Padaria_Produto { Codigo = 104, Nome = "Pão Doce com Coco", Descricao = "Coberto com coco ralado", Preco = 2.50m, CategoriaId = 1 },
            new Padaria_Produto { Codigo = 105, Nome = "Pão Sírio", Descricao = "Ideal para wraps e lanches", Preco = 2.00m, CategoriaId = 1 },

            // Categoria 2 - Bolos
            new Padaria_Produto { Codigo = 201, Nome = "Bolo de Chocolate", Descricao = "Fofinho com cobertura cremosa", Preco = 16.00m, CategoriaId = 2 },
            new Padaria_Produto { Codigo = 202, Nome = "Bolo de Laranja", Descricao = "Sabor cítrico e massa leve", Preco = 13.00m, CategoriaId = 2 },
            new Padaria_Produto { Codigo = 203, Nome = "Bolo Mármore", Descricao = "Mesclado de chocolate e baunilha", Preco = 14.00m, CategoriaId = 2 },
            new Padaria_Produto { Codigo = 204, Nome = "Bolo de Banana com Canela", Descricao = "Perfumado e delicioso", Preco = 12.50m, CategoriaId = 2 },
            new Padaria_Produto { Codigo = 205, Nome = "Bolo de Milho", Descricao = "Tradicional e úmido", Preco = 11.00m, CategoriaId = 2 },

            // Categoria 3 - Salgados
            new Padaria_Produto { Codigo = 301, Nome = "Esfiha de Carne", Descricao = "Recheio temperado e suculento", Preco = 4.00m, CategoriaId = 3 },
            new Padaria_Produto { Codigo = 302, Nome = "Quibe", Descricao = "Salgado de trigo e carne moída", Preco = 4.50m, CategoriaId = 3 },
            new Padaria_Produto { Codigo = 303, Nome = "Pastel de Queijo", Descricao = "Frito na hora", Preco = 5.00m, CategoriaId = 3 },
            new Padaria_Produto { Codigo = 304, Nome = "Bolinha de Queijo", Descricao = "Crocante por fora e cremosa por dentro", Preco = 3.50m, CategoriaId = 3 },
            new Padaria_Produto { Codigo = 305, Nome = "Croquete de Carne", Descricao = "Tradicional e saboroso", Preco = 4.00m, CategoriaId = 3 },

            // Categoria 4 - Doces
            new Padaria_Produto { Codigo = 401, Nome = "Pudim de Leite", Descricao = "Clássico brasileiro com calda", Preco = 8.00m, CategoriaId = 4 },
            new Padaria_Produto { Codigo = 402, Nome = "Quindim", Descricao = "Doce de gema com coco", Preco = 3.00m, CategoriaId = 4 },
            new Padaria_Produto { Codigo = 403, Nome = "Romeu e Julieta", Descricao = "Goiabada com queijo", Preco = 5.00m, CategoriaId = 4 },
            new Padaria_Produto { Codigo = 404, Nome = "Torta Holandesa", Descricao = "Com base crocante e creme", Preco = 18.00m, CategoriaId = 4 },
            new Padaria_Produto { Codigo = 405, Nome = "Mousse de Maracujá", Descricao = "Doce, ácido e leve", Preco = 6.00m, CategoriaId = 4 },

            // Categoria 5 - Biscoitos
            new Padaria_Produto { Codigo = 501, Nome = "Biscoito Amanteigado", Descricao = "Derrete na boca", Preco = 7.00m, CategoriaId = 5 },
            new Padaria_Produto { Codigo = 502, Nome = "Biscoito de Aveia e Mel", Descricao = "Integral e saboroso", Preco = 6.50m, CategoriaId = 5 },
            new Padaria_Produto { Codigo = 503, Nome = "Biscoito de Gengibre", Descricao = "Aromático e levemente picante", Preco = 6.00m, CategoriaId = 5 },
            new Padaria_Produto { Codigo = 504, Nome = "Biscoito Recheado de Doce de Leite", Descricao = "Crosta crocante e recheio doce", Preco = 7.50m, CategoriaId = 5 },
            new Padaria_Produto { Codigo = 505, Nome = "Sequilho de Coco", Descricao = "Tradicional e leve", Preco = 5.00m, CategoriaId = 5 },

            // Categoria 6 - Tortas
            new Padaria_Produto { Codigo = 601, Nome = "Torta de Morango", Descricao = "Com creme e frutas frescas", Preco = 20.00m, CategoriaId = 6 },
            new Padaria_Produto { Codigo = 602, Nome = "Torta de Chocolate", Descricao = "Intensa e cremosa", Preco = 22.00m, CategoriaId = 6 },
            new Padaria_Produto { Codigo = 603, Nome = "Torta de Frango com Requeijão", Descricao = "Salgada e cremosa", Preco = 19.00m, CategoriaId = 6 },
            new Padaria_Produto { Codigo = 604, Nome = "Torta de Palmito", Descricao = "Leve e saborosa", Preco = 18.00m, CategoriaId = 6 },
            new Padaria_Produto { Codigo = 605, Nome = "Torta Alemã", Descricao = "Sobremesa gelada com biscoito", Preco = 21.00m, CategoriaId = 6 },

            // Categoria 7 - Sanduíches
            new Padaria_Produto { Codigo = 701, Nome = "Sanduíche de Atum", Descricao = "Com salada e maionese", Preco = 9.00m, CategoriaId = 7 },
            new Padaria_Produto { Codigo = 702, Nome = "Sanduíche Vegano", Descricao = "Recheado com legumes grelhados", Preco = 10.00m, CategoriaId = 7 },
            new Padaria_Produto { Codigo = 703, Nome = "Sanduíche de Peito de Peru", Descricao = "Leve e nutritivo", Preco = 9.50m, CategoriaId = 7 },
            new Padaria_Produto { Codigo = 704, Nome = "Sanduíche Caprese", Descricao = "Com mussarela de búfala e manjericão", Preco = 11.00m, CategoriaId = 7 },
            new Padaria_Produto { Codigo = 705, Nome = "Sanduíche de Ovos", Descricao = "Simples e saboroso", Preco = 8.00m, CategoriaId = 7 },

            // Categoria 8 - Confeitaria
            new Padaria_Produto { Codigo = 801, Nome = "Trufa de Chocolate", Descricao = "Fina e cremosa", Preco = 4.00m, CategoriaId = 8 },
            new Padaria_Produto { Codigo = 802, Nome = "Tartelete de Frutas", Descricao = "Base crocante com frutas frescas", Preco = 7.00m, CategoriaId = 8 },
            new Padaria_Produto { Codigo = 803, Nome = "Bomba de Creme", Descricao = "Recheada e coberta com chocolate", Preco = 6.50m, CategoriaId = 8 },
            new Padaria_Produto { Codigo = 804, Nome = "Canudinho de Doce de Leite", Descricao = "Massa crocante com recheio", Preco = 3.00m, CategoriaId = 8 },
            new Padaria_Produto { Codigo = 805, Nome = "Petit Gâteau", Descricao = "Bolinho com recheio quente", Preco = 9.00m, CategoriaId = 8 },

            // Categoria 9 - Sem Glúten
            new Padaria_Produto { Codigo = 901, Nome = "Cookies Sem Glúten", Descricao = "Feitos com farinha de amêndoas", Preco = 8.00m, CategoriaId = 9 },
            new Padaria_Produto { Codigo = 902, Nome = "Pão de Linhaça Sem Glúten", Descricao = "Nutritivo e leve", Preco = 7.50m, CategoriaId = 9 },
            new Padaria_Produto { Codigo = 903, Nome = "Bolo de Laranja Sem Glúten", Descricao = "Com casca e sem farinha de trigo", Preco = 15.00m, CategoriaId = 9 },
            new Padaria_Produto { Codigo = 904, Nome = "Torta de Frango Sem Glúten", Descricao = "Feita com farinha de arroz", Preco = 17.00m, CategoriaId = 9 },
            new Padaria_Produto { Codigo = 905, Nome = "Brownie Sem Glúten", Descricao = "Macio e intenso", Preco = 10.00m, CategoriaId = 9 },

            // Categoria 10 - Sem Lactose
            new Padaria_Produto { Codigo = 1001, Nome = "Bolo de Cenoura Sem Lactose", Descricao = "Sem leite e com calda de chocolate", Preco = 15.00m, CategoriaId = 10 },
            new Padaria_Produto { Codigo = 1002, Nome = "Pão de Mandioquinha Sem Lactose", Descricao = "Alternativa leve e saborosa", Preco = 6.50m, CategoriaId = 10 },
            new Padaria_Produto { Codigo = 1003, Nome = "Doce de Abóbora Sem Lactose", Descricao = "Natural e vegano", Preco = 5.00m, CategoriaId = 10 },
            new Padaria_Produto { Codigo = 1004, Nome = "Mousse de Limão Sem Lactose", Descricao = "Refrescante e leve", Preco = 7.00m, CategoriaId = 10 },
            new Padaria_Produto { Codigo = 1005, Nome = "Torta de Banana Sem Lactose", Descricao = "Feita com óleo vegetal", Preco = 16.00m, CategoriaId = 10 }
            };
        }
    }
}