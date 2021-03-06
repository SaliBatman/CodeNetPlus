using CodeNet.Domain.Entities;
using CodeNet.Domain.Mappers.Interfaces;
using CodeNet.Domain.Requests;
using CodeNet.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Mappers
{
    public class NoteTypeMapper : INoteTypeMapper
    {
         public NoteTypeResponse Map(NoteType source)
        {
            return new NoteTypeResponse
            {
                Id = source.Id,
                Name = source.Name,
                UserId = source.UserId,
            };
        }

        public NoteType Map(NoteTypeRequest source)
        {
            return new NoteType
            {
                Id = source.Id,
                Name = source.Name,
                UserId = source.UserId,
            };
        }
    }
}
