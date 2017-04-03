using System;

namespace Csla.AutoAddBusinessRules
{
	[Serializable]
	public sealed class DateRangeFromCore
		: BusinessBaseCore<DateRangeFromCore>
	{
		public static readonly PropertyInfo<DateTime?> EndingProperty =
			DateRangeFromCore.RegisterProperty<DateTime?>(_ => _.Ending);
		public DateTime? Ending
		{
			get { return this.GetProperty(DateRangeFromCore.EndingProperty); }
			set { this.SetProperty(DateRangeFromCore.EndingProperty, value); }
		}

		public static readonly PropertyInfo<string> NameProperty =
			DateRangeFromCore.RegisterProperty<string>(_ => _.Name);
		public string Name
		{
			get { return this.GetProperty(DateRangeFromCore.NameProperty); }
			set { this.SetProperty(DateRangeFromCore.NameProperty, value); }
		}

		public static readonly PropertyInfo<DateTime> StartingProperty =
			DateRangeFromCore.RegisterProperty<DateTime>(_ => _.Starting);
		public DateTime Starting
		{
			get { return this.GetProperty(DateRangeFromCore.StartingProperty); }
			set { this.SetProperty(DateRangeFromCore.StartingProperty, value); }
		}
	}
}
