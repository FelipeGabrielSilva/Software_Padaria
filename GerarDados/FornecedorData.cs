using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForm_Padaria.Model;

namespace WindowsForm_Padaria.GerarDados
{
    public class FornecedorData
    {
        public static List<Fornecedor> GetFornecedores()
        {
            return new List<Fornecedor>
            {
                new Fornecedor
                {
                    Nome = "Moinho Real S.A.", Telefone = "(11) 5550-1001", Email = "contato@moinhoreal.com.br",
                    Endereco = "Rua do Trigo, 150", Bairro = "Grão Dourado", NumeroEndereco = "150",
                    CNPJ = "01.234.567/0001-90", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Laticínios Pura Vida Ltda.", Telefone = "(11) 5550-1002", Email = "vendas@puravida.com.br",
                    Endereco = "Av. do Leite, 220", Bairro = "Laticínios", NumeroEndereco = "220",
                    CNPJ = "02.345.678/0001-80", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Doce Aroma Essências", Telefone = "(11) 5550-1003", Email = "comercial@docearoma.com.br",
                    Endereco = "Rua da Baunilha, 30", Bairro = "Confeitaria Fina", NumeroEndereco = "30",
                    CNPJ = "03.456.789/0001-70", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Distribuidora Grãos Nobres", Telefone = "(11) 5550-1004", Email = "pedidos@graosnobres.com.br",
                    Endereco = "Travessa do Cacau, 88", Bairro = "Biscoito Doce", NumeroEndereco = "88",
                    CNPJ = "04.567.890/0001-60", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Pães & Cia Ingredientes", Telefone = "(11) 5550-1005", Email = "contato@paescia.com.br",
                    Endereco = "Av. do Fermento, 45", Bairro = "Forno Quente", NumeroEndereco = "45",
                    CNPJ = "05.678.901/0001-50", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Alimentos Frescos do Campo", Telefone = "(11) 5550-1006", Email = "contato@frescosdocampo.com.br",
                    Endereco = "Estrada da Granja, 100", Bairro = "Zona Rural", NumeroEndereco = "100",
                    CNPJ = "06.789.012/0001-40", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Recheios Sabor Divino", Telefone = "(11) 5550-1007", Email = "pedidos@sabordivino.com.br",
                    Endereco = "Rua do Brigadeiro, 25", Bairro = "Gourmet", NumeroEndereco = "25",
                    CNPJ = "07.890.123/0001-30", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Embalagens Panificadora Soluções", Telefone = "(11) 5550-1008", Email = "vendas@embalagenspanificadora.com.br",
                    Endereco = "Av. do Papel, 70", Bairro = "Setor Industrial", NumeroEndereco = "70",
                    CNPJ = "08.901.234/0001-20", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Ovos Dourados Granja", Telefone = "(11) 5550-1009", Email = "atendimento@ovosdourados.com.br",
                    Endereco = "Rodovia das Aves, km 5", Bairro = "Cinto Verde", NumeroEndereco = "500",
                    CNPJ = "09.012.345/0001-10", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Óleos & Gorduras Essenciais", Telefone = "(11) 5550-1010", Email = "suporte@oleosegorduras.com.br",
                    Endereco = "Rua da Fritura, 12", Bairro = "Indústria Alimentícia", NumeroEndereco = "12",
                    CNPJ = "10.123.456/0001-00", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Frutas Cristalizadas Brasil", Telefone = "(11) 5550-1011", Email = "contato@frutascristalizadas.com.br",
                    Endereco = "Av. das Frutas, 110", Bairro = "Sabor Tropical", NumeroEndereco = "110",
                    CNPJ = "11.234.567/0001-99", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Açucares Puros Ltda.", Telefone = "(11) 5550-1012", Email = "vendas@acucarespuros.com.br",
                    Endereco = "Rua do Açúcar, 200", Bairro = "Doçura", NumeroEndereco = "200",
                    CNPJ = "12.345.678/0001-88", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Cacau & Cia. Chocolates", Telefone = "(11) 5550-1013", Email = "pedidos@cacaucia.com.br",
                    Endereco = "Travessa do Cacau, 50", Bairro = "Chocolataria", NumeroEndereco = "50",
                    CNPJ = "13.456.789/0001-77", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Grãos do Campo Orgânicos", Telefone = "(11) 5550-1014", Email = "contato@graosdocampo.com.br",
                    Endereco = "Estrada da Colheita, 300", Bairro = "Vida Saudável", NumeroEndereco = "300",
                    CNPJ = "14.567.890/0001-66", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Temperos Naturais Essenciais", Telefone = "(11) 5550-1015", Email = "vendas@temperosnaturais.com.br",
                    Endereco = "Rua das Ervas, 15", Bairro = "Aromas", NumeroEndereco = "15",
                    CNPJ = "15.678.901/0001-55", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Pescados Frescos Oceano", Telefone = "(11) 5550-1016", Email = "comercial@pescadosoceano.com.br",
                    Endereco = "Av. do Mar, 400", Bairro = "Peixaria", NumeroEndereco = "400",
                    CNPJ = "16.789.012/0001-44", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Carnes Nobres Grelha", Telefone = "(11) 5550-1017", Email = "pedidos@carnesgrelha.com.br",
                    Endereco = "Rua do Açougue, 75", Bairro = "Churrascaria", NumeroEndereco = "75",
                    CNPJ = "17.890.123/0001-33", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Cereais Matinais Crocantes", Telefone = "(11) 5550-1018", Email = "contato@cereaiscrocantes.com.br",
                    Endereco = "Av. dos Cereais, 99", Bairro = "Café da Manhã", NumeroEndereco = "99",
                    CNPJ = "18.901.234/0001-22", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Geleias e Doces Caseiros", Telefone = "(11) 5550-1019", Email = "vendas@geleiasecia.com.br",
                    Endereco = "Rua da Fruta, 123", Bairro = "Quitutes da Vovó", NumeroEndereco = "123",
                    CNPJ = "19.012.345/0001-11", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Pizzas Congeladas Master", Telefone = "(11) 5550-1020", Email = "comercial@pizzasmaster.com.br",
                    Endereco = "Travessa da Pizza, 10", Bairro = "Forno Express", NumeroEndereco = "10",
                    CNPJ = "20.123.456/0001-00", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Massas Artesanais Dona Clara", Telefone = "(11) 5550-1021", Email = "contato@massasdona.com.br",
                    Endereco = "Rua da Nona, 55", Bairro = "Cantina Italiana", NumeroEndereco = "55",
                    CNPJ = "21.234.567/0001-99", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Congelados Praticidade", Telefone = "(11) 5550-1022", Email = "vendas@congeladosprat.com.br",
                    Endereco = "Av. do Frio, 20", Bairro = "Refrigerados", NumeroEndereco = "20",
                    CNPJ = "22.345.678/0001-88", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Bebidas Naturais Pura Essência", Telefone = "(11) 5550-1023", Email = "pedidos@bebidapura.com.br",
                    Endereco = "Rua do Detox, 80", Bairro = "Saúde Total", NumeroEndereco = "80",
                    CNPJ = "23.456.789/0001-77", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Mercearia Completa Tudo Aqui", Telefone = "(11) 5550-1024", Email = "contato@tudoaqui.com.br",
                    Endereco = "Av. do Comércio, 150", Bairro = "Mercado Central", NumeroEndereco = "150",
                    CNPJ = "24.567.890/0001-66", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Snacks Deliciosos Ltda.", Telefone = "(11) 5550-1025", Email = "vendas@snacksdeliciosos.com.br",
                    Endereco = "Rua do Petisco, 40", Bairro = "Lanches Rápidos", NumeroEndereco = "40",
                    CNPJ = "25.678.901/0001-55", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Especiarias do Oriente", Telefone = "(11) 5550-1026", Email = "comercial@especiarias.com.br",
                    Endereco = "Travessa da Pimenta, 5", Bairro = "Sabor Exótico", NumeroEndereco = "5",
                    CNPJ = "26.789.012/0001-44", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Salgados Congelados Mania", Telefone = "(11) 5550-1027", Email = "pedidos@salgadosmania.com.br",
                    Endereco = "Rua da Coxinha, 11", Bairro = "Festa Express", NumeroEndereco = "11",
                    CNPJ = "27.890.123/0001-33", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Sorvetes Delícia Gelada", Telefone = "(11) 5550-1028", Email = "contato@sorvetesdelicia.com.br",
                    Endereco = "Av. do Sorvete, 22", Bairro = "Verão Feliz", NumeroEndereco = "22",
                    CNPJ = "28.901.234/0001-22", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Aves & Ovos Fresquinhos", Telefone = "(11) 5550-1029", Email = "vendas@aveseovos.com.br",
                    Endereco = "Estrada da Granja, 250", Bairro = "Campo Aberto", NumeroEndereco = "250",
                    CNPJ = "29.012.345/0001-11", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Hortifruti Verde Mais", Telefone = "(11) 5550-1030", Email = "pedidos@verdemais.com.br",
                    Endereco = "Rua da Horta, 18", Bairro = "Alimentação Saudável", NumeroEndereco = "18",
                    CNPJ = "30.123.456/0001-00", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Margarinas & Cremes Nobres", Telefone = "(11) 5550-1031", Email = "contato@margarinasnobres.com.br",
                    Endereco = "Av. dos Laticínios, 88", Bairro = "Cremes Finos", NumeroEndereco = "88",
                    CNPJ = "31.234.567/0001-99", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Gluten Free & Cia.", Telefone = "(11) 5550-1032", Email = "vendas@glutenfree.com.br",
                    Endereco = "Rua Sem Glúten, 10", Bairro = "Vida Leve", NumeroEndereco = "10",
                    CNPJ = "32.345.678/0001-88", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Veganos Sabor & Saúde", Telefone = "(11) 5550-1033", Email = "pedidos@veganossabor.com.br",
                    Endereco = "Av. Vegana, 12", Bairro = "Consciência Alimentar", NumeroEndereco = "12",
                    CNPJ = "33.456.789/0001-77", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Cafés & Chás Especiais", Telefone = "(11) 5550-1034", Email = "contato@cafesechasespeciais.com.br",
                    Endereco = "Rua do Grão, 7", Bairro = "Aroma Puro", NumeroEndereco = "7",
                    CNPJ = "34.567.890/0001-66", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Pizzas Gourmet Congeladas", Telefone = "(11) 5550-1035", Email = "vendas@pizzasgourmet.com.br",
                    Endereco = "Av. do Forno, 33", Bairro = "Sabor Ítalo", NumeroEndereco = "33",
                    CNPJ = "35.678.901/0001-55", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Congelados da Nonna", Telefone = "(11) 5550-1036", Email = "pedidos@congeladosnonna.com.br",
                    Endereco = "Rua da Família, 22", Bairro = "Tradição", NumeroEndereco = "22",
                    CNPJ = "36.789.012/0001-44", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Snacks Saudáveis e Cia.", Telefone = "(11) 5550-1037", Email = "contato@snacksaudaveis.com.br",
                    Endereco = "Av. da Energia, 44", Bairro = "Bem Estar", NumeroEndereco = "44",
                    CNPJ = "37.890.123/0001-33", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Frutos do Mar Frescos Ltda.", Telefone = "(11) 5550-1038", Email = "vendas@frutosdomar.com.br",
                    Endereco = "Rua do Pescador, 10", Bairro = "Oceano", NumeroEndereco = "10",
                    CNPJ = "38.901.234/0001-22", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Temperos e Condimentos Premium", Telefone = "(11) 5550-1039", Email = "pedidos@temperospremium.com.br",
                    Endereco = "Av. dos Condimentos, 77", Bairro = "Aroma Fino", NumeroEndereco = "77",
                    CNPJ = "39.012.345/0001-11", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Distribuidora de Grãos Finos", Telefone = "(11) 5550-1040", Email = "contato@graosfinos.com.br",
                    Endereco = "Rua do Arroz, 50", Bairro = "Celeiro", NumeroEndereco = "50",
                    CNPJ = "40.123.456/0001-00", PagamentoId = 1
                },
                 new Fornecedor
                {
                    Nome = "Pescados do Rio e Mar", Telefone = "(11) 5550-1041", Email = "vendas@pescadosriomar.com.br",
                    Endereco = "Rua do Pescado, 12", Bairro = "Marés", NumeroEndereco = "12",
                    CNPJ = "41.234.567/0001-90", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Açougue Carnes do Campo", Telefone = "(11) 5550-1042", Email = "contato@carnesdocampo.com.br",
                    Endereco = "Av. do Boi, 30", Bairro = "Fazenda Viva", NumeroEndereco = "30",
                    CNPJ = "42.345.678/0001-80", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Embalagens Sustentáveis EcoPack", Telefone = "(11) 5550-1043", Email = "info@ecopack.com.br",
                    Endereco = "Rua da Sustentabilidade, 5", Bairro = "Meio Ambiente", NumeroEndereco = "5",
                    CNPJ = "43.456.789/0001-70", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Cerealista Bom Grão", Telefone = "(11) 5550-1044", Email = "vendas@bomgrao.com.br",
                    Endereco = "Travessa do Trigo, 20", Bairro = "Moenda", NumeroEndereco = "20",
                    CNPJ = "44.567.890/0001-60", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Panificados Prontos Master", Telefone = "(11) 5550-1045", Email = "contato@panificadosmaster.com.br",
                    Endereco = "Rua do Pão, 100", Bairro = "Boulangerie", NumeroEndereco = "100",
                    CNPJ = "45.678.901/0001-50", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Distribuidora de Ovos Gallus", Telefone = "(11) 5550-1046", Email = "pedidos@ovosgallus.com.br",
                    Endereco = "Estrada da Ave, 222", Bairro = "Granja Central", NumeroEndereco = "222",
                    CNPJ = "46.789.012/0001-40", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Doces Artesanais da Vovó", Telefone = "(11) 5550-1047", Email = "contato@docesdavovo.com.br",
                    Endereco = "Rua da Confeitaria, 30", Bairro = "Sabor Caseiro", NumeroEndereco = "30",
                    CNPJ = "47.890.123/0001-30", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Farinhas Especiais Gourmet", Telefone = "(11) 5550-1048", Email = "vendas@farinhasgourmet.com.br",
                    Endereco = "Av. do Chef, 40", Bairro = "Cozinha Profissional", NumeroEndereco = "40",
                    CNPJ = "48.901.234/0001-20", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Leites Vegetais Vida Leve", Telefone = "(11) 5550-1049", Email = "pedidos@leitesvidaleve.com.br",
                    Endereco = "Rua da Saúde, 15", Bairro = "Bem Estar Natural", NumeroEndereco = "15",
                    CNPJ = "49.012.345/0001-10", PagamentoId = 1
                },
                new Fornecedor
                {
                    Nome = "Ingredientes para Padarias Premium", Telefone = "(11) 5550-1050", Email = "contato@ingredientespremium.com.br",
                    Endereco = "Av. da Padaria, 88", Bairro = "Master Baker", NumeroEndereco = "88",
                    CNPJ = "50.123.456/0001-00", PagamentoId = 1
                }
        };
        }
    }
}
