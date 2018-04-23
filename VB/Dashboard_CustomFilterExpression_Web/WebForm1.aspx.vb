Imports System
Imports DevExpress.DashboardWeb
Imports DevExpress.Data.Filtering
Imports DevExpress.DataAccess.ConnectionParameters

Namespace Dashboard_CustomFilterExpression_Web
    Partial Public Class WebForm1
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        End Sub

        Protected Sub ASPxDashboardViewer1_CustomFilterExpression(ByVal sender As Object,
                                                                  ByVal e As CustomFilterExpressionWebEventArgs)
            If e.DataSourceName = "SQL Data Source 1" AndAlso e.TableName = "Invoices" Then
                e.FilterExpression = New BinaryOperator("CustomerID", "AROUT", BinaryOperatorType.Equal)
            End If
        End Sub

        Protected Sub ASPxDashboardViewer1_ConfigureDataConnection(ByVal sender As Object,
                                                                   ByVal e As ConfigureDataConnectionWebEventArgs)
            If e.DataSourceName = "SQL Data Source 1" Then
                Dim parameters As Access97ConnectionParameters = CType(e.ConnectionParameters, Access97ConnectionParameters)
                Dim databasePath As String = Server.MapPath("App_Data/nwind.mdb")
                parameters.FileName = databasePath
            End If
        End Sub
    End Class
End Namespace