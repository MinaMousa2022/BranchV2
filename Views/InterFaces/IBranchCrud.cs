﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branch_project.Views.InterFaces
{
    internal interface IBranchCrud
    {

         string branchName_Txt { get; set; }
        string branchEName_Txt { get; set; }
        string currid_Txt { get; set; }
        string manager_Txt { get; set; }
        string emanager_Txt { get; set; }
        string address_Txt { get; set; }


        string eaddress_Txt { get; set; }
        string tel1_Txt { get; set; }
        string tel2_Txt { get; set; }

        string fax_Txt { get; set; }

        string email_Txt { get; set; }
        string companyid_Txt { get; set; }







    }
}
