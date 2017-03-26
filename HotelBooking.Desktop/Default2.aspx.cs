using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    public List<HotelBooking.SCPV_Usuario_Empleados> listadoUsuarioEmpleados
    {
        get
        {
            return (List<HotelBooking.SCPV_Usuario_Empleados>)Session["listadoUsuarios"];
        }
        set
        {
            Session["listadoUsuarios"] = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            cargaInicialDatosUsuarios();
        }
        catch (Exception)
        {

            throw;
        }
    }

    private void cargaInicialDatosUsuarios()
    {
        SearchUsuario oSearchUsuario = new SearchUsuario(this.ToString(), new HotelBooking.HotelBookingDataContext());
        listadoUsuarioEmpleados = oSearchUsuario.getListEmpleadosByEmpresa(1,"A");
        this.grdListadoUsuarios.DataSource = listadoUsuarioEmpleados;
        this.grdListadoUsuarios.DataBind();
    }



    protected void grdListadoUsuarios_DataBinding(object sender, EventArgs e)
    {
        try
        {
            this.grdListadoUsuarios.DataSource = listadoUsuarioEmpleados;
        }
        catch (Exception)
        {

            throw;
        }
    }
}