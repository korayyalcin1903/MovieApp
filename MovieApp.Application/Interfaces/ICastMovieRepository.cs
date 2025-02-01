using MovieApp.Application.Dtos.CastDtos;
using MovieApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp.Application.Interfaces
{
    public interface ICastMovieRepository: IGenericRepository<MovieCast>
    {
        Task<int> AddMovieCast(AddCastToMovieDto dto);
        Task<List<GetAllCastDto>> GetAllCastByMovieId(string id);
    }
}
