using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeamOrganizer.Models
{
    public enum Statuses
    {
        New,
        ToDo,
        InProgress,
        Done,
        Closed
    };

    public class TaskModel
    {
        private int taskId;
        private Statuses status;
        
        
        public int GetId()
        {
            return taskId;
        }
        public void SetId(int aTaskId)
        {
            taskId = aTaskId;
        }

        public string GetStatus()
        {
            return status.ToString();
        }

        public bool SetStatus(string aStatus)
        {
            return Enum.TryParse(aStatus, out status);
        }

        public TaskModel()
        {
            
        }
    }
}