namespace Practica8Unidad2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inscripcion")]
    public partial class Inscripcion
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El codigo del curso no debe estar en blanco")]
        public int? CursoId { get; set; }

        [Required(ErrorMessage ="Debe especificar un codigo de estudiante")]
        public int? EstudianteId { get; set; }

        [Required(ErrorMessage ="El semestre no debe estar en blanco")]
        public int? Semestre { get; set; }
    }
}
