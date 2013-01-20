using System;

using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DotNetNuke.Web;
using DotNetNuke.Common;
using DotNetNuke.Web.UI;
using DotNetNuke.Framework;
using DotNetNuke.Web.UI.WebControls;

using DotNetNuke.Security;
using DotNetNuke.Security.Permissions;
using DotNetNuke.Services.FileSystem;

namespace BluidSolutions.Modules.FBComments
{

    public partial class Settings : DotNetNuke.Entities.Modules.ModuleSettingsBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public override void LoadSettings()
        {
            if (!Page.IsPostBack)
            {
                DDL_Mode.Text = (string)Settings["Mode"];
                CB_AssumeFBSDK.Checked = Convert.ToBoolean((string)Settings["AssumeFBSDK"]);
                TB_NumberOfPosts.Text = (string)Settings["NumberOfPosts"];
                TB_Width.Text = (string)Settings["Width"];
                DDL_ColorScheme.Text = (string)Settings["ColorScheme"];
                TB_AppID.Text = (string)Settings["AppID"];
				TB_QSP.Text = (string)Settings["QSP"];                
            }
        }

        public override void UpdateSettings()
        {
            DotNetNuke.Entities.Modules.ModuleController MC = new DotNetNuke.Entities.Modules.ModuleController();

            MC.UpdateModuleSetting(ModuleId, "Mode", DDL_Mode.Text);
            MC.UpdateModuleSetting(ModuleId, "AssumeFBSDK", Convert.ToString(CB_AssumeFBSDK.Checked));
            MC.UpdateModuleSetting(ModuleId, "NumberOfPosts", TB_NumberOfPosts.Text);
            MC.UpdateModuleSetting(ModuleId, "Width", TB_Width.Text);
            MC.UpdateModuleSetting(ModuleId, "ColorScheme", DDL_ColorScheme.Text);
            MC.UpdateModuleSetting(ModuleId, "AppID", TB_AppID.Text);
			MC.UpdateModuleSetting(ModuleId, "QSP", TB_QSP.Text);
        }
    }
}
