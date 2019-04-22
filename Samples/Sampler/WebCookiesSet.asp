<%
Response.Cookies("McmlCookieTestSession") = "ThisIsTheSessionCookie"
Response.Cookies("McmlCookieTestSession").Path = "/"
%>

<%
Response.Cookies("McmlCookieTestPersistent") = "ThisIsThePersistentCookie"
Response.Cookies("McmlCookieTestPersistent").Expires = Date() + 1
Response.Cookies("McmlCookieTestPersistent").Path = "/"
%>

<% Response.Expires = -1 %>


<Mcml xmlns="http://schemas.microsoft.com/2006/mcml"
      xmlns:cor="assembly://MsCorLib/System"
      xmlns:btn="http://play.mediacentersandbox.com/sample/6/ControlsButton.mcml">

  <UI Name="SetCookies">
  
  <!-- Web samples are designed to work when loaded       -->
  <!-- via the HTTP:// or HTTPS:// protocol. Generally    -->
  <!-- speaking, opening these samples using FILE:// will -->
  <!-- not produce the desired results.                   -->

    <Content>
      <Panel Layout="VerticalFlow">
        <Children>
          <Text Content="Session and persistent (Expires: 1 Day) cookies have been set by the server." Color="White" WordWrap="true"/>
          <btn:Button>
            <Command>
              <NavigateCommand Source="http://play.mediacentersandbox.com/sample/6/WebCookiesGet.asp" Description="Get Cookies"/>
            </Command>
          </btn:Button>
        </Children>
      </Panel>
    </Content>
        
  </UI>

</Mcml>
