namespace PizzaDelivery
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
			return PizzaTopping.ToppingPrice();
		}

	}

	public class Topping
	{
		public bool Pepperoni { get; set; }
		public bool Sausage { get; set; }
		public bool Bacon { get; set; }
		public decimal ToppingPrice()
		{
			decimal runningTotal = 0;
			if (Pepperoni)
			{
				runningTotal += 30;
			}
			if (Sausage)
			{
				runningTotal += 50;
			}
			if (Bacon)
			{
				runningTotal += 20;
			}
			return runningTotal;
		}
	}
}
