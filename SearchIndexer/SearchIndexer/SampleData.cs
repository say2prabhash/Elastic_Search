using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchIndexer
{
    public class SampleData
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public SampleData()
        {
                
        }
        public SampleData(string name,string type,string location)
        {
            Name = name;
            Type = type;
            Location = location;
        }
    }
}
