using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamTask.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string TvName { get; set; }
        public string LabName { get; set; }
        public string CardName { get; set; }
        public string TvInformation { get; set; }
        public string LabInformation { get; set; }
        public string CardInformation { get; set; }
        public string TvText { get; set; }
        public string LabText { get; set; }
        public string CardText { get; set; }
        public bool IsDeleted { get; set; }
    }
}
