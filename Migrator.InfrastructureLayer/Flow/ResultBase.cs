using Migrator.ApplicationLayer.Flow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migrator.InfrastructureLayer.Flow
{
    class ResultBase : IResult
    {
        public string Message { get; }

        public DateTime CreatedAt { get; }

        public bool IsSuccessful { get; }

        public ResultBase(string message, bool isSuccessful)
        {
            Message = message;
            CreatedAt = DateTime.Now;
            IsSuccessful = isSuccessful;
        }

        public override string ToString() =>
            string.Format(
                "Result: {0}, Message: {1}, CreatedAt: {2}",
                IsSuccessful ? "success" : "failure",
                Message,
                CreatedAt
                );

        public new bool Equals(object o)
        {
            if(o != null && o is IResult res)
            {
                return Message == res.Message
                && IsSuccessful == res.IsSuccessful
                && CreatedAt == res.CreatedAt;
            }

            return false;
        }

            
    }
}
