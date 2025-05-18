using WindowsForm_Padaria.Forms.Cadastro;
using WindowsForm_Padaria.Model;

namespace WindowsForm_Padaria
{
    public class Validacao
    {
        public ResultadoValidacao Categoria(Categoria c)
        {
            var res = new ResultadoValidacao();

            if (c == null)
            {
                res.Erros.Add(nameof(c));
                return res;
            }

            if (string.IsNullOrWhiteSpace(c.Nome))
                res.Erros.Add("Nome da categoria é obrigatório.");

            return res;
        }

        public ResultadoValidacao Estoque_Prod_Fornecedor(Estoque_Prod_Fornecedor e) 
        {
            var res = new ResultadoValidacao();
        
            if (e == null)
            {
                res.Erros.Add(nameof(e));
                return res;
            }

            if (string.IsNullOrWhiteSpace(Convert.ToString(e.ProdutoId))) 
                res.Erros.Add("O produto deve ser selecionado e é obrigatório.");

            if (string.IsNullOrWhiteSpace(Convert.ToString(e.FornecedorId)))
                res.Erros.Add("O fornecedor deve ser selecionado e é obrigatório.");

            if (string.IsNullOrWhiteSpace(Convert.ToString(e.Quantidade)))
                res.Erros.Add("Quantidade é obrigatória."); 

            return res;
        }

        public ResultadoValidacao Estoque_Prod_Padaria(Estoque_Prod_Padaria e) 
        {
            var res = new ResultadoValidacao();

            if (e == null)
            {
                res.Erros.Add(nameof(e));
                return res;
            }

            if (string.IsNullOrWhiteSpace(Convert.ToString(e.ProdutoId)))
                res.Erros.Add("Produto deve ser selecionado e é obrigatório.");

            if (string.IsNullOrWhiteSpace(e.Descricao))
                res.Erros.Add("Descrição é obrigatória.");

            if (string.IsNullOrWhiteSpace(Convert.ToString(e.Quantidade)))
                res.Erros.Add("Quantidade é obrigatória.");

            return res;
        }

        public ResultadoValidacao Fornecedor(Fornecedor f)
        {
            var res = new ResultadoValidacao();

            if (f == null)
            {
                res.Erros.Add(nameof(f));
                return res;
            }

            if (string.IsNullOrWhiteSpace(f.Nome))
                res.Erros.Add("Nome do fornecedor é obrigatório.");

            if (string.IsNullOrWhiteSpace(f.Email))
                res.Erros.Add("E-mail do fornecedor é obrigatório.");

            if (string.IsNullOrWhiteSpace(f.Telefone))
                res.Erros.Add("Telefone do fornecedor é obrigatório.");

            if (string.IsNullOrWhiteSpace(f.Endereco))
                res.Erros.Add("Endereco do fornecedor é obrigatório.");

            if (string.IsNullOrWhiteSpace(f.Bairro))
                res.Erros.Add("Bairro do fornecedor é obrigatório.");

            if (string.IsNullOrWhiteSpace(f.Numero))
                res.Erros.Add("Número do fornecedor é obrigatório.");

            if (string.IsNullOrWhiteSpace(f.CNPJ))
                res.Erros.Add("CNPJ do fornecedor é obrigatório.");

            if (string.IsNullOrWhiteSpace(Convert.ToString(f.TipoPagamentoId)))
                res.Erros.Add("Tipo de pagamento do fornecedor é obrigatório.");

            return res;
        }

        public ResultadoValidacao Fornecedor_Produto(Fornecedor_Produto f) 
        {
            var res = new ResultadoValidacao();

            if (f == null)
            {
                res.Erros.Add(nameof(f));
                return res;
            }

            if (string.IsNullOrWhiteSpace(f.Nome))
                res.Erros.Add("O nome é obrigatório.");
            
            if (string.IsNullOrWhiteSpace(f.Descricao))
                res.Erros.Add("A descrição é obrigatória.");

            if (string.IsNullOrWhiteSpace(Convert.ToString(f.Codigo)))
                res.Erros.Add("O código para produto é obrigatório.");

            return res;
        }

