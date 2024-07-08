using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPrApprover.Models
{
    public class BodyModel : BaseModel
    {
        public bool HasDeclined { get; set; }
        public int Vote { get; set; }
    }
}
