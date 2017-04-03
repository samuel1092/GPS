using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GPS_Boxito.Models
{
    public class Sucursal
    {
        [Key]
        public int id_sucursal { get; set; }

        public string nombre { get; set; }
        public string region  { get; set; }
        public bool reparto { get; set; }
        public string latitud { get; set; }
        public string longitud { get; set; }
    }
}