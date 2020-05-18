using AutoMapper;
using Komunumo.Admin.Entities;
using Komunumo.Admin.Models.ManageViewModels;

namespace Komunumo.Admin.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>()
                .ForMember(dest => dest.Id, 
                    opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.UserName,
                    opt => opt.MapFrom(src => src.UserName))
                .ForMember(dest => dest.Email,
                    opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.EmailConfirmed,
                    opt => opt.MapFrom(src => src.EmailConfirmed))
                .ForMember(dest => dest.PhoneNumber,
                    opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.PhoneNumberConfirmed,
                    opt => opt.MapFrom(src => src.PhoneNumberConfirmed))
                .ForMember(dest => dest.LockoutEnd,
                    opt => opt.MapFrom(src => src.LockoutEnd))
                .ForMember(dest => dest.LockoutEnabled,
                    opt => opt.MapFrom(src => src.LockoutEnabled))
                .ForMember(dest => dest.AccessFailedCount,
                    opt => opt.MapFrom(src => src.AccessFailedCount));
        }
    }
}