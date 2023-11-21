using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5.Data
{
    internal class Clients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gosnomer { get; set; }
        public int mobilnuy { get; set; }
        public int GarageId { get; set; }
        public garages garages { get; set; }
    }
}
