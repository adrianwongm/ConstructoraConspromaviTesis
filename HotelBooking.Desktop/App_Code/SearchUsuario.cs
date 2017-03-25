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

    public SCPV_Usuario_Empleados verficaUsuario(string pEmail, string pPassword)
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
}