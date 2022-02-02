using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IWorkItemRepository
    {
        public void AddWorkItem(WorkItem workItem);
        public List<WorkItem> GetWorkItems();
    }
}
