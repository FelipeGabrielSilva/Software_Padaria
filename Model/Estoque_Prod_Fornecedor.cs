using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_Padaria.Model
{

    public class Estoque_Prod_Fornecedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required int Quantidade { get; set; }

        [ForeignKey(nameof(FornecedorId))]
        public required int FornecedorId { get; set; }
        public Fornecedor Fornecedor { get; set; } = null!;

        [ForeignKey(nameof(ProdutoId))]
        public required int ProdutoId { get; set; }
        public Fornecedor_Produto Produto { get; set; } = null!;
        public required Tipo Tipo { get; set; }

        public string Movimentacao
        {
            get
            {
                return Tipo == Tipo.Entrada? "Entrada" : "Saída";
            }
        }
    }
}
