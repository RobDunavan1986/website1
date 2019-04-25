using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOnProject.Domain.Entities
{
  public  class Error
    {
      public  Guid Id { get; set; }
      public  DateTime ErrorDateTime { get; set; }
     public   string ErrorMessage { get; set; }
      public  string StackTrace { get; set; }
     public   string InnerException { get; set; }
    }
}
