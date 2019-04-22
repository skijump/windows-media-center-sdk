<%
sessionCookie = Request.Cookies("McmlCookieTestSession")
persistentCookie = Request.Cookies("McmlCookieTestPersistent")
%>

<Mcml xmlns="http://schemas.microsoft.com/2008/mcml"
      xmlns:cor="assembly://MsCorLib/System">

  <UI Name="GetCookies">
  
  <!-- Web samples are designed to work when loaded       -->
  <!-- via the HTTP:// or HTTPS:// protocol. Generally    -->
  <!-- speaking, opening these samples using FILE:// will -->
  <!-- not produce the desired results.                   -->
  
    <Content>
      <Panel Layout="VerticalFlow">
        <Children>
          <Text Content="Get Cookies" Color="White" />
          <Text Content="Session: <%=sessionCookie%>" Color="White" />
          <Text Content="Persistent: <%=persistentCookie%>" Color="White" />
        </Children>
      </Panel>
    </Content>
        
  </UI>

</Mcml>