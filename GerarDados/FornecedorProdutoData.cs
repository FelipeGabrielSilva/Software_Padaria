using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_Padaria.Model;

namespace WindowsForm_Padaria.GerarDados
{
    public class FornecedorProdutoData
    {
        public static List<Fornecedor_Produto> GetFornecedorProdutos()
        {
            List<Fornecedor_Produto> produtos = new List<Fornecedor_Produto>();

            int proximoFornecedorId = 1;
            int maxFornecedores = 50;

            // Ingredientes básicos de panificação e confeitaria
            produtos.Add(new Fornecedor_Produto { Codigo = 1001, Nome = "Farinha de Trigo Tipo 1 - 25kg", Descricao = "Farinha de trigo premium para pães e massas finas.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1002, Nome = "Açúcar Refinado - 50kg", Descricao = "Saco de açúcar refinado para grande volume.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1003, Nome = "Fermento Biológico Seco - 1kg", Descricao = "Fermento de alta ativação para pães e pizzas.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1004, Nome = "Sal Refinado - 25kg", Descricao = "Sal iodado para uso industrial.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1005, Nome = "Ovos Brancos Grandes - Caixa c/ 360", Descricao = "Caixa de ovos frescos para confeitaria.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1006, Nome = "Leite Integral UHT - Caixa c/ 12x1L", Descricao = "Leite longa vida integral, excelente para receitas.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1007, Nome = "Manteiga Sem Sal - 5kg Bloco", Descricao = "Manteiga fresca sem sal para uso profissional.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1008, Nome = "Chocolate em Pó 50% Cacau - 5kg", Descricao = "Chocolate em pó de alta qualidade para doces.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1009, Nome = "Essência de Baunilha - 500ml", Descricao = "Extrato concentrado de baunilha para aromatizar.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1010, Nome = "Óleo de Girassol - 5L", Descricao = "Óleo vegetal de girassol para frituras e massas.", FornecedorId = proximoFornecedorId++ });

            // Laticínios e Derivados
            produtos.Add(new Fornecedor_Produto { Codigo = 1011, Nome = "Queijo Minas Padrão - Kg (Peça)", Descricao = "Queijo fresco para pão de queijo e sanduíches.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1012, Nome = "Creme de Leite Fresco - 1L", Descricao = "Creme de leite com teor de gordura ideal para chantilly.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1013, Nome = "Leite Condensado - Lata (Caixa c/ 24)", Descricao = "Leite condensado integral para doces.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1014, Nome = "Doce de Leite Cremoso - 5kg Balde", Descricao = "Doce de leite pastoso para recheios.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1015, Nome = "Ricota Fresca - Kg", Descricao = "Ricota para recheios salgados ou doces.", FornecedorId = proximoFornecedorId++ });

            // Frutas, Castanhas e Grãos
            produtos.Add(new Fornecedor_Produto { Codigo = 1016, Nome = "Coco Ralado Úmido e Adoçado - 1kg", Descricao = "Coco ralado para doces e bolos.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1017, Nome = "Uva Passa Preta - 500g", Descricao = "Uva passa para panetones e bolos de frutas.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1018, Nome = "Castanha-do-Pará Quebrada - 1kg", Descricao = "Castanha-do-Pará selecionada para confeitaria.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1019, Nome = "Amendoim Torrado e Moído - 1kg", Descricao = "Amendoim para paçocas e doces.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1020, Nome = "Aveia em Flocos Finos - 1kg", Descricao = "Aveia para granolas e pães saudáveis.", FornecedorId = proximoFornecedorId++ });

            // Recheios e Coberturas Prontos
            produtos.Add(new Fornecedor_Produto { Codigo = 1021, Nome = "Recheio Forneável Chocolate - 2kg", Descricao = "Recheio pronto para produtos assados.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1022, Nome = "Cobertura de Chocolate Meio Amargo - 1kg", Descricao = "Chocolate para coberturas e raspas.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1023, Nome = "Creme Confeiteiro Pronto - 1kg", Descricao = "Creme para recheios e decoração.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1024, Nome = "Pasta Saborizante Morango - 500g", Descricao = "Pasta concentrada para saborizar massas e cremes.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1025, Nome = "Geleia de Brilho Neutra - 1kg Balde", Descricao = "Geleia para dar brilho a frutas e tortas.", FornecedorId = proximoFornecedorId++ });

            // Ingredientes Especiais e Outros
            produtos.Add(new Fornecedor_Produto { Codigo = 1026, Nome = "Mistura para Pão Francês - 10kg", Descricao = "Pré-mistura completa para pão francês.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1027, Nome = "Mel Puro de Abelhas - 1kg Pote", Descricao = "Mel natural para adoçar e dar sabor.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1028, Nome = "Glicose de Milho Líquida - 1kg", Descricao = "Glicose para dar maciez e brilho a doces.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1029, Nome = "Amido de Milho - 5kg", Descricao = "Amido para espessar e dar liga.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1030, Nome = "Margarina Folhada - 2kg Bloco", Descricao = "Margarina específica para massas folhadas.", FornecedorId = proximoFornecedorId++ });

            // Produtos de uso diário na padaria
            produtos.Add(new Fornecedor_Produto { Codigo = 1031, Nome = "Queijo Mussarela Fatiado - 1kg", Descricao = "Queijo mussarela para sanduíches e pizzas.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1032, Nome = "Presunto Cozido Fatiado - 1kg", Descricao = "Presunto de porco cozido e fatiado.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1033, Nome = "Mortadela Fatiada - 1kg", Descricao = "Mortadela de carne para lanches.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1034, Nome = "Requeijão Cremoso - 1.8kg Balde", Descricao = "Requeijão para pães e salgados.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1035, Nome = "Salsicha Tipo Hot Dog - Kg", Descricao = "Salsicha para lanches.", FornecedorId = proximoFornecedorId++ });

            // Complementos e embalagens relacionadas a alimentos
            produtos.Add(new Fornecedor_Produto { Codigo = 1036, Nome = "Café Torrado e Moído - 1kg", Descricao = "Café de alta qualidade para o balcão.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1037, Nome = "Chá Preto Sachê - Caixa c/ 100", Descricao = "Chá preto para bebidas quentes.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1038, Nome = "Adoçante Líquido - 1L", Descricao = "Adoçante para bebidas.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1039, Nome = "Guardanapo de Papel - Pacote c/ 500", Descricao = "Guardanapos de papel para mesas.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1040, Nome = "Copo Descartável Biodegradável - 200ml (Cx 1000)", Descricao = "Copo para bebidas.", FornecedorId = proximoFornecedorId++ });

            // Mais ingredientes e produtos variados
            produtos.Add(new Fornecedor_Produto { Codigo = 1041, Nome = "Gelatina em Pó Incolor - 500g", Descricao = "Gelatina para sobremesas e mousses.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1042, Nome = "Xarope de Glucose - 1kg", Descricao = "Xarope para confeitaria.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1043, Nome = "Corante Alimentício Líquido - Kit 6 cores", Descricao = "Corantes para massas e coberturas.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1044, Nome = "Massa Folhada Congelada - 1kg", Descricao = "Massa pronta para folhados doces e salgados.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1045, Nome = "Creme de Leite de Soja - 1L", Descricao = "Alternativa vegetal para creme de leite.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1046, Nome = "Fermento Químico em Pó - 500g", Descricao = "Fermento para bolos e biscoitos.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1047, Nome = "Oleo de Palma - 10kg Balde", Descricao = "Gordura vegetal para frituras e panificação.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1048, Nome = "Castanha de Caju Torrada - 500g", Descricao = "Castanha para decoração e recheios.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1049, Nome = "Amêndoas Laminadas - 500g", Descricao = "Amêndoas para decoração e receitas.", FornecedorId = proximoFornecedorId++ });
            produtos.Add(new Fornecedor_Produto { Codigo = 1050, Nome = "Leite em Pó Integral - 1kg", Descricao = "Leite em pó para preparos e bebidas.", FornecedorId = proximoFornecedorId++ });

            return produtos;
        }
    }
}
