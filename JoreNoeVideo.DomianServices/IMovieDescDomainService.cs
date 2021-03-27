using JoreNoeVideo.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JoreNoeVideo.DomainServices
{
    public interface IMovieDescDomainService
    {
        Task<MovieDesc> AddMovieDesc(MovieDesc model);
    }
}
