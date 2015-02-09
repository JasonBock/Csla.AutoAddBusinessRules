using System;
using Csla;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Csla.AutoAddBusinessRules.Tests
{
	[TestClass]
	public sealed class DateRangeNotFromCoreTests
	{
		[TestMethod]
		public void Create()
		{
			var range = DataPortal.Create<DateRangeNotFromCore>();
			range.Starting = DateTime.Now;
			range.Ending = DateTime.Now;

			Assert.AreEqual(DateTimeKind.Local, range.Starting.Kind);
			Assert.AreEqual(DateTimeKind.Local, range.Ending.Value.Kind);
		}
	}
}
