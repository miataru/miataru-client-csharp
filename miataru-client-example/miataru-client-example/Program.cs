using System;
using miataruclientcsharp;
using System.Collections.Generic;
using JavaScriptTimeStampExtension;

namespace miataruclientexample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			miataruclient client = new miataruclient ();

			List<MiataruLocation> Locations = client.GetLastLocationForDevice ("4F8606E4-7A2C-4519-8494-452C63548531", "http://service.miataru.com");

			if (Locations != null) {
				foreach (MiataruLocation location in Locations) {
					Console.WriteLine (location.Longitude);
				}
			}
		}
	}
}
