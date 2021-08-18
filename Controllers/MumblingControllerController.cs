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
    public class MumblingControllerController : ControllerBase
    {
        [HttpGet]
        public string Mumbling(string s = "aSdf")
        {
            string sLowerCase = s.ToLower();
            string answer = "";

            for (int indexOfs = 0; indexOfs < s.Length; indexOfs++)
            {
                for (int numOfLettersToPrint = indexOfs + 1; numOfLettersToPrint > 0; numOfLettersToPrint--)
                {
                    if (numOfLettersToPrint == indexOfs + 1)
                    {
                        answer += sLowerCase[indexOfs].ToString().ToUpper();
                    }
                    else
                        answer += sLowerCase[indexOfs];
                }
                if (indexOfs < s.Length - 1)
                    answer += "-";
            }

            return answer;
        }
    }
}