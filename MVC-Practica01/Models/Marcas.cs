using System.ComponentModel.DataAnnotations;

namespace MVC_Practica01.Models
{
    public class Marcas
    {
        [Key]
        [Display(Name = "ID")]
        public int Id_marcas { get; set; }

        [Display(Name = "Nombre de la Marca")]
        public string? nombre_marcas { get; set; }

        [Display(Name = "Estado")]
        public string? estado { get; set; }

    }
}
