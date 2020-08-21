namespace Practica8Unidad2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Estudiante")]
    public partial class Estudiante
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage ="El nombre no debe estar en blanco")]
        [MinLength(3,ErrorMessage ="El nombre debe tener minimo 3 caracteres")]
        public string Nombres { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage ="El apellido no debe estar en blanco")]
        public string Apellidos { get; set; }

        public DateTime? FechaInscripcion { get; set; }
    }
}
