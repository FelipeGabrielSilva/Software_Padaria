using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_Padaria.Model
{
    public class Venda_Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public required int ProdutoId { get; set; }
        [Required]
        public required int VendaId { get; set; }
        public required int Quantidade { get; set; }
        public required float PrecoUnitario { get; set; }
        [ForeignKey(nameof(ProdutoId))]
        public required Padaria_Produto Produto { get; set; }
        [ForeignKey(nameof(VendaId))]
        public required Venda Venda { get; set; }
    }
}
