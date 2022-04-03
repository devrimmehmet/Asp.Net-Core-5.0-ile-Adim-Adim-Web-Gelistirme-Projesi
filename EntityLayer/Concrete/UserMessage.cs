using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class UserMessage
    {
        [Key]
        public int MessageID { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime Date { get; set; }

        public bool Status { get; set; }

        public int UserID { get; set; }

        public User User { get; set; }

        public List<UserMessage> UserMessages { get; set; }
    }
}
