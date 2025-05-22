namespace WindowsForm_Padaria
{
    using System.Collections.Generic;
    using WindowsForm_Padaria.Model;

    public class FornecedorData
    {
        public static List<Fornecedor> GetFornecedores()
        {
            return new List<Fornecedor>
        {
            new Fornecedor
            {
                Nome = "Alimentos Sabor & Arte Ltda",
                Telefone = "(11) 3456-7890",
                Email = "contato@saborearte.com.br",
                Endereco = "Rua das Delícias",
                Bairro = "Centro",
                Numero = "123",
                CNPJ = "12.345.678/0001-90",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Bebidas Refrescante SA",
                Telefone = "(21) 2567-8901",
                Email = "vendas@refrescante.com.br",
                Endereco = "Avenida das Nações",
                Bairro = "Jardim América",
                Numero = "456",
                CNPJ = "23.456.789/0001-01",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Distribuidora Mercado Fácil Ltda",
                Telefone = "(31) 3789-0123",
                Email = "sac@mercadofacil.com.br",
                Endereco = "Rua dos Comerciantes",
                Bairro = "Industrial",
                Numero = "789",
                CNPJ = "34.567.890/0001-12",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Tecnologia Avançada SA",
                Telefone = "(19) 2890-1234",
                Email = "suporte@tecnologiaavancada.com.br",
                Endereco = "Avenida Digital",
                Bairro = "Tecnopolis",
                Numero = "101",
                CNPJ = "45.678.901/0001-23",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Móveis Conforto & Estilo Ltda",
                Telefone = "(47) 3901-2345",
                Email = "vendas@confortoestilo.com.br",
                Endereco = "Rua das Madeiras",
                Bairro = "Nova Cidade",
                Numero = "202",
                CNPJ = "56.789.012/0001-34",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Papelaria Criativa SA",
                Telefone = "(51) 4012-3456",
                Email = "atendimento@papelariacriativa.com.br",
                Endereco = "Avenida dos Escritórios",
                Bairro = "Centro Empresarial",
                Numero = "303",
                CNPJ = "67.890.123/0001-45",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Limpeza Brilho Total Ltda",
                Telefone = "(85) 5123-4567",
                Email = "sac@brilhototal.com.br",
                Endereco = "Rua da Higiene",
                Bairro = "Limpeza Pura",
                Numero = "404",
                CNPJ = "78.901.234/0001-56",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Construção Forte & Segura SA",
                Telefone = "(27) 6234-5678",
                Email = "orcamento@fortesegura.com.br",
                Endereco = "Avenida dos Edifícios",
                Bairro = "Nova Construção",
                Numero = "505",
                CNPJ = "89.012.345/0001-67",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Vestuário Moda Elegante Ltda",
                Telefone = "(71) 7345-6789",
                Email = "contato@modaelegante.com.br",
                Endereco = "Rua das Modelagens",
                Bairro = "Fashion Mall",
                Numero = "606",
                CNPJ = "90.123.456/0001-78",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Eletrônicos Futuro Digital SA",
                Telefone = "(62) 8456-7890",
                Email = "vendas@futurodigital.com.br",
                Endereco = "Avenida Tecnológica",
                Bairro = "Digital Park",
                Numero = "707",
                CNPJ = "01.234.567/0001-89",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Farmácia Bem Estar Ltda",
                Telefone = "(98) 9567-8901",
                Email = "farmacia@bemestar.com.br",
                Endereco = "Rua da Saúde",
                Bairro = "Vida Saudável",
                Numero = "808",
                CNPJ = "12.345.679/0001-90",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Automotivos Veloz & Furioso SA",
                Telefone = "(11) 2678-9012",
                Email = "pecas@velozfurioso.com.br",
                Endereco = "Avenida dos Carros",
                Bairro = "Motor City",
                Numero = "909",
                CNPJ = "23.456.780/0001-01",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Petshop Amigo Animal Ltda",
                Telefone = "(21) 3789-0123",
                Email = "atendimento@amigoanimal.com.br",
                Endereco = "Rua dos Bichinhos",
                Bairro = "Pet Village",
                Numero = "1010",
                CNPJ = "34.567.891/0001-12",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Restaurante Sabor Caseiro SA",
                Telefone = "(31) 4890-1234",
                Email = "reservas@saborcaseiro.com.br",
                Endereco = "Avenida Gastronômica",
                Bairro = "Gourmet Square",
                Numero = "111",
                CNPJ = "45.678.902/0001-23",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Hotel Conforto & Descanso Ltda",
                Telefone = "(48) 5901-2345",
                Email = "reservas@confortodescanso.com.br",
                Endereco = "Rua do Repouso",
                Bairro = "Bem Estar",
                Numero = "1212",
                CNPJ = "56.789.013/0001-34",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Transporte Rápido & Seguro SA",
                Telefone = "(19) 6012-3456",
                Email = "frete@rapidoseguro.com.br",
                Endereco = "Avenida das Estradas",
                Bairro = "Logística Center",
                Numero = "1313",
                CNPJ = "67.890.124/0001-45",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Educação Futuro Brilhante Ltda",
                Telefone = "(81) 7123-4567",
                Email = "secretaria@futurobrilhante.com.br",
                Endereco = "Rua do Conhecimento",
                Bairro = "Saber Mais",
                Numero = "1414",
                CNPJ = "78.901.235/0001-56",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Segurança Proteção Total SA",
                Telefone = "(12) 8234-5678",
                Email = "comercial@protecaototal.com.br",
                Endereco = "Avenida da Segurança",
                Bairro = "Protege Center",
                Numero = "1515",
                CNPJ = "89.012.346/0001-67",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Beleza Estilo & Glamour Ltda",
                Telefone = "(21) 9345-6789",
                Email = "agendamento@estiloglamour.com.br",
                Endereco = "Rua da Vaidade",
                Bairro = "Beleza Pura",
                Numero = "1616",
                CNPJ = "90.123.457/0001-78",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Esportes Energia & Ação SA",
                Telefone = "(11) 0456-7890",
                Email = "loja@energiaacao.com.br",
                Endereco = "Avenida dos Esportes",
                Bairro = "Atleta Center",
                Numero = "1717",
                CNPJ = "01.234.568/0001-89",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Informática Soluções Digitais Ltda",
                Telefone = "(31) 1567-8901",
                Email = "suporte@solucoesdigitais.com.br",
                Endereco = "Rua dos Bits",
                Bairro = "Tecno Park",
                Numero = "1818",
                CNPJ = "12.345.680/0001-90",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Agropecuária Terra Fértil SA",
                Telefone = "(65) 2678-9012",
                Email = "vendas@terrafertil.com.br",
                Endereco = "Avenida Rural",
                Bairro = "Campo Verde",
                Numero = "1919",
                CNPJ = "23.456.791/0001-01",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Joalheria Brilho Eterno Ltda",
                Telefone = "(41) 3789-0123",
                Email = "vendas@brilhoeterno.com.br",
                Endereco = "Rua das Pedras",
                Bairro = "Diamante Center",
                Numero = "2020",
                CNPJ = "34.567.892/0001-12",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Brinquedos Alegria Infantil SA",
                Telefone = "(51) 4890-1234",
                Email = "atendimento@alegriainfantil.com.br",
                Endereco = "Avenida da Criança",
                Bairro = "Mundo Infantil",
                Numero = "2121",
                CNPJ = "45.678.903/0001-23",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Livraria Saber & Conhecimento Ltda",
                Telefone = "(71) 5901-2345",
                Email = "contato@saberconhecimento.com.br",
                Endereco = "Rua das Letras",
                Bairro = "Cultura Center",
                Numero = "2222",
                CNPJ = "56.789.014/0001-34",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Decoração Casa & Estilo SA",
                Telefone = "(21) 6012-3456",
                Email = "projetos@casaestilo.com.br",
                Endereco = "Avenida do Design",
                Bairro = "Decor Park",
                Numero = "2323",
                CNPJ = "67.890.125/0001-45",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Perfumaria Aroma Suave Ltda",
                Telefone = "(11) 7123-4567",
                Email = "vendas@aromasuave.com.br",
                Endereco = "Rua dos Perfumes",
                Bairro = "Fragrância Center",
                Numero = "2424",
                CNPJ = "78.901.236/0001-56",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Óticas Visão Clara SA",
                Telefone = "(31) 8234-5678",
                Email = "atendimento@visaoclara.com.br",
                Endereco = "Avenida da Visão",
                Bairro = "Olho Vivo",
                Numero = "2525",
                CNPJ = "89.012.347/0001-67",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Presentes Emoções Especiais Ltda",
                Telefone = "(81) 9345-6789",
                Email = "loja@emocoesespeciais.com.br",
                Endereco = "Rua das Surpresas",
                Bairro = "Presente Park",
                Numero = "2626",
                CNPJ = "90.123.458/0001-78",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Bebidas Artesanais Sabor Único SA",
                Telefone = "(48) 0456-7890",
                Email = "contato@saborunico.com.br",
                Endereco = "Avenida dos Sabores",
                Bairro = "Cervejaria Village",
                Numero = "2727",
                CNPJ = "01.234.569/0001-89",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Materiais de Construção Fortaleza Ltda",
                Telefone = "(85) 1567-8901",
                Email = "vendas@fortalezaconstrucao.com.br",
                Endereco = "Rua dos Tijolos",
                Bairro = "Constru Forte",
                Numero = "2828",
                CNPJ = "12.345.681/0001-90",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Eletrodomésticos Casa Prática SA",
                Telefone = "(27) 2678-9012",
                Email = "sac@casapratica.com.br",
                Endereco = "Avenida dos Eletros",
                Bairro = "Conforto Home",
                Numero = "2929",
                CNPJ = "23.456.792/0001-01",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Pneus Rodagem Segura Ltda",
                Telefone = "(62) 3789-0123",
                Email = "orcamento@rodagemsegura.com.br",
                Endereco = "Rua das Rodas",
                Bairro = "Pneu Center",
                Numero = "3030",
                CNPJ = "34.567.893/0001-12",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Celulares Comunicação Total SA",
                Telefone = "(98) 4890-1234",
                Email = "vendas@comunicacaototal.com.br",
                Endereco = "Avenida dos Aparelhos",
                Bairro = "Mobile Park",
                Numero = "3131",
                CNPJ = "45.678.904/0001-23",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Instrumentos Musicais Harmonia Ltda",
                Telefone = "(71) 5901-2345",
                Email = "contato@harmoniainstrumentos.com.br",
                Endereco = "Rua das Notas",
                Bairro = "Musical Center",
                Numero = "3232",
                CNPJ = "56.789.015/0001-34",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Aquários Vida Marinha SA",
                Telefone = "(21) 6012-3456",
                Email = "loja@vidamarinha.com.br",
                Endereco = "Avenida dos Peixes",
                Bairro = "Aqua Park",
                Numero = "3333",
                CNPJ = "67.890.126/0001-45",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Fitness Academia Corpo Perfeito Ltda",
                Telefone = "(11) 7123-4567",
                Email = "matricula@corpoperfeito.com.br",
                Endereco = "Rua dos Exercícios",
                Bairro = "Health Center",
                Numero = "3434",
                CNPJ = "78.901.237/0001-56",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Fotografia Momentos Únicos SA",
                Telefone = "(31) 8234-5678",
                Email = "agendamento@momentosunicos.com.br",
                Endereco = "Avenida das Lembranças",
                Bairro = "Foto Park",
                Numero = "3535",
                CNPJ = "89.012.348/0001-67",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Bicicletas Pedal Livre Ltda",
                Telefone = "(41) 9345-6789",
                Email = "vendas@pedallivre.com.br",
                Endereco = "Rua das Bicicletas",
                Bairro = "Bike Center",
                Numero = "3636",
                CNPJ = "90.123.459/0001-78",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Relógios Tempo Preciso SA",
                Telefone = "(51) 0456-7890",
                Email = "atendimento@tempopreciso.com.br",
                Endereco = "Avenida do Tempo",
                Bairro = "Relógio Center",
                Numero = "3737",
                CNPJ = "01.234.570/0001-89",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Cafeteria Aroma Intenso Ltda",
                Telefone = "(71) 1567-8901",
                Email = "contato@aromaintenso.com.br",
                Endereco = "Rua do Café",
                Bairro = "Coffee Village",
                Numero = "3838",
                CNPJ = "12.345.682/0001-90",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Tintas Cores Vibrantes SA",
                Telefone = "(21) 2678-9012",
                Email = "vendas@coresvibrantes.com.br",
                Endereco = "Avenida das Cores",
                Bairro = "Pintura Center",
                Numero = "3939",
                CNPJ = "23.456.793/0001-01",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Vidraçaria Transparência Perfeita Ltda",
                Telefone = "(11) 3789-0123",
                Email = "orcamento@transparenciaperfeita.com.br",
                Endereco = "Rua dos Vidros",
                Bairro = "Vidro Park",
                Numero = "4040",
                CNPJ = "34.567.894/0001-12",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Ferragens Fixação Segura SA",
                Telefone = "(31) 4890-1234",
                Email = "sac@fixacaosegura.com.br",
                Endereco = "Avenida dos Parafusos",
                Bairro = "Ferramentas Center",
                Numero = "4141",
                CNPJ = "45.678.905/0001-23",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Floricultura Natureza Viva Ltda",
                Telefone = "(81) 5901-2345",
                Email = "pedidos@naturezaviva.com.br",
                Endereco = "Rua das Flores",
                Bairro = "Garden Center",
                Numero = "4242",
                CNPJ = "56.789.016/0001-34",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Chocolates Doce Tentação SA",
                Telefone = "(12) 6012-3456",
                Email = "vendas@docetentacao.com.br",
                Endereco = "Avenida do Cacau",
                Bairro = "Chocolate Village",
                Numero = "4343",
                CNPJ = "67.890.127/0001-45",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Artesanato Mãos Talentosas Ltda",
                Telefone = "(21) 7123-4567",
                Email = "loja@maostalentosas.com.br",
                Endereco = "Rua do Artesanato",
                Bairro = "Arte Center",
                Numero = "4444",
                CNPJ = "78.901.238/0001-56",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Piscinas Água Cristalina SA",
                Telefone = "(41) 8234-5678",
                Email = "projetos@aguacristalina.com.br",
                Endereco = "Avenida das Piscinas",
                Bairro = "Água Park",
                Numero = "4545",
                CNPJ = "89.012.349/0001-67",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Antiguidades Tempo Passado Ltda",
                Telefone = "(51) 9345-6789",
                Email = "contato@tempopassado.com.br",
                Endereco = "Rua das Relíquias",
                Bairro = "Antique Center",
                Numero = "4646",
                CNPJ = "90.123.460/0001-78",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Acessórios para Veículos Auto Performance SA",
                Telefone = "(71) 0456-7890",
                Email = "vendas@autoperformance.com.br",
                Endereco = "Avenida dos Acessórios",
                Bairro = "Auto Center",
                Numero = "4747",
                CNPJ = "01.234.571/0001-89",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Bombas Hidráulicas Água Forte Ltda",
                Telefone = "(21) 1567-8901",
                Email = "sac@agua-forte.com.br",
                Endereco = "Rua das Bombas",
                Bairro = "Hidráulica Center",
                Numero = "4848",
                CNPJ = "12.345.683/0001-90",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Sistemas de Segurança Alerta Total SA",
                Telefone = "(11) 2678-9012",
                Email = "comercial@alertatotal.com.br",
                Endereco = "Avenida da Vigilância",
                Bairro = "Segurança Park",
                Numero = "4949",
                CNPJ = "23.456.794/0001-01",
                TipoPagamentoId = 1
            },
            new Fornecedor
            {
                Nome = "Máquinas Industriais Produção Plus Ltda",
                Telefone = "(31) 3789-0123",
                Email = "vendas@producaoplus.com.br",
                Endereco = "Rua das Máquinas",
                Bairro = "Industrial Park",
                Numero = "5050",
                CNPJ = "34.567.895/0001-12",
                TipoPagamentoId = 1
            }
        };
        }
    }
}