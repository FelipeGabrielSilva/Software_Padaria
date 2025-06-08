using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_Padaria.Model
{
    public class Padaria_Prod_Receita
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey(nameof(ReceitaId))]
        public required int ReceitaId { get; set; }
        public Receita Receita { get; set; } = null!;

        [ForeignKey(nameof(ProdutoId))]
        public required int ProdutoId { get; set; }
        public Padaria_Produto Produto { get; set; } = null!;
    }
}
