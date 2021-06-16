using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alpha.Entities
{
    public class Correspondencia
    {
        public string Id { get; set; }
        public string Asunto { get; set; }
        public string NombreRemitente { get; set; }
        public int RemitenteId { get; set; }
        public string NombreDestinatario { get; set; }
        public int DestinatarioId { get; set; }
        public int EmpleadoId { get; set; }
        public DateTime FechaCreado { get; set; }
        public DateTime? FechaModificado { get; set; }
        public int ClasificacionId { get; set; }
    }
}
