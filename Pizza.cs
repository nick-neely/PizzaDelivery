using PizzaDelivery.Components.Pages;

namespace PizzaDelivery

/* Pizza Class */
{
	public class Pizza
	{
		public Topping PizzaTopping { get; set; }

		public Crust PizzaCrust { get; set; }

		public Pizza()
		{
			PizzaTopping = new Topping();
			PizzaCrust = new Crust();
		}



		public double GetFinalPrice()
		{
			return PizzaTopping.ToppingPrice() + PizzaCrust.CrustPrice();
		}

	}


	public class Topping
	{

		public bool Pepperoni { get; set; }
		public bool Sausage { get; set; }
		public bool Ham { get; set; }

		public bool Chicken { get; set; }

		public double ToppingPrice()
		{
			double runningTotal = 0;
			if (Pepperoni)
			{
				runningTotal += 1.50;
			}
			if (Sausage)
			{
				runningTotal += 2.00;
			}
			if (Ham)
			{
				runningTotal += 1.79;
			}
			if (Chicken)
			{
				runningTotal += 3;
			}
			return runningTotal;
		}
	}

	public class Crust
	{

		public bool Thin { get; set; }
		public bool Pan { get; set; }
		public bool Hand { get; set; }
		public double CrustPrice()
		{
			double runningTotal = 0;
			if (Thin)
			{
				runningTotal += 5.99;
			}
			if (Pan)
			{
				runningTotal += 7.99;
			}
			if (Hand)
			{
				runningTotal += 6.99;
			}
			return runningTotal;
		}
	}
}
