using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CalDocker.Operations;

namespace CalDocker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationsController : ControllerBase
    {
        [HttpGet]
        [Route("sum/{*operators}")]
        public ActionResult SumOperators(string operators)
        {
            var resultOperation = new Sum(operators);
            if (resultOperation.Status)
            return  Ok(resultOperation.Result);
            else 
            return BadRequest();
        }

        [HttpGet]
        [Route("minus/{oper}/{operand}")]
        public ActionResult MinusOperators(string oper,string operand)
        {
            var resultOperation = new Minus(oper,operand);
            if (resultOperation.Status)
            return  Ok(resultOperation.Result);
            else 
            return BadRequest();
        }
        
        [HttpGet]
        [Route("multi/{oper}/{operand}")]
        public ActionResult MultiOperator(string oper,string operand)
        {
            var resultOperation = new Multi(oper,operand);
            if (resultOperation.Status)
            return  Ok(resultOperation.Result);
            else 
            return BadRequest();
        }

        [HttpGet]
        [Route("div/{oper}/{operand}")]
        public ActionResult DivOperator(string oper,string operand)
        {
            var resultOperation = new Div(oper,operand);
            if (resultOperation.Status)
            return  Ok(resultOperation.Result);
            else 
            return BadRequest();
        }

    }
}