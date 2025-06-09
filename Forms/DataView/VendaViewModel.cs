using System;
using System.Linq; // Para string.Join
using System.Collections.Generic; // Para ICollection

namespace WindowsForm_Padaria.ViewModels
{
    public class VendaViewModel
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; } 
        public string CPF_CNPJ { get; set; }
        public decimal PrecoTotal { get; set; } 
        public string TipoPagamento { get; set; } 
        public string ProdutosNaVenda { get; set; } 
    }
}