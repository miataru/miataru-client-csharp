using System;
using System.Collections.Generic;

namespace miataruclientcsharp
{
	#region MiataruLocation
	public class MiataruLocation
	{
		public String Device;
		public DateTime TimeStamp;
		public Double Longitude;
		public Double Latitude;
		public Double HorizontalAccuracy;
	}
	#endregion

	#region MiataruNoLocation
	#endregion

	public class MiataruLocationObject
	{
		public List<MiataruLocation> MiataruLocation;
		public List<MiataruLocationDevice> MiataruNoLocation;

		public MiataruLocationObject ()
		{
			MiataruLocation = new List<MiataruLocation> ();
			MiataruNoLocation = new List<MiataruLocationDevice> ();
		}
	}
}

