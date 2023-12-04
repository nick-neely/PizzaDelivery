<<<<<<< HEAD
﻿namespace BlazorApp
=======
namespace PizzaDelivery
>>>>>>> c7935f2d81dc75d280eb902ab2d05968fcc55138
{
	public class Pizza
	{
		public Topping PizzaTopping { get; set; }
<<<<<<< HEAD

=======
>>>>>>> c7935f2d81dc75d280eb902ab2d05968fcc55138
		public Pizza()
		{
			PizzaTopping = new Topping();
		}
<<<<<<< HEAD

		public decimal GetFinalPrice()
		{
			return PizzaTopping.TopppingPrice();
		}
=======
		public decimal GetFinalPrice()
		{
			return PizzaTopping.ToppingPrice();
		}

>>>>>>> c7935f2d81dc75d280eb902ab2d05968fcc55138
	}

	public class Topping
	{
<<<<<<< HEAD
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

=======
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
>>>>>>> c7935f2d81dc75d280eb902ab2d05968fcc55138
			return runningTotal;
		}
	}
}
