using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerApp
{
    public class Order
    {
        public string[] menuEntree = new string[]
            {"Chicken Salad", "Ham and Cheese", "Turkey", "Vegetable Wrap", "Tuna Salad", "Avocado and Cheese",
            "Club", "Peanut Butter and Jelly", "Grilled Cheese", "Reuben"};

        public decimal[] menuEntreePrice = new decimal[]
        {
            4.50M, 5.00M, 4.75M, 4.50M, 4.00M, 5.50M, 3.75M, 3.50M, 3.50M, 5.00M
        };

        public string Entree { get; set; }
        public bool WaterSelection { get; set; }
        public string DrinkSelection { get; set; }
        public string SpecialRequest { get; set; }
        public decimal EntreePrice { get; set; }
        public decimal DrinkPrice { get; set; }

        public Order()
        {
            Entree = string.Empty;
            WaterSelection = false;
            SpecialRequest = string.Empty;
            DrinkSelection = string.Empty;
            DrinkPrice = 0;
            EntreePrice = 0;
        }

        //After the entree is selected, store the price
        public void SetEntreePrice()
        {
            for (int i = 0; i < menuEntree.Length; i++)
            {
                if (menuEntree[i] == Entree)
                {
                    EntreePrice = menuEntreePrice[i];
                }
            }
        }

        //Return the water selection true or false
        public string GetWaterSelection()
        {
            string waterOrNot;
            if (WaterSelection)
            {
                waterOrNot = "Water";
            }
            else
            {
                waterOrNot = "No Water";
            }
            return waterOrNot;
        }
        public void SetDrinkPrice()
        {
            switch (DrinkSelection)
            {
                case "Tea":
                case "Coffee":
                    DrinkPrice = 1.50M;
                    break;
                case "Soda":
                case "Lemonade":
                    DrinkPrice = 2.00M;
                    break;
                case "Milk":
                case "Juice":
                    DrinkPrice = 1.75M;
                    break;
            }
        }

        //return the total cost of order
        public decimal DetermineTotalCharges()
        {
            SetDrinkPrice();
            SetEntreePrice();
            return EntreePrice + DrinkPrice;
        }

        public override string ToString()
        {
            return "Total Due: " + DetermineTotalCharges().ToString("C");
        }
    }

}
