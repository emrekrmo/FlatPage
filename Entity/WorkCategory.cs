using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class WorkCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Work> Works { get; set; }
    }
    public class Work
    {
        public int Id { get; set; }
        public string ImgURL { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
    }
}
