using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTalpRaf.Cliente
{
    class Cliente
    {
        [Key]
        public Int32 IdCliente { get; set; }
        public string Nome { get; set; }
        public Int32 Telefone { get; set; }
        public string Email { get; set; }
    }
}
