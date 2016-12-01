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
				Dictionary<string, string> model = new Dictionary<string, string>();
				model["HasResponse"] = "false";
				return View["index.cshtml", model];
			};
			Post["/"] = _ =>
			{
				Dictionary<string, string> model = new Dictionary<string, string>();
				model["HasResponse"] = "true";
				model["value"] = ScrabbleWord.GetWordValue(Request.Form["userInput"]).ToString();
				return View["index.cshtml", model];
			};
		}
	}
}
