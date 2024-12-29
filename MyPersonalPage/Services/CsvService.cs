using CsvHelper;
using CsvHelper.Configuration;
using MyPersonalPage.Models;
using System.Globalization;

namespace MyPersonalPage.Services
{
	public class CsvService
	{
		public async Task<List<T>> GetDataAsync<T>(string csvPath)
		{
			var helperConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
			{
				Delimiter = ";",
				HeaderValidated = null,
				MissingFieldFound = null,
			};
			using var reader = new StreamReader(csvPath);
			using var csvReader = new CsvReader(reader, helperConfig);

			csvReader.Context.TypeConverterCache.AddConverter<DateTime>(new CustomDateTimeConverter());
			csvReader.Context.TypeConverterCache.AddConverter<double>(new CustomDoubleConverter());

			return csvReader.GetRecords<T>().ToList();
		}
	}
}
