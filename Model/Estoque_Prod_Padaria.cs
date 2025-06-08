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
        public required string Tipo { get; set; }
        public required int Quantidade { get; set; }
        public required DateTime Data { get; set; }
        public required string? Descricao { get; set; }
    }
}
