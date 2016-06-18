﻿using DemoWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoWebAPI.Services
{
    /// <summary>
    /// This is what we call a services layer, it's ordinarily part of a service/repository pattern
    /// but as that we are not storing any data we are simply recieving and returning data, we will simply
    /// have a servicess layer
    /// </summary>
    public class NumbersServices
    {
        /// <summary>
        /// This method accepts our data model Numbers, which contains a list of numbers
        /// it then uses a linq query method to sum all values and return them as an integer value of their total
        /// value
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SumNumbers(Numbers nums)
        { 
            return nums.Sum();
        }

        /// <summary>
        /// This utilizes linq as well to order the list by descending value, and then returns the first value in the list.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public int FindLargest(Numbers num)
        {
            return num.OrderByDescending(i => i).FirstOrDefault();
        }
    }
}