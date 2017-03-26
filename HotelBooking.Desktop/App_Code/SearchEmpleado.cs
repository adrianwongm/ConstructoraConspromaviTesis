using HotelBooking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de SearchEmpleado
/// </summary>
public class SearchEmpleado
{
    public SearchEmpleado()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
 
    public SearchEmpleado(string page, HotelBookingDataContext context)
    {
        Page = page;
        DataContext = context;

    }

    public string Page { get; set; }

    public HotelBookingDataContext DataContext { get; set; }

    public SCPV_Empleados getEmpleadoByID(int pID_Empleado)
    {
        SCPV_Empleados empleado = null;
        try
        {
            empleado = DataContext.SCPV_Empleados.Where(p => p.ID == pID_Empleado).FirstOrDefault();
        }
        catch (Exception)
        {

            throw;
        }
        return empleado;
    }
}