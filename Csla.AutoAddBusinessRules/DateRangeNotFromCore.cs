using System;
using Csla;

namespace Csla.AutoAddBusinessRules
{
	[Serializable]
	public sealed class DateRangeNotFromCore
		: BusinessBase<DateRangeNotFromCore>
	{
		public static readonly PropertyInfo<DateTime> StartingProperty =
			DateRangeNotFromCore.RegisterProperty<DateTime>(_ => _.Starting);
		public DateTime Starting
		{
			get { return this.GetProperty(DateRangeNotFromCore.StartingProperty); }
			set { this.SetProperty(DateRangeNotFromCore.StartingProperty, value); }
		}

		public static readonly PropertyInfo<string> NameProperty =
			DateRangeNotFromCore.RegisterProperty<string>(_ => _.Name);
		public string Name
		{
			get { return this.GetProperty(DateRangeNotFromCore.NameProperty); }
			set { this.SetProperty(DateRangeNotFromCore.NameProperty, value); }
		}

		public static readonly PropertyInfo<DateTime?> EndingProperty =
			DateRangeNotFromCore.RegisterProperty<DateTime?>(_ => _.Ending);
		public DateTime? Ending
		{
			get { return this.GetProperty(DateRangeNotFromCore.EndingProperty); }
			set { this.SetProperty(DateRangeNotFromCore.EndingProperty, value); }
		}
	}
}
