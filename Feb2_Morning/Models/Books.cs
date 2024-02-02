using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Feb2_Morning.Models
{
    [Table("Books")]
    public class Books
    {
        [Key]
        public int Id { get; set; }
        public string Bname {  get; set; }
        public string Title { get; set; }
        public double price {  get; set; }

    }
}