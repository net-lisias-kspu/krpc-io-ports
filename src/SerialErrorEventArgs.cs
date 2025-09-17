/* -*- Mode: Csharp; tab-width: 8; indent-tabs-mode: t; c-basic-offset: 8 -*- */
/*
	This file is part of KRPC.IO.Ports /L Unleashed
		© 2025 LisiasT : https://lisias.net : http://lisias.net <support@lisias.net>
		© 2017-2025 kRPC Org

	KRPC.IO.Ports /L Unleashed is licensed as follows:
		* 3-clause BSD : Mono runtime and its class libraries
		* MIT : remaining code in this repository

	KRPC.IO.Ports /L Unleashed is distributed in the hope that
	it will be useful, but WITHOUT ANY WARRANTY; without even the implied
	warranty of	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

*/
using System;

namespace KRPC.IO.Ports
{
	public class SerialErrorReceivedEventArgs : EventArgs
	{

		internal SerialErrorReceivedEventArgs (SerialError eventType)
		{
			this.eventType = eventType;
		}

		// properties

		public SerialError EventType {
			get {
				return eventType;
			}
		}

		SerialError eventType;
	}
}

