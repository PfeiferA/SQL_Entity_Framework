using System;
using System.Collections.Generic;

namespace SQL_Entity_Framework
{
   public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Year { get; set; }
        public virtual ICollection<Song> Songs { get; set; }
        public string Type { get; set; }
    }
}
