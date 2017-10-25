using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBlog.Domain.Model
{
    public class Tag
    {
        public int TagId { get; set; }
        public String Description { get; set; }
        public Post Post { get; set; }
    }
}
