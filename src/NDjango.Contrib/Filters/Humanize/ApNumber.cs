using Microsoft.FSharp.Core;

namespace NDjango.Contrib.Filters.Humanize
{
	/// <remarks>
	/// http://docs.djangoproject.com/en/dev/ref/contrib/humanize/#apnumber
	/// </remarks>
	public class ApNumber : Interfaces.ISimpleFilter
	{
		#region ISimpleFilter Members

		public object Perform(object __p1)
		{
			Tuple<bool, int> tuple = Utilities.get_int(__p1);

			if (!tuple.Item1)
			{
				return string.Empty;
			}

			// TODO: Extract these strings into resource files to allow localization
			switch (tuple.Item2)
			{
				case 1:
					return "one";

				case 2:
					return "two";

				case 3:
					return "three";

				case 4:
					return "four";

				case 5:
					return "five";

				case 6:
					return "six";

				case 7:
					return "seven";

				case 8:
					return "eight";

				case 9:
					return "nine";
			}

			return tuple.Item2;
		}

		#endregion
	}
}