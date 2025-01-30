namespace MyPersonalPage.Models
{
	using CsvHelper.Configuration.Attributes;

	public readonly struct NutritionRow
	{
		[Name("Potravina 100g/ml")]
		public string FoodName { get; init; }

		[Name("Vitamin_A_mcg")]
		public double A { get; init; }

		[Name("Vitamin_C_mg")]
		public double C { get; init; }

		[Name("Vitamin_D_mcg")]
		public double D { get; init; }

		[Name("Vitamin_E_mg")]
		public double E { get; init; }

		[Name("Vitamin_K_mcg")]
		public double K { get; init; }

		[Name("Vitamin_B1_mg")]
		public double B1 { get; init; }

		[Name("Vitamin_B2_mg")]
		public double B2 { get; init; }

		[Name("Vitamin_B3_mg")]
		public double B3 { get; init; }

		[Name("Vitamin_B5_mg")]
		public double B5 { get; init; }

		[Name("Vitamin_B6_mg")]
		public double B6 { get; init; }

		[Name("Vitamin_B7_mcg")]
		public double B7 { get; init; }

		[Name("Vitamin_B9_mcg")]
		public double B9 { get; init; }

		[Name("Vitamin_B12_mcg")]
		public double B12 { get; init; }

		[Name("Mineral_Vapnik_mg")]
		public double Calcium { get; init; }

		[Name("Mineral_Zelezo_mg")]
		public double Iron { get; init; }

		[Name("Mineral_Horcik_mg")]
		public double Magnesium { get; init; }

		[Name("Mineral_Fosfor_mg")]
		public double Phosphorus { get; init; }

		[Name("Mineral_Draslík_mg")]
		public double Potassium { get; init; }

		[Name("Mineral_Zinek_mg")]
		public double Zinc { get; init; }

		[Name("Mineral_Selen_mcg")]
		public double Selenium { get; init; }

		[Name("Mineral_Měď_mg")]
		public double Copper { get; init; }

		[Name("Mineral_Mangan_mg")]
		public double Manganese { get; init; }

		[Name("Mineral_Fluor_mcg")]
		public double Fluoride { get; init; }

		[Name("Mineral_Chrom_mcg")]
		public double Chromium { get; init; }

		[Name("Mineral_Molybden_mcg")]
		public double Molybdenum { get; init; }

		[Name("Omega_3_g")]
		public double Omega3 { get; init; }

		[Name("Omega_6_g")]
		public double Omega6 { get; init; }

		[Name("N_Bilkoviny_g")]
		public double Proteins { get; init; }

		[Name("N_Sacharidy_g")]
		public double Carbohydrates { get; init; }

		[Name("N_Tuky_g")]
		public double Fats { get; init; }

		[Name("N_Kalorie_kcal")]
		public double Calories { get; init; }
	}
}
