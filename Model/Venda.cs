using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_Padaria.Model
{
    public enum Status
    {
        Realizada,
        Pendente,
        Cancelada,
    }
    public class Venda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public ICollection<Venda_Produto> VendaProdutos { get; set; } = new List<Venda_Produto>();
        public required DateTime Data { get; set; }
        public required Status Status { get; set; }
        public string? CPF_CNPJ { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public required decimal Preco { get; set; }

        [ForeignKey(nameof(TipoPagamentoId))]
        public required int TipoPagamentoId { get; set; }
        public Pagamento Pagamento { get; set; } = null!;

        public string NomeProduto
        {
            get
            {
                if (VendaProdutos == null || !VendaProdutos.Any())
                {
                    return "Nenhum produto";
                }

                return string.Join(", ", VendaProdutos.Select(vp => vp.Produto?.Nome ?? "Produto desconhecido"));
            }
        }
    }
}
