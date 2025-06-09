using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_Padaria.Model
{
    public class Estoque_Prod_Padaria
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey(nameof(ProdutoId))]
        public required int ProdutoId { get; set; }
        public Padaria_Produto Produto { get; set; } = null!;
        public required Tipo Tipo { get; set; }
        public required int Quantidade { get; set; }
        public required string? Descricao { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public DateTime Atualizacao { get; set; }
        public string Movimentacao
        {
            get
            {
                return Tipo == Tipo.Entrada ? "Entrada" : "Saída";
            }
        }
    }
}
