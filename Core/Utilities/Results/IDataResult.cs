using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{//hem mesaj hem data
    public interface IDataResult<T>:IResult
    {
        //bool Success { get; }//sadece okunabilir //IResult dan gelir
        //string Message { get; }
        T Data { get; }//ek olarak data da var
    }
}
