using System;

namespace QuestForJoy
{
	public class Scripture
	{
		public string Reference { get; set; }
		public string Heading { get; set; }
		public string Verse { get; set; }
		public string Description { get; set; }

		public Scripture (string r, string h, string v, string d)
		{
			this.Reference = r;
			this.Heading = h;
			this.Verse = v;
			this.Description = d;
		}

	}
}

