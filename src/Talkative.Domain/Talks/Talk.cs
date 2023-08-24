using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

using Talkative.Domain.Common.Interfaces;

namespace Talkative.Domain.Talks;

    public class Talk{
    
        public Guid Id {get; }

        public Guid CreatedBy{get; }

        public Guid SecondParty{get; }

        public DateTimeOffset CreatedDateTime { get; }

        private Talk(
         Guid createdBy,
         Guid secondParty,
         IDateTimeOffset dateTimeOffset,
         Guid id)
        {
            Id = id;
            CreatedBy = createdBy;
            SecondParty = secondParty;
            CreatedDateTime = dateTimeOffset;
        }

  public static Talk Create(Guid createdBy,
              Guid secondParty,
              DateTimeProvider dateTimeProvider,
              Guid? id = null)
              {
                return new(Guid.NewGuid()
                  createdBy,
                  secondParty,
                  dateTimeProvider.UtcNow());
              }
   {
       CreatedBy = createdBy;
        SecondParty = secondParty;
        CreatedDateTime = createdDateTime;
    }
    //or
    // => (CreatedBy,SecondParty,CreatedDateTime,Id) = (createdBy,secondParty,createdDateTime,Guid.NewGuid());

    
       
}
