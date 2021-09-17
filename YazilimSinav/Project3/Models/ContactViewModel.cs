using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Models
{
    public class ContactViewModel
    {
        [Required]
        public string Name { get; set; }

        public List<string> City = new List<string>() { "İstanbul", "İzmir", "Ankara" };

        [Required]
        public string selectedCity { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        [Range(0,120)]
        public int Age { get; set; }


    }
}
