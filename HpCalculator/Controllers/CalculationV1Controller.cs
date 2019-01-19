using HpCalculator.Middleware;
using HpCalculator.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static HpCalculator.Middleware.Lookups;

namespace HpCalculator.Controllers
{
    public class CalculationV1Controller : ApiController
    {
        // GET api/v1/calculation
        /// <summary>
        /// Get the supported actions list
        /// </summary>
        /// <returns>IEnumerable<string></returns>
        public IEnumerable<string> Get()
        {
            return Enum.GetNames(typeof(ACTION));
        }


        // POST api/v1/calculation
        /// <summary>
        /// Execute the operation and get only the result value
        /// </summary>
        /// <param name="request"></param>
        /// <returns>HttpResponseMessage</returns>
        public HttpResponseMessage Post([FromBody] ApiRequest request)
        {
            try
            {
                #region Validations

                if (request == null)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Not valid request");
                }

                ACTION action;
                if (!Enum.TryParse(request.Operation, out action))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Not valid action");
                }

                int x;
                if (!int.TryParse(request.FirstNo, out x))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Not valid first number");
                }

                int y;
                if (!int.TryParse(request.SecondNo, out y))
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Not valid second number");
                }

                #endregion Validations


                var result = CalculationClient.CalculateBasic(x, y, action);

                return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(result));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
