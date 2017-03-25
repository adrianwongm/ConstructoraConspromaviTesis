using HotelBooking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de SearchUsuario
/// </summary>
public class SearchUsuario
{
    public SearchUsuario()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public SearchUsuario(string page, HotelBookingDataContext context)
    {
        Page = page;
        DataContext = context;
        
    }

    public string Page { get; set; }

    public HotelBookingDataContext DataContext { get; set; }

    public SCPV_Usuario_Empleados VerficaUsuario(string pEmail, string pPassword)
    {
        SCPV_Usuario_Empleados userCliente = null;
        try
        {
          userCliente =   DataContext.SCPV_Usuario_Empleados.Where(p => p.Usuario == pEmail && p.Password == pPassword).FirstOrDefault();
            if(userCliente == null)
            {
                throw new Exception("No existe el usuario");
            }
        }
        catch (Exception)
        {
            throw;
        }
        return userCliente;
    }

    public SCPV_Usuario_Empleados VerficaUsuario2(string pEmail, string pPassword)
    {
        SCPV_Usuario_Empleados userClienteRetorno = null;
        SP_SCPV_Verifica_UsuarioResult userCliente = null;
        try
        {
            userCliente = DataContext.SP_SCPV_Verifica_Usuario(pEmail,pPassword).FirstOrDefault();
            if (userCliente == null)
            {

                throw new Exception("No existe el usuario");
            }
            else{
                userClienteRetorno = DataContext.SCPV_Usuario_Empleados.Where(p => p.Usuario == pEmail).FirstOrDefault();
            }
        }
        catch (Exception)
        {
            throw;
        }
        return userClienteRetorno;
    }
}