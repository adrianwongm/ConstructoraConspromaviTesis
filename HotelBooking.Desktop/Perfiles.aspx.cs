using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Perfiles : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {

    }

    protected void btnGrabar_Click(object sender, EventArgs e)
    {

    }

    protected void btnModificar_Click(object sender, EventArgs e)
    {

    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {

    }

    protected void ASPxGridView1_CustomCallback(object sender, DevExpress.Web.ASPxGridViewCustomCallbackEventArgs e)
    {

    }

    protected void ASPxGridView1_DataBinding(object sender, EventArgs e)
    {

    }

    protected void ASPxGridView1_RowDeleting(object sender, DevExpress.Web.Data.ASPxDataDeletingEventArgs e)
    {

    } 

    protected void btnEditar_Init(object sender, EventArgs e)
    {
        try
        {
            ASPxButton button = (ASPxButton)sender;
            GridViewDataItemTemplateContainer container = button.NamingContainer as GridViewDataItemTemplateContainer;
            int codigo = Convert.ToInt32(container.KeyValue);
            button.ClientSideEvents.Click = String.Format("function(s, e) {{ editar('{0}','{1}'); }}", codigo.ToString(), container.VisibleIndex);
        }
        catch (Exception ex)
        {
           // funcionControlErrores(ex.Message + " -TRACE: " + ex.StackTrace);
        }
    }

}