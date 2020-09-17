﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RVCoreBoard.MVC.Models;
using RVCoreBoard.MVC.Services;
using static RVCoreBoard.MVC.Models.BoardListInfoModel;

namespace RVCoreBoard.MVC.Factorys
{
    internal class Comment : SearchBase
    {
        public Comment(IBoardService boardService) : base(boardService)
        {
        }

        public override async Task<List<Board>> Search(int id, string searchString)
        {
            return await base.BoardService.GetBoardList(s => s.category.Id == id && s.CommentList.Any(c => c.Content.Contains(searchString)));
        }
    }
}
