<html>
	<head>
		<style>
			body {font-family: "Trebuchet MS"; font-size: 14pt; color: "#F0F0F0"; background-color: "#1E1EF0";}
		</style>
		
		<script language=jscript>
		
			function IsMCEEnabled()
			{
				return true;
			}
			
			function onScaleEvent(vScale)
			{
				try
				{
					document.all.id_body.style.zoom=vScale;
				}
				catch(e)
				{
					// ignore error
				}
			}
			
			function ClientSideUserAgent()
			{
				document.all.CientSideUserAgent.innerText = navigator.userAgent;
			}
			
		</script>
	</head>
	<body onload='ClientSideUserAgent()'>
		<p>Welcome to play.mediacentersandbox.com</p>
		<p>[Client Side navigator.userAgent]</p>
		<p id=CientSideUserAgent></p>
		<p>[Server Side HTTP_USER_AGENT]</p>
                <p><%= Request.ServerVariables("HTTP_USER_AGENT") %></p>
	</body>
</html>
