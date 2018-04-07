using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Time_Management
{
    [Serializable]
    public class Work
    {
        
        public string Name { get; set; }
        public string Detail { get; set; }
        public string Recurrence { get; set; }
        public string Category { get; set; }
        public string Important { get; set; }
        public DateTime Date { get; set; }
        public string TimeNotify { get; set; }
        public bool IsNoti { get; set; }

        public Work(string name, string detail, string recurrence, string category, string important, DateTime date, string timeNotify, bool isNoti)
        {
            Name = name;
            Detail = detail;
            Recurrence = recurrence;
            Category = category;
            Important = important;
            Date = date;
            TimeNotify = timeNotify;
            IsNoti = isNoti;
        }

        public Work()
        {
        }
    }
}
