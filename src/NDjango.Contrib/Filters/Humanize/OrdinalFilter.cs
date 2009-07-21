using Microsoft.FSharp.Core;

namespace NDjango.Contrib.Filters.Humanize
{
	/// <remarks>
	/// http://docs.djangoproject.com/en/dev/ref/contrib/humanize/#ordinal
	/// </remarks>
	public class OrdinalFilter : Interfaces.ISimpleFilter
	{
		#region ISimpleFilter Members

		public object Perform(object __p1)
		{
			Tuple<bool, int> tuple = Utilities.get_int(__p1);

			if (!tuple.Item1)
			{
				return string.Empty;
			}

			string numberString = tuple.Item2.ToString();

			string suffix;

			if (numberString.EndsWith("1") && !numberString.EndsWith("11"))
			{
				suffix = "st";
			}
			else if (numberString.EndsWith("2") && !numberString.EndsWith("12"))
			{
				suffix = "nd";
			}
			else if (numberString.EndsWith("3") && !numberString.EndsWith("13"))
			{
				suffix = "rd";
			}
			else
			{
				suffix = "th";
			}

			return string.Format("{0}{1}", tuple.Item2, suffix);
		}

		#endregion
	}
}