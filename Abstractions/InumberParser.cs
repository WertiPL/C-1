using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNCalulator.Abstractions;

public interface INumbersParser
{
    public bool TryNum(String e, out int r);
}