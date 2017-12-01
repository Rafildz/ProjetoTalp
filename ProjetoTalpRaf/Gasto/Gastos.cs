using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTalpRaf.Gasto
{
    class Gastos
    {
        [Key]
        public Int32 IdGastos { get; set; }
        public string Tipo { get; set; }
        public float Preco { get; set; }


    }
}
