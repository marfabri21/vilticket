using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Vilticket.Models
{
    public class Ticket
    {

        public int Id { get; set; }
        public string Asunto { get; set; }
        public string Detalle { get; set; }        
        public DateTime FechaCreacion { get { return DateTime.Now; } set {} }
        public TimeSpan TiempoTranscurrido { get; set; }
        public int IdEstado { get; set; }
        [ForeignKey("IdEstado")]
        public Estado Estado { get; set; }
    }
}
