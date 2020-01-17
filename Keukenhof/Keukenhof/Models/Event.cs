using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Keukenhof.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string Naam  { get; set; }
        public string Omschrijving { get; set; }
        public string Datum { get; set; }
        public string FotoURL { get; set; }
    }
}