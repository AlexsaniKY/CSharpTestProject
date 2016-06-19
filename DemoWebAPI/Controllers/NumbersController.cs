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
        public int GetSum()
        {
            var nums = _numbers.GenerateRandomNumbers();
            return _numbers.SumNumbers(nums);
        }

        [HttpGet]
        [Route("api/largest")]
        public int FindLargestNumber()
        {
            var nums = _numbers.GenerateRandomNumbers();
            return _numbers.FindLargest(nums);
        }
    }
}
