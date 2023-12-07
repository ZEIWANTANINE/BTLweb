using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BTLweb
{
    public partial class Dangnhap : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session["IncorrectAttempts"] = 0;
                Session["IsAccountLocked"] = false;
            }

        }
        protected void DangNhap_onClick(object sender, EventArgs e)
        {
            var listMember = Application[Global.MEMBER_LIST] as List<Member>;

            //string user = Request.Form[""];
            string phone = Request.Form["sdt"];
            string pass = Request.Form["matkhau"];
           
            if (IsPostBack)
            {
                foreach (Member member in listMember)
                {
                    if (member.MemberName == phone && member.password == pass)

                    {
                        //Session["sdt"] = phone;
                        //Session["hoten"] = userName;
                        Session[Global.MEMBER] = member;
                        Response.Redirect("Trangchu.aspx");
                    }
                    else
                    {
                        error.InnerHtml = "ERROR: Wrong phone number or password!";
                    }
                }
            }
        }
        }

    }
