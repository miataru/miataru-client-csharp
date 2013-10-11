using System;
using miataruclientcsharp;

namespace miataruclientexample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			miataruclient client = new miataruclient ();

			client.GetLastLocationForDevice ("234092430962", "http://service.miataru.com");
		}
	}
}
