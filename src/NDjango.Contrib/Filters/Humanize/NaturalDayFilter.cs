using System;

namespace NDjango.Contrib.Filters.Humanize
{
	/// <remarks>
	/// http://docs.djangoproject.com/en/dev/ref/contrib/humanize/#naturalday
	/// </remarks>
	public class NaturalDayFilter : Interfaces.IFilter
	{
		#region IFilter Members

		public object DefaultValue
		{
			get { throw new NotImplementedException(); }
		}

		public object PerformWithParam(object __p1, object __p2)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region ISimpleFilter Members

		public object Perform(object __p1)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}