using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using customapi.Models.WS;

namespace customapi.Controllers
{
    public class AccesoController : ApiController
    {
        [HttpGet]
        public Reply Helloworld(Reply entrada)
        {
            Reply oR = new Reply();
            oR.result = 1;
            oR.message = "Hi World!" + entrada.message;

            return oR;
        }

        [HttpPost]
        public Reply Recibidos(string respuesta)
        {
            Reply oA = new Reply();
            oA.message = respuesta;

            return oA;
        }
    }
}
