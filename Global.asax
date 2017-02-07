<%@ Application Language="C#" %>
<%@ Import Namespace="Log4Net" %>
<%@ Import Namespace="System.Web.Optimization" %>
<%@ Import Namespace="System.Web.Routing" %>
<%@ Import Namespace="System.IO" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e)
    {
        RouteConfig.RegisterRoutes(RouteTable.Routes);
        BundleConfig.RegisterBundles(BundleTable.Bundles);
        log4net.Config.XmlConfigurator.Configure(new FileInfo(Server.MapPath("~/Web.config")));        
    }

</script>
