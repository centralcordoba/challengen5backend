namespace apiUserProjectN5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Permisos")]
    public partial class Permiso
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreEmpleado { get; set; }

        [Required]
        [StringLength(100)]
        public string ApellidoEmpleado { get; set; }

        public int TipoPermiso { get; set; }

       
        [StringLength(10)]
        public string FechaPermiso { get; set; }
    }
}
