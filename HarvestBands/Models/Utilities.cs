using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HarvestBands.Models
{

    public enum Division
    {
        Novice, A, AA, AAA_S, AAA_L, Exhibition
    }

    public enum PaidStatus
    {
        Paid, PO_Recieved, Application_Received, Not_Participating
    }

    public enum StaffMemberSchool
    {
        Community, ACDavis, Eisenhower
    }
}