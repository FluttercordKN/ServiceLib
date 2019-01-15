using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ServiceLib.Test
{
	[TestClass]
	public class StringCleanerTest
	{
		[TestMethod]
		public void ExecuteNoChars()
		{
			var instance = new StringCleaner();
			instance.ChunksToRemove.Add("qwe");
			var result = instance.Execute("asd");
			Assert.AreEqual("asd", result);
		}

		[TestMethod]
		public void ExecuteSomeChars()
		{
			var instance = new StringCleaner();
			instance.ChunksToRemove.Add("qw");
			var result = instance.Execute("qwasqwgh");
			Assert.AreEqual("asgh", result);
		}
	}
}
