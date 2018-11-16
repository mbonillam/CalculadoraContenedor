using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CalDocker.Operations
{
    public class Operation{
        public bool Status = true;
        public double Result = 0;
    }
    public class Sum:Operation {
        public Sum (string operators){
            var operatorList = operators.Split("/");
            Status = operatorList.Count() >= 2 ? true : false;
            if (Status){
                foreach(string oper in operatorList)
                {
                    Result = Result + Convert.ToDouble(oper);
                }
            }
        }
    }

    public class Minus:Operation {
        public Minus (string oper, string operand){
            Result = Convert.ToDouble(oper) - Convert.ToDouble(operand);
        }
    }

    public class Multi:Operation {
        public Multi (string oper, string operand){
            Result = Convert.ToDouble(oper) * Convert.ToDouble(operand);
        }
    }

    public class Div:Operation {
    public Div (string oper, string operand){
        Status = Convert.ToDouble(operand) != 0 ? true : false;
        if (Status){
                Result = Convert.ToDouble(oper) / Convert.ToDouble(operand);
            }
        }
    }
}