using System;
using DevExpress.DashboardWeb;
using DevExpress.Data.Filtering;
using DevExpress.DataAccess.ConnectionParameters;

namespace Dashboard_CustomFilterExpression_Web {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
        }

        protected void ASPxDashboardViewer1_CustomFilterExpression(object sender, CustomFilterExpressionWebEventArgs e) {
            if (e.DataSourceName == "SQL Data Source 1" && e.TableName == "Invoices") {
                e.FilterExpression = new BinaryOperator("CustomerID", "AROUT", BinaryOperatorType.Equal);
            }
        }

        protected void ASPxDashboardViewer1_ConfigureDataConnection(object sender, ConfigureDataConnectionWebEventArgs e) {
            if (e.DataSourceName == "SQL Data Source 1") {
                Access97ConnectionParameters parameters = (Access97ConnectionParameters)e.ConnectionParameters;
                string databasePath = Server.MapPath("App_Data/nwind.mdb");
                parameters.FileName = databasePath;
            }
        }
    }
}