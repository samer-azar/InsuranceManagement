using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceManagement.Winforms.Common
{
    public class Enumerations
    {
        public enum _ClaimStatus
        {
            NotCovered = 0,
            Covered = 1,
            Pending = 2,
            Unprocessed = -1
        }

        public enum _ErrorCodes
        {
            InvalidInput = 10001,
            BadRequest = 10002,
            ConnectionInterrupted = 10003
        }


    }
}
