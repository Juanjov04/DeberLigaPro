using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DeberLigaPro.Models
{
    public class Equipo
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public int Titulos { get; set; }
        public bool AceptaExtranjeros { get; set; }
        public Estadio Estadio { get; set; }
        [ForeignKey(nameof(Estadio))]
        public int EstadioId { get; set; }

    }
}
