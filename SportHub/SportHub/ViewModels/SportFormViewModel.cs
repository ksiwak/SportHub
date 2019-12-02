using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using SportHub.Models;

namespace SportHub.ViewModels
{
    public class SportFormViewModel
    {
        public string  Complex { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Type { get; set; }
        public List<Models.Type> Types { get; internal set; }
       //  public IEnumerable <Type> Types { get; set; }
    }
}