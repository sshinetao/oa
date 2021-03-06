﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

namespace OA.aspx.Moa.WorkPlan{ 
 public partial class ManageWorkPlan: System.Web.UI.Page
{
    public List<ERPWorkPlan> EmailList = new List<ERPWorkPlan>();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            FTD.Unit.PublicMethod.CheckSession();
            DataBindToGridview();
        }
    }
    public void DataBindToGridview()
    {
        DataEntityDataContext context = new DataEntityDataContext();
        FTD.BLL.ERPWorkPlan MyLanEmail = new FTD.BLL.ERPWorkPlan();
        var T = context.ERPWorkPlan.Where(p => p.UserName == FTD.Unit.PublicMethod.GetSessionValue("UserName")).OrderByDescending(p => p.ID);
        EmailList = T.ToList();
    }
  
}}