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
        private string description;
        private int points;
        
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

        public string GetDescription()
        {
            return description;
        }

        public void SetDescription(string aDescription)
        {
            description = aDescription;
        }

        public void SetPoints(int aPoint)
        {
            if (aPoint < 1)
            {
                throw new ArgumentException("SetPoints: Number of points has to be greater or equale than 1", "aPoint");
            }
            else
            {
                points = aPoint;
            }
        }

        public int GetPoints()
        {
            return points;
        }

        public TaskModel()
        {
            
        }
    }
}