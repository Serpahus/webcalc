using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAcalc.Models;

namespace WebAcalc.Serivces
{
    public interface ICalcServices
    {
        float sum(ArgumentModels items);
        float sub(ArgumentModels items);
        float mult(ArgumentModels items);
        float div(ArgumentModels items);
    }
}
