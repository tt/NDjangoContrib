using Microsoft.FSharp.Core;

namespace NDjango.Contrib.Filters.Humanize
{
	/// <remarks>
	/// http://docs.djangoproject.com/en/dev/ref/contrib/humanize/#intcomma
	/// </remarks>
	public class IntCommaFilter : Interfaces.ISimpleFilter
	{
		#region ISimpleFilter Members

		public object Perform(object __p1)
		{
			Tuple<bool, int> tuple = Utilities.get_int(__p1);

			if (!tuple.Item1)
			{
				return string.Empty;
			}

			return tuple.Item2.ToString("#,0");
		}

		#endregion
	}
}