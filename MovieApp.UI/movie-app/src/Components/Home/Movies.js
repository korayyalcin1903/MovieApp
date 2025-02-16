import React, { useContext, useEffect, useState } from 'react'
import { Link } from 'react-router'
import MovieCard from '../MovieCard'
import { ConstantAPIContext } from '../../context/ConstantAPIContext'

const Movies = () => {
    const {movieList} = useContext(ConstantAPIContext)

  return (
    <>
        <div className="d-sm-flex align-items-center justify-content-between mt-4 mb-3">
          <h1 className="h5 mb-0 text-gray-900">Movies</h1>
          <Link href="movies.html" className="d-none d-sm-inline-block text-xs">View All <i className="fas fa-eye fa-sm"></i></Link>
        </div>

        <div className="row">
          {
            movieList.length > 0 ? (
              movieList.map((movie) => (
              <MovieCard key={movie.id} movie={movie} />
            ))) : (<h3>Film bulunamadı</h3>) 
          }
        </div>

    </>
  )
}

export default Movies