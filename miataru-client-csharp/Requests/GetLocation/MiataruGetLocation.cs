using System;
using System.Collections.Generic;

namespace miataruclientcsharp
{
	public class MiataruLocationDevice
	{
		public String Device;
	}

	public class MiataruGetLocationRequest
	{
		public List<MiataruLocationDevice> MiataruGetLocation;

		public MiataruGetLocationRequest ()
		{
			MiataruGetLocation = new List<MiataruLocationDevice> ();
		}
	}
}

