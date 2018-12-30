using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vilticket.Models
{
    [Table("Grupo")]
    public class Grupo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Usuario> Usuario { get; set; }

    }
}
