﻿using System;
using System.Collections.Generic;
using System.Web.UI;

using OdnShop.Core.Common;
using OdnShop.Core.Model;
using OdnShop.Core.Factory;
namespace OdnShop.Web.vshop
{
    public partial class search : OdnShop.Core.PageControler.WebPageBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                int totalcount = 0;
                int pagesize = 10;
                int pageindex = HYRequest.GetQueryInt("p", 1);
                string kw = HYRequest.GetQueryString("kw");
                this.SearchKw = kw;
                string whereSql = string.Empty;

                List<ProductModel> list;
                if (!string.IsNullOrEmpty(kw))
                {
                    whereSql = string.Format(" where productname like '%{0}%' ", kw);
                    list = ProductFactory.GetList(pagesize, pageindex, whereSql, " order by productid desc ", out totalcount);
                }
                else
                {
                    list = ProductFactory.GetList(10, string.Empty);
                }

                this.rptProducts.DataSource = list;
                this.rptProducts.DataBind();

                this.rptAddToCarPopWin.DataSource = list;
                this.rptAddToCarPopWin.DataBind();
            }
        }

        private string _searchkw = string.Empty;
        public string SearchKw
        {
            get { return _searchkw; }
            set { _searchkw = value; }
        }
    }
}