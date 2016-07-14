using DemoWebAPI.Models;
using DemoWebAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DemoWebAPI.Controllers
{
    public class NumbersController : ApiController
    {
        private NumbersServices _numbers;

        public NumbersController()
        {
            _numbers = new NumbersServices();
        }

        [HttpGet]
        [Route("api/sum")]
        public long Sum([FromUri] int[] list)
        {
            return list.Sum();
            //return nums.Sum();
        }

        [HttpGet]
        [Route("api/largest")]
        public int FindLargestNumber([FromUri]int[] list)
        {
            return list.Max();
        }


        [HttpGet]
        [Route("api/smallest")]
        public int FindSmallestNumber([FromUri]int[] list)
        {
            return list.Min();
        }

        [HttpGet]
        [Route("api/randoms")]
        public Numbers GenerateRandoms([FromUri] int total)
        {
            return _numbers.GenerateRandomNumbers(total);
        }
    }
}
