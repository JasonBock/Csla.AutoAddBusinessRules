using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csla.AutoAddBusinessRules.Tests
{
	[TestClass]
	public sealed class DateRangeFromCoreTests
	{
		[TestMethod]
		public void Create()
		{
			var range = DataPortal.Create<DateRangeFromCore>();
			range.Starting = DateTime.Now;
			range.Ending = DateTime.Now;

			Assert.AreEqual(DateTimeKind.Utc, range.Starting.Kind);
			Assert.AreEqual(DateTimeKind.Utc, range.Ending.Value.Kind);
		}
	}
}
