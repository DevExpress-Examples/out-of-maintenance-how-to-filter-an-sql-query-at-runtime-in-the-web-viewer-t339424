<!-- default file list -->
*Files to look at*:

* [WebForm1.aspx](./CS/Dashboard_CustomFilterExpression_Web/WebForm1.aspx) (VB: [WebForm1.aspx](./VB/Dashboard_CustomFilterExpression_Web/WebForm1.aspx))
* [WebForm1.aspx.cs](./CS/Dashboard_CustomFilterExpression_Web/WebForm1.aspx.cs) (VB: [WebForm1.aspx.vb](./VB/Dashboard_CustomFilterExpression_Web/WebForm1.aspx.vb))
<!-- default file list end -->
# How to filter an SQL query at runtime in the Web Viewer
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t339424/)**
<!-- run online end -->


<strong>Note:</strong> <em>Starting with v17.1, we recommend using the <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16976.aspx">ASPxDashboard control</a> or a corresponding <a href="https://documentation.devexpress.com/Dashboard/CustomDocument16977.aspx">ASP.NET MVC extension</a> to display dashboards within web applications.</em><br><br>The following example shows how to filter an SQL query at runtime using the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWebASPxDashboardViewer_CustomFilterExpressiontopic">ASPxDashboardViewer.CustomFilterExpression</a> event. The <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressDataAccessCustomFilterExpressionEventArgs_TableNametopic">TableName</a> event parameter is used to check the name of the query that should be filtered. The <a href="https://documentation.devexpress.com/#CoreLibraries/DevExpressDataAccessCustomFilterExpressionEventArgs_FilterExpressiontopic">FilterExpression</a> property specifies the required filter criteria.

<br/>


