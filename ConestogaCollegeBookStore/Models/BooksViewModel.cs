using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConestogaCollegeBookStore.Models
{
    public class BooksViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Program { get; set; }
        public decimal Price { get; set; }
    }
}
