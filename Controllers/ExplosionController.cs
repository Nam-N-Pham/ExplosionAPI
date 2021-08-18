using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExplosionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExplosionController : ControllerBase
    {
        [HttpGet("{s}")]
        public string Explosion(string s = "123456789")
        {
            List<string> digits = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string answer = "";

            for (int i = 0; i < s.Length; i++)
            {
                int CurrentDigitAsInt = (int)Char.GetNumericValue(s[i]);
                for (int j = CurrentDigitAsInt; j > 0; j--)
                {
                    if (CurrentDigitAsInt == 0)
                        continue;
                    answer += digits[CurrentDigitAsInt];
                }

            }

            return answer;
        }
    }
}