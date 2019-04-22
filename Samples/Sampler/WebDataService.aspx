<%@ Page Language="C#"%>
<% Response.Cache.SetExpires(DateTime.Now); %>
<%
string name="default";
Int32 len = 0;
System.Random randObj = new System.Random();
Int32 ID = Convert.ToInt32(randObj.Next());
if (Request.HttpMethod == "GET")
{
    name=Request.QueryString["users"];
}
if (Request.HttpMethod == "POST")
{
    System.IO.Stream str;
    System.IO.StreamReader strReader;
    str = Request.InputStream;
    strReader = new System.IO.StreamReader(str);
    name = strReader.ReadToEnd();
    len = Convert.ToInt32(str.Length);
}
if (Request.HttpMethod == "PUT")
{
    // Get the XML document.
    // Validate the XML document.
    // Write the XML document to server location.
}
%>
<?xml version="1.0" encoding="utf-8" ?>
<users name="<%=name%>">
    <WelcomeInformation>Hello, <%=name%>!</WelcomeInformation> 
    <ID><%=ID%></ID>
    <RequestMethod> <%=Request.HttpMethod%> </RequestMethod>
    <DocLength> <%=len%> </DocLength> 
</users>