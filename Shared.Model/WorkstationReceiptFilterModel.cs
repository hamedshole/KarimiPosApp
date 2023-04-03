using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Model
{
    public class WorkstationReceiptFilterModel
    {
        public string Workstation { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public WorkstationReceiptFilterModel(string workstation, DateTime startTime, DateTime endTime)
        {
            Workstation = workstation;
            StartTime = startTime;
            EndTime = endTime;
        }
        public WorkstationReceiptFilterModel()
        {

        }
    }
}
