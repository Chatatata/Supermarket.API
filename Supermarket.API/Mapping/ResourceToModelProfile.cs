﻿using AutoMapper;
using Supermarket.API.Attributes;
using Supermarket.API.Controllers.Forms;
using Supermarket.API.Domain.Models;
using Supermarket.API.Resources;

namespace Supermarket.API.Mapping
{
    [Injected]
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();

            CreateMap<QuestionForm, Question>()
                .ForMember(
                    src => src.MimeType,
                    opt => opt.MapFrom(src => src.MimeType)
                );
        }
    }
}
