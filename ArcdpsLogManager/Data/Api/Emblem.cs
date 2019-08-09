using System.Collections.Generic;

namespace GW2Scratch.ArcdpsLogManager.Data.Api
{
	public class Emblem
	{
		public EmblemPart Background { get; set; }
		public EmblemPart Foreground { get; set; }

		public List<string> Flags { get; set; }
	}
}