using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp5.Data
{
    internal class garages
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Clients> Clients { get; set; }
    }
}
