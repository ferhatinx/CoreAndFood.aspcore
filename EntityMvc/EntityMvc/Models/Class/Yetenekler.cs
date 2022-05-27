using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityMvc.Models.Class
{
    public class Yetenekler
    {
        [Key]
        public int ID { get; set; }
        public string Acıklama { get; set; }
        public byte Deger { get; set; }


    }
}