using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_Scripture_Journal.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        public string StandardWork { get; set; }
        public string Book { get; set; }
        public int Chapter { get; set; }
        public string Verses { get; set; }
        public String Note { get; set; }
        public String Passage { get; set; }

        [DataType(DataType.DateTime)]
        public String dateAdded = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

        public String DateAdded { get => dateAdded; set => dateAdded = value; }
    }
}
