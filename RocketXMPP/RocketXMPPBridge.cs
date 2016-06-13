using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

using Sharp.Xmpp;
using Sharp.Xmpp.Client;
using Sharp.Xmpp.Core;
using Sharp.Xmpp.Im;

using Rocket.Core.Plugins;
using Rocket.Core.Logging;
using Rocket.Unturned.Player;
using Rocket.Unturned.Chat;

namespace RocketXMPP
{
	public class RocketXMPPBridge : RocketPlugin
	{

		XmppClient client = new XmppClient ("domain", "username", "password");


		public RocketXMPPBridge ()
		{
			client.Message += RocketXMPPBridge_OnMessage;

			client.Connect ();

		}

		void FixedUpdate()
		{
		}



		private void RocketXMPPBridge_OnMessage(object _object, Sharp.Xmpp.Im.MessageEventArgs _args)
		{ 
			Logger.Log (_args.Message.Body);
		}

		void j_OnError(object sender, Exception ex)
		{
			Logger.Log (ex);
		}
	
	}
		
}

