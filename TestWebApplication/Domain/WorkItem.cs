using System;

namespace Domain
{
    public class WorkItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public bool Done { get; set; }
    }
}
