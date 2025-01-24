using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace film_zad.Models
{
    public class Film
    {
        [Key]
        public int Id { get; set; }

        [Column (TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Description { get; set; }

        [Column(TypeName = "int")]
        public int Price { get; set; }

        public int KategoriaId { get; set; }
        public Kategoria Kategoria { get; set; }
    }
}

