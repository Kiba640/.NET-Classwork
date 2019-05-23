using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{

    public class DeskQuote
    {



        private const decimal BASE_DESK_PRICE = 200.00M;
        private const decimal SURFACE_COST = 1.0M;
        private const decimal DRAWER_COST = 50.0M;
        private const decimal OAK_COST = 200.0M;
        private const decimal LAMINATE_COST = 100.0M;
        private const decimal PINE_COST = 50.0M;
        private const decimal ROSEWOOD_COST = 200.0M;
        private const decimal VENEER_COST = 125.0M;

        private int[,] _shipPrice;

        public string customerName;
        public Desk desk;
        public DateTime quoteDate;
        public decimal quotePrice;
        public Shipping shipping;

        //read the price txt file in and save it to the array
        private void getRushOrder()
        {
            _shipPrice = new int[3, 3];

            var file = @"rushOrderPrices.txt";
            string[] temp = new string[9];
            try
            {
                temp = File.ReadAllLines(file);
                int count = 0;
                for (int i = 0; i < 3; ++i)
                {
                    for (int j = 0; j <3; ++j)
                    {
                        _shipPrice[i, j] = Convert.ToInt32(temp[count]);
                        count++;
                    }
                }
            }
            catch(Exception e)
            {
                return;
            }
        }

        //Calcuates the quote Price;
        public void setPrice()
        {
            getRushOrder();
            decimal price = BASE_DESK_PRICE;

            //check the area of the desk and charge accordingly
            int surfaceArea =  desk.getArea();
            if (surfaceArea > 1000)
            {
                price += (surfaceArea - 1000);
            }

            //check the desk material and add to cost accordingly
            switch(desk.desktop)
            {
                case Material.oak:
                    {
                        price += OAK_COST;
                        break;
                    }
                case Material.laminate:
                    {
                        price += LAMINATE_COST;
                        break;
                    }
                case Material.pine:
                    {
                        price += PINE_COST;
                        break;
                    }
                case Material.rosewood:
                    {
                        price += ROSEWOOD_COST;
                        break;
                    }
                case Material.veneer:
                    {
                        price += VENEER_COST;
                        break;
                    }
            }

            switch(shipping)
            {
                case Shipping.standard14:
                    {
                        break;
                    }
                case Shipping.rush3:
                    {
                        if(surfaceArea < 1000) { price += _shipPrice[0, 0]; }
                        else if(surfaceArea <= 2000) { price += _shipPrice[0, 1]; }
                        else { price += _shipPrice[0, 2]; }
                        break;
                    }
                case Shipping.rush5:
                    {
                        if (surfaceArea < 1000) { price += _shipPrice[1, 0]; }
                        else if (surfaceArea <= 2000) { price += _shipPrice[1, 1]; }
                        else { price += _shipPrice[1, 2]; }
                        break;
                    }
                case Shipping.rush7:
                    {
                        if (surfaceArea < 1000) { price += _shipPrice[2, 0]; }
                        else if (surfaceArea <= 2000) { price += _shipPrice[2, 1]; }
                        else { price += _shipPrice[2, 2]; }
                        break;
                    }
            }
            quotePrice = price;

        }
        
    }
   public enum Shipping
    {
        standard14, rush3, rush5, rush7
    }

}
