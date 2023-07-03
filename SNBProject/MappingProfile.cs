using AutoMapper;
using SNB.BLL.ViewModels.Comments;
using SNB.BLL.ViewModels.Posts;
using SNB.BLL.ViewModels.Tags;
using SNB.BLL.ViewModels.Users;
using SNB.DAL.Models;

namespace SNBProject
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserRegisterViewModel, User>()
                .ForMember(x => x.Email, opt => opt.MapFrom(c => c.Email))
                .ForMember(x => x.Login, opt => opt.MapFrom(c => c.Login));

            CreateMap<CommentCreateViewModel, Comment>();
            CreateMap<CommentEditViewModel, Comment>();
            CreateMap<PostCreateViewModel, Post>();
            CreateMap<PostEditViewModel, Post>();
            CreateMap<TagCreateViewModel, Tag>();
            CreateMap<TagEditViewModel, Tag>();
            CreateMap<UserEditViewModel, User>();
        }
    }
}
