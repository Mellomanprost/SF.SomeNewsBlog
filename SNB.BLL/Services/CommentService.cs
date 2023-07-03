﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SNB.BLL.Services.IServices;
using SNB.BLL.ViewModels.Comments;
using SNB.DAL.Models;
using SNB.DAL.Repositories.IRepositories;

namespace SNB.BLL.Services
{
    public class CommentService : ICommentService
    {
        public IMapper _mapper;
        private readonly ICommentRepository _commentRepo;
        private readonly UserManager<User> _userManager;

        public CommentService(IMapper mapper, ICommentRepository commentRepo, UserManager<User> userManager)
        {
            _mapper = mapper;
            _commentRepo = commentRepo;
            _userManager = userManager;
        }

        public async Task<Guid> CreateComment(CommentCreateViewModel model, Guid userId)
        {
            var comment = new Comment
            {
                Content = model.Content,
                UserLogin = model.Author,
                PostId = model.PostId,
                UserId = userId,
                //AuthorName = _userManager.FindByIdAsync(userId.ToString()).Result.Login,
            };

            await _commentRepo.AddComment(comment);

            return comment.Id;
        }

        public async Task<CommentEditViewModel> EditComment(Guid id)
        {
            var comment = _commentRepo.GetComment(id);

            var result = new CommentEditViewModel
            {
                Content = comment.Content,
                Author = comment.UserLogin,
            };

            return result;
        }

        public async Task EditComment(CommentEditViewModel model, Guid id)
        {
            var comment = _commentRepo.GetComment(id);

            comment.Content = model.Content;
            comment.UserLogin = model.Author;

            await _commentRepo.UpdateComment(comment);
        }

        public async Task RemoveComment(Guid id)
        {
            await _commentRepo.RemoveComment(id);
        }

        public async Task<List<Comment>> GetComments()
        {
            return _commentRepo.GetAllComments().ToList();
        }
    }
}
