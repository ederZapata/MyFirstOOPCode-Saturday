using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstOOPCode_Saturday
{
    public class ComissionEmployee : Employee
    {
        #region Properties
        public float ComissionPercentage { get; set }

        public decimal Sales { get; set; }
        #endregion

        #region Methods
        public override decimal GetValueToPay() 
        {
            return Sales * ((decimal)ConvertPercentage(ComissionPercentage);        
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n\t " +
                $"Comission Percentage....{ComissionPercentage:P2}\n\t" +
                $"Sales..                .{ Sales:C2}" +
                $"Value To Pay            {GetValueToPay:C2}";
        }

        private float ConvertPercentage(double commissionPercentage) 
        {
            return commissionPercentage / 100;
        }
        #endregion



    }
}
