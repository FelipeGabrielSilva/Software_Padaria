using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_Padaria.Model
{
    public class Padaria_Produto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Codigo { get; set; }
        public required string Nome { get; set; }
        public required string Descricao { get; set; }

        [Column(TypeName = "decimal(9,2)")]
        public required decimal Preco { get; set; }

        [ForeignKey(nameof(CategoriaId))]
        public required int CategoriaId { get; set; }
        public Categoria Categoria { get; set; } = null!;
    }
}
