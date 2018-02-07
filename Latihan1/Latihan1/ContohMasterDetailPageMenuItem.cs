using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan1
{

    public class ContohMasterDetailPageMenuItem
    {
        public ContohMasterDetailPageMenuItem()
        {
            TargetType = typeof(ContohMasterDetailPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}