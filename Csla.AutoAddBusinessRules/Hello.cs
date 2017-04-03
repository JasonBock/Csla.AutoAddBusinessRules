using System;

namespace Csla.AutoAddBusinessRules
{
	public sealed class Hello
	{
		public Hello(string name)
		{
			if(name == null)
			{
				throw new ArgumentNullException(nameof(name));
			}

			this.Name = name;
		}

		public string Speak()
		{
			return $"Hello {this.Name}";
		}

		public string Name { get; }
	}
}