        public ResultadoValidacao Padaria_Prod_Receita(Padaria_Prod_Receita p) 
        {
            var res = new ResultadoValidacao();

            if (p == null)
            {
                res.Erros.Add("Objeto Padaria_Prod_Receita não pode ser nulo.");
                return res;
            }

            if (p.ReceitaId <= 0)
                res.Erros.Add("ReceitaId deve ser maior que zero.");

            if (p.Receita == null)
                res.Erros.Add("Receita associada é obrigatória.");

            if (p.ProdutoId <= 0)
                res.Erros.Add("ProdutoId deve ser maior que zero.");

            if (p.Produto == null)
                res.Erros.Add("Produto associado é obrigatório.");

            return res;
        }

        public ResultadoValidacao Padaria_Produto(Padaria_Produto p) 
        {
            var res = new ResultadoValidacao();

            if (p == null)
            {
                res.Erros.Add("Objeto produto não pode ser nulo.");
                return res;
            }

            if (string.IsNullOrWhiteSpace(p.Nome))
                res.Erros.Add("Nome do produto é obrigatório.");

            if (string.IsNullOrWhiteSpace(p.Descricao))
                res.Erros.Add("Descrição do produto é obrigatória.");

            if (p.Preco <= 0)
                res.Erros.Add("Preço do produto deve ser maior que zero.");

            if (p.CategoriaId <= 0 || p.Categoria == null)
                res.Erros.Add("Categoria do produto é obrigatória.");

            return res;
        }

        public ResultadoValidacao Pagamento(Pagamento p) 
        {
            var res = new ResultadoValidacao();

            if (p == null)
            {
                res.Erros.Add("Objeto pagamento não pode ser nulo.");
                return res;
            }

            if (string.IsNullOrWhiteSpace(p.Descricao))
                res.Erros.Add("Descrição do pagamento é obrigatória.");

            return res;
        }

        public ResultadoValidacao Produto_Receita(Produto_Receita p) 
        {
            var res = new ResultadoValidacao();

            if (p == null)
            {
                res.Erros.Add("Objeto Produto_Receita não pode ser nulo.");
                return res;
            }

            if (p.ProdutoId <= 0)
                res.Erros.Add("ProdutoId deve ser maior que zero.");

            if (p.Produto == null)
                res.Erros.Add("Produto do fornecedor é obrigatório.");

            if (p.ReceitaId <= 0)
                res.Erros.Add("ReceitaId deve ser maior que zero.");

            if (p.Receita == null)
                res.Erros.Add("Receita associada é obrigatória.");

            return res;
        }

        public ResultadoValidacao Receita(Receita r) 
        {
            var res = new ResultadoValidacao();

            if (r == null)
            {
                res.Erros.Add("Objeto receita não pode ser nulo.");
                return res;
            }

            if (string.IsNullOrWhiteSpace(r.Nome))
                res.Erros.Add("Nome da receita é obrigatório.");

            if (string.IsNullOrWhiteSpace(r.Descricao))
                res.Erros.Add("Descrição da receita é obrigatória.");

            return res;
        }

        public ResultadoValidacao Venda(Venda v) 
        {
            var res = new ResultadoValidacao();

            if (v == null)
            {
                res.Erros.Add("Objeto venda não pode ser nulo.");
                return res;
            }

            if (string.IsNullOrWhiteSpace(v.CPF_CNPJ))
                res.Erros.Add("CPF ou CNPJ é obrigatório.");

            if (v.Preco <= 0)
                res.Erros.Add("Preço da venda deve ser maior que zero.");

            if (v.TipoPagamentoId <= 0 || v.TipoPagamento == null)
                res.Erros.Add("Tipo de pagamento é obrigatório.");

            if (!Enum.IsDefined(typeof(Status), v.Status))
                res.Erros.Add("Status da venda inválido.");

            return res;
        }

        public ResultadoValidacao Venda_Produto(Venda_Produto v) 
        {
            var res = new ResultadoValidacao();

            if (v == null)
            {
                res.Erros.Add("Objeto Venda_Produto não pode ser nulo.");
                return res;
            }

            if (v.ProdutoId <= 0)
                res.Erros.Add("ProdutoId deve ser maior que zero.");

            if (v.Produto == null)
                res.Erros.Add("Produto associado à venda é obrigatório.");

            if (v.VendaId <= 0)
                res.Erros.Add("VendaId deve ser maior que zero.");

            if (v.Venda == null)
                res.Erros.Add("Venda associada é obrigatória.");

            return res;
        }
    }
}