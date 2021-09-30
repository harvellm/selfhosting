using System;
using Microsoft.AspNetCore.Mvc;

namespace SelfHosting
{
    public class DeepThoughtController : Controller
    {
        public IActionResult UltimateAnswer()
        {
            try
            {
                Console.WriteLine("Returning Answer");
                return Ok(42);
            }
            catch (NullReferenceException err)
            {
                return StatusCode(500, err);
            }
        }
    }
}