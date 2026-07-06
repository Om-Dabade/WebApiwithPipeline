using CoreApiWithJenkins.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace CoreApiWithJenkins.Controllers
{
   // [Route("api/[controller]")]
    [ApiController]
    public class StateApiController : ControllerBase
    {
        [Route("api/State")]
        public List<State> GetStates()
        {
            List<State> lst = new List<State>();
            lst.Add(new State() { StateId = 1, StateName = "Maharashtra" });
            lst.Add(new State() { StateId = 2, StateName = "Rajasthan" });
            lst.Add(new State() { StateId = 3, StateName = "Keral" });
            lst.Add(new State() { StateId = 4, StateName = "Karnataka" });
            lst.Add(new State() { StateId = 5, StateName = "TamilNadu" });
            lst.Add(new State() { StateId = 6, StateName = "Punjab" });
            lst.Add(new State() { StateId = 7, StateName = "Bihar" });

            return lst;
        }
    }
}
