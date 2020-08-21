namespace Practica8Unidad2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Curso")]
    public partial class Curso
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage ="La descripcion no debe estar en blanco")]
        [MinLength(5,ErrorMessage ="La descripcion debe tener minimo 5 caracteres")]
        public string Descripcion { get; set; }
    }
}
