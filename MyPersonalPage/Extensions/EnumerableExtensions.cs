namespace MyPersonalPage.Extensions
{
	public static class EnumerableExtensions
	{
		public static double Median(this IEnumerable<int> source)
		{
			if (!source.Any())
				throw new InvalidOperationException("Can't compute median for an empty set!");

			var sortedList = source.OrderBy(x => x).ToList();
			int count = sortedList.Count;
			if (count % 2 == 0)
			{
				return (sortedList[count / 2 - 1] + sortedList[count / 2]) / 2.0;
			}
			else
			{
				return sortedList[count / 2];
			}
		}
	}
}
