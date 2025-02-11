﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewsApp.Contracts;
using NewsApp.Contracts.Dtos;

namespace NewsApp.Business.Interfaces
{
    public interface ICommentService
    {
        Task AddAsync(AddCommentDto commentDto);
        Task<PagedResponseModel<CommentsDto>> GetAllCommentByNewsAsync(PageFilter filter);
        Task UpdateAsync(EditCommentDto commentDto);
        Task DeleteAsync(CommentsDto commentDto);
    }
}
