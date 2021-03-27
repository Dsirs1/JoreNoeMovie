using JoreNoeVideo.CommonInterFaces;
using JoreNoeVideo.Domain.Models;
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
    public class MovieCollectionsServiceController : ControllerBase
    {
        private readonly IMovieCollectionsDomainService MovieCollectionsDomainService;
        public MovieCollectionsServiceController(IMovieCollectionsDomainService MovieCollectionsDomainService)
        {
            this.MovieCollectionsDomainService = MovieCollectionsDomainService;
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost("AddMovieCollectionsDomain")]
        public async Task<ActionResult<APIReturnInFo<MovieCollections>>> AddMovieCollections(MovieCollections model)
        {
            return APIReturnInFo<MovieCollections>.Success(await this.MovieCollectionsDomainService.AddMovieCollections(model));
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpDelete("{Id}/RemovedMovieCollectionsDomain")]
        public async Task<ActionResult<APIReturnInFo<MovieCollections>>> RemovedMovieCollections(Guid Id)
        {
            return APIReturnInFo<MovieCollections>.Success(await this.MovieCollectionsDomainService.RemovedMovieCollections(Id));
        }

        /// <summary>
        /// 编辑
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPut("EditMovieCollectionsDomain")]
        public async Task<ActionResult<APIReturnInFo<MovieCollections>>> EditMovieCollections(MovieCollections model)
        {
            return APIReturnInFo<MovieCollections>.Success(await this.MovieCollectionsDomainService.EditMovieCollections(model));
        }

        /// <summary>
        /// 查询单个
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("{Id}/SingleMovieCollectionsDomain")]
        public async Task<ActionResult<APIReturnInFo<MovieCollections>>> SingleMovieCollections(Guid Id)
        {
            return APIReturnInFo<MovieCollections>.Success(await this.MovieCollectionsDomainService.SingleMovieCollections(Id));
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("{Id}/SingleMovieCollectionsDomain")]
        public async Task<ActionResult<APIReturnInFo<IList<MovieCollections>>>> AllMovieCollections()
        {
            return APIReturnInFo<IList<MovieCollections>>.Success(await this.MovieCollectionsDomainService.AllMovieCollections());
        }

        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet("{Id}/SingleMovieCollectionsDomain")]
        public async Task<ActionResult<APIReturnInFo<IList<MovieCollections>>>> Pagin(int PageNum, int PageSize)
        {
            return APIReturnInFo<IList<MovieCollections>>.Success(await this.MovieCollectionsDomainService.Pagin(PageNum,PageSize));
        }
    }
}
