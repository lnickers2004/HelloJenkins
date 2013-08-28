using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace HelloJenkins.MSTests
{
	[TestClass]
	public class when_testing_with_mstest
	{
		[TestMethod]
		public void then_running_this_test_should_pass()
		{
			Assert.AreEqual(true,true);
		}
	}


}
