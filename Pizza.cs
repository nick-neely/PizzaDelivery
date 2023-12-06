using PizzaDelivery.Components.Pages;

namespace PizzaDelivery

/* Pizza Class */
{
	public class Pizza
	{
		public Topping PizzaTopping { get; set; }

		public Crust PizzaCrust { get; set; }

		public Tip PizzaTip { get; set; }


		public Pizza()
		{
			PizzaTopping = new Topping();
			PizzaCrust = new Crust();
			PizzaTip = new Tip();
		}



		public double TotalPrice()
		{
			double totalTip = (PizzaTopping.ToppingPrice() + PizzaCrust.CrustPrice()) * PizzaTip.TipAmount();
			double totalAmount = PizzaTopping.ToppingPrice() + PizzaCrust.CrustPrice() + 2.00 + totalTip;
			return totalAmount;
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

	public class Tip()
	{
		public bool smallTip { get; set; }
		public bool mediumTip { get; set; }
		public bool LargeTip { get; set; }

		public double TipAmount()
		{
			double tip = 0;
			if (smallTip)
			{
				tip = .12;
			}
			if (mediumTip)
			{
				tip = .15;
			}
			if (LargeTip)
			{
				tip = .18;
			}
			return tip;
		}
	}
}
