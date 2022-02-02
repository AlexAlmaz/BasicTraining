﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestWebApplication.Models.Tasks;

namespace TestWebApplication.Extentions
{
    public static class WorkItemExtention
    {
        public static WorkItem ToCore(this WorkItemModel model)
        {
            return new WorkItem
            {
                Name = model.Name,
                Description = model.Description,
                Active = model.Active,
                Done = model.Done
            };
        }

        public static WorkItemModel ToDomain(this WorkItem workItem)
        {
            return new WorkItemModel
            {
                Name = workItem.Name,
                Description = workItem.Description,
                Active = workItem.Active,
                Done = workItem.Done
            };
        }
    }
}
