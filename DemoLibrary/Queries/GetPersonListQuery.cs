using DemoLibrary.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary.Queries
{
    // Records are like classes, but they are immutable by default
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;

    // This class definition is basically the same as the Record definition above, except it doesn't have the benefits of being a Record type
    /*public class GetPersonListQueryClass : IRequest<List<PersonModel>>
    {

    }*/
}
