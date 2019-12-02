using System.Collections.Generic;

namespace SportHub.ViewModels
{
    public class SportFormViewModel
    {
        public string  Complex { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Type { get; set; }
        public List<Models.Type> Types { get; internal set; }
       
    }
}