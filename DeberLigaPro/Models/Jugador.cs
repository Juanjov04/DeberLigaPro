using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DeberLigaPro.Models
{
    public class Jugador
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        public int Edad { get; set; }
        [ForeignKey(nameof(Equipo))]
        public int EquipoId { get; set; }
    }
}
