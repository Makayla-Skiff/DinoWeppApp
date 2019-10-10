using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DinoWebApp1._0.Data
{
    public class Dinos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int DID { get; set; }
        public string DinoName { get; set; }

        public int Eid { get; set; }

        [ForeignKey("EID")]
        public Exhibits ExID { get; set; }
    }

}
