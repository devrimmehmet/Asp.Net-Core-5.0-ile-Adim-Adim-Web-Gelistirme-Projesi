using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EntityLayer.Concrete
{
    public class Experience
    {
        [Key]
        public int ExperienceID { get; set; }

        public string Name { get; set; }

        public string Date { get; set; }

        public string ImageUrl { get; set; }

        public string Description { get; set; }

    }
}
