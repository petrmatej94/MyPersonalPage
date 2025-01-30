namespace MyPersonalPage.Models
{
	public class SelectedFood
	{
		public NutritionRow BaseData { get; set; }
		public int Quantity { get; set; }

		public SelectedFood(NutritionRow baseData, int quantity)
		{
			BaseData = baseData;
			Quantity = quantity;
		}

		private double CalculateBasedOnQuantity(double baseValue)
		{
			return Math.Round((baseValue / 100) * Quantity, 1);
		}

		public double Calories => CalculateBasedOnQuantity(BaseData.Calories);
		public double Proteins => CalculateBasedOnQuantity(BaseData.Proteins);
		public double Fats => CalculateBasedOnQuantity(BaseData.Fats);
		public double Carbohydrates => CalculateBasedOnQuantity(BaseData.Carbohydrates);
		public double A => CalculateBasedOnQuantity(BaseData.A);
		public double C => CalculateBasedOnQuantity(BaseData.C);
		public double D => CalculateBasedOnQuantity(BaseData.D);
		public double E => CalculateBasedOnQuantity(BaseData.E);
		public double K => CalculateBasedOnQuantity(BaseData.K);
		public double B1 => CalculateBasedOnQuantity(BaseData.B1);
		public double B2 => CalculateBasedOnQuantity(BaseData.B2);
		public double B3 => CalculateBasedOnQuantity(BaseData.B3);
		public double B5 => CalculateBasedOnQuantity(BaseData.B5);
		public double B6 => CalculateBasedOnQuantity(BaseData.B6);
		public double B7 => CalculateBasedOnQuantity(BaseData.B7);
		public double B9 => CalculateBasedOnQuantity(BaseData.B9);
		public double B12 => CalculateBasedOnQuantity(BaseData.B12);
		public double Calcium => CalculateBasedOnQuantity(BaseData.Calcium);
		public double Iron => CalculateBasedOnQuantity(BaseData.Iron);
		public double Magnesium => CalculateBasedOnQuantity(BaseData.Magnesium);
		public double Phosphorus => CalculateBasedOnQuantity(BaseData.Phosphorus);
		public double Potassium => CalculateBasedOnQuantity(BaseData.Potassium);
		public double Zinc => CalculateBasedOnQuantity(BaseData.Zinc);
		public double Selenium => CalculateBasedOnQuantity(BaseData.Selenium);
		public double Copper => CalculateBasedOnQuantity(BaseData.Copper);
		public double Manganese => CalculateBasedOnQuantity(BaseData.Manganese);
		public double Fluoride => CalculateBasedOnQuantity(BaseData.Fluoride);
		public double Chromium => CalculateBasedOnQuantity(BaseData.Chromium);
		public double Molybdenum => CalculateBasedOnQuantity(BaseData.Molybdenum);
		public double Omega3 => CalculateBasedOnQuantity(BaseData.Omega3);
		public double Omega6 => CalculateBasedOnQuantity(BaseData.Omega6);
	}
}
