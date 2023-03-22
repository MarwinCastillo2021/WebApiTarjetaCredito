using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;   
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiTarjetaCredito.Models
{

    public class TarjetaCredito
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string Titular { get; set; }

        [Required]
        [Column(TypeName = "varchar(16)")]
        public string NumeroTarjeta { get; set; }

        [Required]
        [Column(TypeName = "varchar(5)")]
        public string FechaExpiracion { get; set; }

        [Required]
        [Column(TypeName = "varchar(3)")]
        public string CW { get; set; }
        
    }

}