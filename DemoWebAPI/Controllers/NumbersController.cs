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

        [HttpPost]
        [Route("api/sum/{nums}")]
        public int GetSum(Numbers nums)
        {
            return _numbers.SumNumbers(nums);
        }

        [HttpPost]
        [Route("api/largest/{nums}")]
        public int FindLargestNumber(Numbers nums)
        {
            return _numbers.FindLargest(nums);
        }
    }
}
