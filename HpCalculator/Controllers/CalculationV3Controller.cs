﻿using HpCalculator.Middleware;
using HpCalculator.Models;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using static HpCalculator.Middleware.Lookups;

namespace HpCalculator.Controllers
{
    public class CalculationV3Controller : ApiController
    {
        // POST api/v3/calculation
        /// <summary>
        /// Execute the operation and get the result with prime attribute
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

                var result = CalculationClient.CalculateWithPrime(x, y, action);

                return Request.CreateResponse(HttpStatusCode.OK, JsonConvert.SerializeObject(result));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
