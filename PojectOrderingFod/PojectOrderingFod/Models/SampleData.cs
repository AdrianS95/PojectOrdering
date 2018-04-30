using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PojectOrderingFod.Models
{
    public class SampleData
    {


    }

    public class RestData
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Descryption { get; set; }
        public string ImmageLink { get; set; }
        public string Link { get; set; }

        public RestData(int id, string name, string description, string immageLink, string link)
        {
            ID = id;
            Name = name;
            Descryption = description;
            ImmageLink = immageLink;
            Link = link;
        }
    }
}
