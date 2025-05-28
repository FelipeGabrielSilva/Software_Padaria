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

        [ForeignKey(nameof(ProdutosId))]
        public required List<int> ProdutosId { get; set; }
        public required DateTime Data { get; set; }
        public required Status Status { get; set; }
        public string CPF_CNPJ { get; set; }
        public required decimal Preco { get; set; }

        [ForeignKey(nameof(TipoPagamentoId))]
        public required int TipoPagamentoId { get; set; }
    }
}
