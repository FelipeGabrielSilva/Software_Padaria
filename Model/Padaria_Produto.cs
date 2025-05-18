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
        public required float Preco { get; set; }
        public required int CategoriaId { get; set; }
        public required Categoria Categoria { get; set; }
    }
}
