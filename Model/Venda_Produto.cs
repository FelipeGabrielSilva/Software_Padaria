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
        public required int ProdutoId { get; set; }
        public required int VendaId { get; set; }
        public required int Quantidade { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public required decimal PrecoUnitario { get; set; }
        public required Padaria_Produto Produto { get; set; } = null!;
        public required CVenda Venda { get; set; } = null!;
    }
}
