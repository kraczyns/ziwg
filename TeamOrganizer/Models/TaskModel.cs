using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using System.Text.RegularExpressions;

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

    public enum Jednostki
    {
        h = 1,
        d = 24*h,
        w = 7*d
    }

    public class TaskModel
    {
        private int taskId;
        private Statuses status;
        private string description;
        private int points;
        private DateTime startDate, endDate;

        private DateTime SetDate(string data)
        {
            IFormatProvider culture = new CultureInfo("de-DE", true);
            return DateTime.Parse(data, culture, DateTimeStyles.AssumeLocal);
        }

        public void SetStartDate(string data)
        {
            startDate = SetDate(data);
        }

        public void SetStartDate(string data, string czasTrwania)
        {
            startDate = SetDate(data);
            const string pattern = "(\\d+)(\\w)";
            Match match = Regex.Match(czasTrwania, pattern);
            Jednostki jednostka;
            Enum.TryParse(match.Groups[2].Value, out jednostka);
            int ilosc = Int32.Parse(match.Groups[1].Value) * (int)jednostka;
            endDate = startDate.Add(new TimeSpan(ilosc, 0, 0));
        }

        public string GetStartDate()
        {
            return startDate.ToString("dd.MM.yyyy HH:mm");
        }

        public void SetEndDate(string data)
        {
            endDate = SetDate(data);
        }

        public string GetEndDate()
        {
            return endDate.ToString("dd.MM.yyyy HH:mm");
        }

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
            CultureInfo.CurrentCulture = new CultureInfo("pl-pl", true);
        }
    }
}