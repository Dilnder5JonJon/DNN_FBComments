using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Web;
using System.IO;
using System.Collections;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using DotNetNuke.Common;
using DotNetNuke.Entities.Users;
using DotNetNuke.UI.Utilities;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Security.Roles;
using DotNetNuke.Services.Localization;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Entities.Modules.Definitions;
using DotNetNuke.Entities.Modules.Communications;

namespace BluidSolutions.Modules.FBComments
{

  public partial class View : DotNetNuke.Entities.Modules.PortalModuleBase 
  {
      string _Mode = "";
      bool _AssumeFBSDK;
      string _NumberOfPosts;
      string _Width;
      string _ColorScheme;
      string _AppID;
	  string _QSP;
    
    protected void Page_Load(object sender, EventArgs e)
    {
        _Mode = (string)Settings["Mode"];
        _AssumeFBSDK = Convert.ToBoolean((string)Settings["AssumeFBSDK"]);
        _NumberOfPosts = (string)Settings["NumberOfPosts"];
        _Width = (string)Settings["Width"];
        _ColorScheme = (string)Settings["ColorScheme"];
        _AppID = (string)Settings["AppID"];
		_QSP = (string)Settings["QSP"];

        if (!_AssumeFBSDK)
        {
            ClientScriptManager CS = Page.ClientScript;
            CS.RegisterStartupScript(this.GetType(), "FBComments_" + ModuleId, GetSDKScript());
        }

        ConfigureModule();
    }

    private string GetSDKScript()
    {
        StringBuilder SB = new StringBuilder();

        SB.Append("<div id=\"fb-root\"></div><script>(function(d, s, id) {  var js, fjs = d.getElementsByTagName(s)[0];  if (d.getElementById(id)) return;  js = d.createElement(s); js.id = id;  js.src = \"//connect.facebook.net/en_US/all.js#xfbml=1&appId=");
        SB.Append(_AppID);
        SB.Append("\";fjs.parentNode.insertBefore(js, fjs);}(document, 'script', 'facebook-jssdk'));</script>");

        return SB.ToString();
    }

    private void ConfigureModule()
    {
        switch ((string)Settings["Mode"])
        {
            case "Page":
                RenderComments();
                break;
            case "DNNBlog":
                if (Request.QueryString["EntryID"] != null)
                {
                    RenderComments();
                }
                break;
            case "Custom":
                if (Request.QueryString[_QSP] != null)
                {
                    RenderComments();
                }
                break;         
        }
    }

    private void RenderComments()
    {
        string CurrentURL = "";

        if (Request.IsSecureConnection)
        {
            CurrentURL = "https://" + Request.Url.Host + Request.RawUrl;
        }
        else
        {
            CurrentURL = "http://" + Request.Url.Host + Request.RawUrl;
        }

        StringBuilder SB = new StringBuilder();

        SB.Append("<div class=\"fb-comments\" data-href=\"" + CurrentURL + "\" data-num-posts=\"" + _NumberOfPosts + "\" data-width=\"" + _Width + "\" data-colorscheme=\"" + _ColorScheme.ToLower() + "\"></div>");

        Literal1.Text = SB.ToString();

    }
  }
}
