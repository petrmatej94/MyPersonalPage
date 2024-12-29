using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using CsvHelper;
using System.Globalization;

namespace MyPersonalPage.Models
{
	using CsvHelper.Configuration.Attributes;

	public class EventRow
	{
		[Name("Date")]
		[TypeConverter(typeof(CustomDateTimeConverter))]
		public DateTime Date { get; set; }

		[Name("EventName")]
		public string EventName { get; set; }

		[Name("Currency")]
		public string Currency { get; set; }

		[Name("OtherEventsAtTheSameTime")]
		public string OtherEventsAtTheSameTime { get; set; }

		[Name("Actual")]
		[TypeConverter(typeof(CustomDoubleConverter))]
		public double Actual { get; set; }

		[Name("Expected")]
		[TypeConverter(typeof(CustomDoubleConverter))]
		public double Expected { get; set; }

		[Name("Diff")]
		public double Diff { get; set; }

		[Name("UpTicksIn_1m")]
		public int UpTicksIn_1m { get; set; }

		[Name("DownTicksIn_1m")]
		public int DownTicksIn_1m { get; set; }

		[Name("UpTicksIn_5m")]
		public int UpTicksIn_5m { get; set; }

		[Name("DownTicksIn_5m")]
		public int DownTicksIn_5m { get; set; }

		[Name("UpTicksIn_10m")]
		public int UpTicksIn_10m { get; set; }

		[Name("DownTicksIn_10m")]
		public int DownTicksIn_10m { get; set; }

		[Name("UpTicksIn_15m")]
		public int UpTicksIn_15m { get; set; }

		[Name("DownTicksIn_15m")]
		public int DownTicksIn_15m { get; set; }

		[Name("UpTicksIn_30m")]
		public int UpTicksIn_30m { get; set; }

		[Name("DownTicksIn_30m")]
		public int DownTicksIn_30m { get; set; }

		[Name("UpTicksIn_60m")]
		public int UpTicksIn_60m { get; set; }

		[Name("DownTicksIn_60m")]
		public int DownTicksIn_60m { get; set; }

		[Name("UpTicksIn_120m")]
		public int UpTicksIn_120m { get; set; }

		[Name("DownTicksIn_120m")]
		public int DownTicksIn_120m { get; set; }
	}

	public class CustomDateTimeConverter : ITypeConverter
	{
		public object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
		{
			if (DateTime.TryParseExact(text, "dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out var date))
			{
				return date;
			}

			throw new TypeConverterException(this, memberMapData, text, row.Context, $"Invalid date format: {text}");
		}

		public string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
		{
			if (value is DateTime date)
			{
				return date.ToString("dd.MM.yyyy HH:mm", CultureInfo.InvariantCulture);
			}

			return string.Empty;
		}
	}

	public class CustomDoubleConverter : ITypeConverter
	{
		public object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
		{
			text = text.Replace(",", ".");

			if (double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out var result))
			{
				return result;
			}

			throw new TypeConverterException(this, memberMapData, text, row.Context, $"Invalid double format: {text}");
		}

		public string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
		{
			if (value is double number)
			{
				return number.ToString("G", CultureInfo.InvariantCulture);
			}

			return string.Empty;
		}
	}
}
