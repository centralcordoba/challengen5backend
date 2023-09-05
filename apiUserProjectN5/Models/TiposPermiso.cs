namespace apiUserProjectN5.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TiposPermisos")]
    public partial class TiposPermiso
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
