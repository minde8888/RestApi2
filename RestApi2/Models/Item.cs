using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi2.Models
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
