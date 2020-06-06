using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Buffers;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        //scripture ID
        public int ID { get; set; }

        //Book name
        public string Book { get; set; }

        //Book chapter
        public string Chapter { get; set; }

        //Book verse
        public string Verse { get; set; }

        
        //Pass in the current date to CreatedDate for when the user makes a new note
        public Scripture()
        {
            this.CreatedDate = DateTime.Now;
        }
        //Date notes were created
        [Display(Name = "*Date will automatically get created. You may edit the date from the list page.")]
        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }
        //public DateTime date = DateTime.Now;
        
        //Notes
        public string Notes { get; set; }
        
    }
}
