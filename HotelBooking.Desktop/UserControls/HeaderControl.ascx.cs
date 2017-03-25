using HotelBooking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControls_HeaderControl : System.Web.UI.UserControl
{
    public SearchUsuario Usuario { get; set; }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLoginNow_Click(object sender, EventArgs e) {
        if(Captcha.IsValid)
            LogonControl.ShowOnPageLoad = false;
        //Carga de controles
        Usuario = new SearchUsuario(this.ToString(), new HotelBooking.HotelBookingDataContext());
        SCPV_Usuario_Empleados user  = Usuario.verficaUsuario(this.txtEmail.Text.Trim(), this.txtPassword.Text.Trim());
        Session["userCliente"] = user.Usuario;


    }
}
