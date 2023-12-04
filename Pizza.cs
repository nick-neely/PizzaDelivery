namespace BlazorApp
{
	public class Pizza
	{
		public Topping PizzaTopping { get; set; }

		public Pizza()
		{
			PizzaTopping = new Topping();
		}

		public decimal GetFinalPrice()
		{
			return PizzaTopping.TopppingPrice();
		}
	}

	public class Topping
	{
		public bool Bacon { get; set; }

		public bool MoreBacon { get; set; }

		public bool EvenMoreBacon { get; set; }

		public decimal TopppingPrice()
		{
			decimal runningTotal = 0;

			if (Bacon)
			{
				runningTotal += 30;
			}
			if (MoreBacon)
			{
				runningTotal += 50;
			}
			if (EvenMoreBacon)
			{
				runningTotal += 200;
			}

			return runningTotal;
		}
	}
}
