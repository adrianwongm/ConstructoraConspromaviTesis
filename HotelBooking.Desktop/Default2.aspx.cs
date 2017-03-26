using HotelBooking;
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


    public List<HotelBooking.SCPV_Empleados> listadoEmpleados
    {
        get
        {
            return (List<HotelBooking.SCPV_Empleados>)Session["listadoEmpleados"];
        }
        set
        {
            Session["listadoEmpleados"] = value;
        }
    }



    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            cargaInicialDatosUsuarios();
            cargaCombos();
        }
        catch (Exception)
        {

            throw;
        }
    }

    private void cargaCombos()
    {
        SearchEmpleado oSearchEmpleado = new SearchEmpleado(this.ToString(), new HotelBooking.HotelBookingDataContext());
        listadoEmpleados = oSearchEmpleado.getListEmpleado("A");
        this.cmbEmpleado.DataSource = listadoEmpleados;
        this.cmbEmpleado.DataBind();
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

    protected void grdListadoUsuarios_CustomCallback(object sender, DevExpress.Web.ASPxGridViewCustomCallbackEventArgs e)
    {
        try
        {
            if (e.Parameters == "Grabar")
            {
                SearchUsuario userGrabar = new SearchUsuario(this.ToString(), new HotelBooking.HotelBookingDataContext());
                SCPV_Usuario_Empleados user = new SCPV_Usuario_Empleados();
                user.Usuario = this.txtUsuario.Text;
                user.Password = this.txtPassword.Text;
                user.Estado = this.cmbEstado.Value.ToString();
                user.ID_Empleado = int.Parse(this.cmbEmpleado.Value.ToString());
                userGrabar.addUsuario(user);
                cargaInicialDatosUsuarios();
            } 
        }
        catch (Exception)
        {

            throw;
        }
    }
}