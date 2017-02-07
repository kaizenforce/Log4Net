using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//Importamos las librerias
using log4net;

public partial class _Default : Page
{

    //Agregaremos la instancia
    private static readonly ILog log = LogManager.GetLogger(typeof(_Default));
    protected void Page_Load(object sender, EventArgs e)
    {
        //Escribiremos una prueba
        log.Debug("Esta es mi captura de LOG");

    }
}

