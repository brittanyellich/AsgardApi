using AsgardApi.Repository.Entities;
using AsgardApi.Repository.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsgardApi.Service.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, ApplicationUser>();
            CreateMap<RegisterModel, User>();
            CreateMap<UpdateModel, User>();
        }
    }
}
