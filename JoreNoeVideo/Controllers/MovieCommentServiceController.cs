using JoreNoeVideo.CommonInterFaces;
using JoreNoeVideo.Domain;
using JoreNoeVideo.DomainServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoreNoeVideo.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieCommentServiceController : ControllerBase
    {
        private readonly IMovieCommentDomainService MovieCommentDomainService;
        public MovieCommentServiceController(IMovieCommentDomainService MovieCommentDomainService)
        {
            this.MovieCommentDomainService = MovieCommentDomainService;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("AddMovieComment")]
        public async Task<ActionResult<APIReturnInFo<MovieComment>>> AddMovieComment(MovieComment model)
        {
            return APIReturnInFo<MovieComment>.Success(await this.MovieCommentDomainService.AddMovieComment(model));
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("AddMovieComment")]
        public async Task<ActionResult<APIReturnInFo<MovieComment>>> EditMovieComment(MovieComment model)
        {
            return APIReturnInFo<MovieComment>.Success(await this.MovieCommentDomainService.EditMovieComment(model));
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("{Id}/AddMovieComment")]
        public async Task<ActionResult<APIReturnInFo<MovieComment>>> RemovedMovieComment(Guid Id)
        {
            return APIReturnInFo<MovieComment>.Success(await this.MovieCommentDomainService.RemovedMovieComment(Id));
        }

        /// <summary>
        /// 查询单个
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("{Id}/AddMovieComment")]
        public async Task<ActionResult<APIReturnInFo<MovieComment>>> SingleMovieComment(Guid Id)
        {
            return APIReturnInFo<MovieComment>.Success(await this.MovieCommentDomainService.AddMovieComment(Id));
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("AddMovieComment")]
        public async Task<ActionResult<APIReturnInFo<IList<MovieComment>>>> AllMovieComment()
        {
            return APIReturnInFo<IList<MovieComment>>.Success(await this.MovieCommentDomainService.AllMovieComment());
        }

        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("AddMovieComment")]
        public async Task<ActionResult<APIReturnInFo<IList<MovieComment>>>> Pagin(int PageNum, int PageSize)
        {
            return APIReturnInFo<IList<MovieComment>>.Success(await this.MovieCommentDomainService.Pagin(PageNum,PageSize));
        }
    }
}
