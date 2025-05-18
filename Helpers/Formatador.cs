using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsForm_Padaria.Helpers
{
    public class Formatador
    {
        public static string AplicarMascaraCNPJ(string cnpj)
        {
            cnpj = Regex.Replace(cnpj, "[^0-9]", "");

            if (cnpj.Length == 14)
            {
                cnpj = Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\-00");
            }

            return cnpj;
        }

        public static string AplicarMascaraTelefone(string telefone)
        {
            telefone = Regex.Replace(telefone, "[^0-9]", "");
            
            if (telefone.Length == 10)
            {
                return Regex.Replace(telefone, @"(\d{2})(\d{4})(\d{4})", "($1) $2-$3");
            }

            return telefone;
        }

    }
}
