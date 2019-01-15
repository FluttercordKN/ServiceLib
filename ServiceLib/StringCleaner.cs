using System.Collections.Generic;
using System.Linq;

namespace ServiceLib
{
	public class StringCleaner
    {
		public List<string> ChunksToRemove { get; }


		public StringCleaner(IEnumerable<string> charsToRemove)
		{
			ChunksToRemove = charsToRemove.ToList();
		}
		public StringCleaner()
			:this(new string[0])
		{

		}

		public string Execute(string source)
		{
			foreach (var item in ChunksToRemove)
				source = source.Replace(item, string.Empty);
			return source;
		}
	}
}
