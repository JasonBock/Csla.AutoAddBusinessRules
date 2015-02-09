using System;
using System.Linq;
using System.Reflection;
using Csla;
using Csla.Core;

namespace Csla.AutoAddBusinessRules
{
	[Serializable]
	public abstract class BusinessBaseCore<T>
		: BusinessBase<T>
		where T : BusinessBaseCore<T>
	{
		protected BusinessBaseCore()
			: base() { }

		protected override void AddBusinessRules()
		{
			base.AddBusinessRules();

			var fields = this.GetType()
				.GetFields(BindingFlags.Static | BindingFlags.Public);

			var propertyInfoFields = fields
				.Where(_ => _.FieldType.IsGenericType &&
					typeof(PropertyInfo<>).IsAssignableFrom(_.FieldType.GetGenericTypeDefinition())).ToList();

			var datePropertyInfoFields = propertyInfoFields
				.Where(_ => typeof(DateTime).IsAssignableFrom(_.FieldType.GetGenericArguments()[0]) ||
					typeof(DateTime?).IsAssignableFrom(_.FieldType.GetGenericArguments()[0])).ToList();

			foreach (var datePropertyInfoField in datePropertyInfoFields)
			{
				var rule = new UtcDateRule(datePropertyInfoField.GetValue(null) as IPropertyInfo);
				this.BusinessRules.AddRule(rule);
			}
		}
	}
}