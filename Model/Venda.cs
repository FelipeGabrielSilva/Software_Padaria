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
        public required DateTime Data { get; set; }
        public required Status Status { get; set; }
        public required string CPF_CNPJ { get; set; }
        public required float Preco { get; set; }
        public required int TipoPagamentoId { get; set; }
        public required Pagamento TipoPagamento { get; set; }
    }
}
