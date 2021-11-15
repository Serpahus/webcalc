using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAcalc.Models;


namespace WebAcalc.Serivces
{
    public class CalcServices: ICalcServices
    {
        public float sum(ArgumentModels items)
        {
            float result = items.arg1 + items.arg2;

            return result;
        }

        public float sub(ArgumentModels items)
        {
            var result = items.arg1 - items.arg2;

            return result;
        }

        public float mult(ArgumentModels items)
        {
            var result = items.arg1 * items.arg2;

            return result;
        }

        public float div(ArgumentModels items)
        {
            var result = items.arg1 / items.arg2;

            return result;
        }
    }
}
