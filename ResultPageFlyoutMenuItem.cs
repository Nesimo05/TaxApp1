using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxApp1
{
    public class ResultPageFlyoutMenuItem
    {
        public ResultPageFlyoutMenuItem()
        {
            TargetType = typeof(ResultPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}