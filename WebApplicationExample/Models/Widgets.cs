using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationExample.Models
{
    public class Widget
    {
        public Guid SerialNumber { get; set; }
        public string Description { get; set; }
        public DateTime ManufacturedDate { get; set; }
        public IEnumerable<WidgetPart> Parts { get; set; }
    }
    public class WidgetPart
    {
        public int PartNumber { get; set; }
        public string Description { get; set; }
        public bool IsFunctioning { get; set; }

        public WidgetPart(int partNumber, string description, bool isFunctioning = true)
        {
            PartNumber = partNumber;
            Description = description;
            IsFunctioning = isFunctioning;
        }
    }
}