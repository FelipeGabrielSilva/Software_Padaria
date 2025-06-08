using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_Padaria.Model
{
    public class Fornecedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Nome { get; set; }
        public required string Telefone { get; set; }
        public required string Email { get; set; }
        public required string Endereco { get; set; }
        public required string Bairro { get; set; }
        public required string Numero { get; set; }
        public required string CNPJ { get; set; }
        [ForeignKey(nameof(TipoPagamentoId))]
        public required int TipoPagamentoId { get; set; }
        public Pagamento Pagamento { get; set; }
    }
}
