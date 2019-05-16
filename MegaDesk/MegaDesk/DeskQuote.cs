﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{

    class DeskQuote
    {


        private const decimal BASE_DESK_PRICE = 200.00M;
        private const decimal SURFACE_COST = 1.0M;
        private const decimal DRAWER_COST = 50.0M;
        private const decimal OAK_COST = 200.0M;
        private const decimal LAMINATE_COST = 100.0M;
        private const decimal PINE_COST = 50.0M;
        private const decimal ROSEWOOD_COST = 200.0M;
        private const decimal VENEER_COST = 125.0M;


        public string customerName;
        public Desk desk;
        public DateTime quoteDate;
        private decimal quotePrice { get; }
        public Shipping shipping;

        //Calcuates the quote Price;
        public void setPrice()
        {
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

        }
        
    }
    enum Shipping
    {
        
    }

}
