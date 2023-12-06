using PizzaDelivery.Components.Pages;

namespace PizzaDelivery

/* Pizza Class */
{
	public class Pizza
	{
		public Toppings PizzaTopping { get; set; }

		public Crust PizzaCrust { get; set; }

		public double TipPercentage { get; set; }
		private const double DeliveryFee = 2.00;

		public Pizza()
		{
			PizzaTopping = new Toppings();
			PizzaCrust = new Crust();
		}

		public double CalculateTip(double foodCost)
		{
    // Tip is calculated on the food cost plus delivery fee
    return (foodCost + DeliveryFee) * (TipPercentage / 100);
		}

		public double GetFinalPrice(double foodCost, double tip)
		{
    // Final price is the sum of food cost, delivery fee, and tip
    return foodCost + DeliveryFee + tip;
		}

		public double GetDeliveryFee()
		{
			return DeliveryFee;
		}

	}


	public class Toppings
	{

		public bool Pepperoni { get; set; }
		public bool ExtraCheese { get; set; }
		public bool Ham { get; set; }

		public bool Chicken { get; set; }

		public double ToppingPrices()
		{
			double runningTotal = 0;
			if (Pepperoni)
			{
				runningTotal += 1.50;
			}
			if (ExtraCheese)
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
