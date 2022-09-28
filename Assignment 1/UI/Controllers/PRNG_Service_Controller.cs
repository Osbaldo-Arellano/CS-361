using System.Web.Mvc;
using PRNG_Service;

namespace UI.Controllers
{
    public class PRNG_Service_Controller 
    {
        public int Generate()
        {
            int num = PRNG_Service.GenerateRandom.Generate();
            return num;
        }
    }
}