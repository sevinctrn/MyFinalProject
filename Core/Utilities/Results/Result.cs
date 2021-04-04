using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
      

        public Result(bool success, string message):this(success)
        {
            //construtor da read ile set edebiliyoruz.
            Message = message;
          //  Success = success;
        }
        public Result(bool success)
        {
            //construtor da read ile set edebiliyoruz.
        
            Success = success;
        }
        // public bool Success => throw new NotImplementedException();

        //  public string Message => throw new NotImplementedException();

        public bool Success {  get; }

        public string Message { get; }
    }
}
