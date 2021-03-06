using CodeNet.Domain.Entities;
using CodeNet.Domain.Mappers.Interfaces;
using CodeNet.Domain.Requests;
using CodeNet.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Mappers
{
    public class SpecificSubjectMapper : ISpecificSubjectMapper
    {
         public SpecificSubjectResponse Map(SpecificSubject source)
        {
            return new SpecificSubjectResponse
            {
                Id = source.Id,
                Name = source.Name,
                GeneralSubjectId = source.GeneralSubjectId,
            };
        }

        public SpecificSubject Map(SpecificSubjectRequest source)
        {
            return new SpecificSubject
            {
                Id = source.Id,
                Name = source.Name,
                GeneralSubjectId = source.GeneralSubjectId,
            };
        }
    }
}
