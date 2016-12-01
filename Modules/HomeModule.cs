using Nancy;
using System.Collections.Generic;
using Scrabble.Objects;

namespace Scrabble
{
	public class HomeModule : NancyModule
	{
		public HomeModule()
		{
			Get["/"] = _ =>
			{
				return View["index.cshtml"];
			};
		}
	}
}
