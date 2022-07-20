using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebProjesi.Models.Classes
{
    public class Icons
    {
        [Key]
        public int ID { get; set; }
        public string IconName { get; set; }
        public string Link { get; set; }
    }
}