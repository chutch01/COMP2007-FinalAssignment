﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using COMP2007_FInalAssignment;

namespace COMP2007_FInalAssignment.SkillChart_PrestiegeClass_Race_Table1
{
    public partial class Default : System.Web.UI.Page
    {
		protected COMP2007_FInalAssignment.DefaultConnection _db = new COMP2007_FInalAssignment.DefaultConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // Model binding method to get List of SkillChart_PrestiegeClass_Race_Table entries
        // USAGE: <asp:ListView SelectMethod="GetData">
        public IQueryable<COMP2007_FInalAssignment.SkillChart_PrestiegeClass_Race_Table> GetData()
        {
            return _db.SkillChart_PrestiegeClass_Race_Table;
        }
    }
}

