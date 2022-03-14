using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace EntityLayer
{
    public class Feature
    {
        [Key]
        public int FeatureID { get; set; }

        public string Header { get; set; }

        public string Name { get; set; }    

        public string Title { get; set; } 
    }
}
