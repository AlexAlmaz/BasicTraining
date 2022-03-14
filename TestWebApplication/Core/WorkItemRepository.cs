using Domain;
using Domain.Interfaces;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Core
{
    public class WorkItemRepository : IWorkItemRepository
    {
        private static List<WorkItem> _workItems { get; set; }
        private static List<WorkItem> workItems { get => (_workItems ?? (_workItems = new List<WorkItem>())); }

        public void AddWorkItem(WorkItem workItem)
        {
            workItem.Id = workItems.Count() + 1;
            workItems.Add(workItem);
        }

        public List<WorkItem> GetWorkItems()
        {
            return workItems;
        }
    }
}
