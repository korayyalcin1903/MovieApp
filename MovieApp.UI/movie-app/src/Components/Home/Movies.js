import React, { useEffect, useState } from 'react'
import { Link } from 'react-router'
import MovieCard from '../MovieCard'

const Movies = () => {
    const [movies, setMovies] = useState([]);

    useEffect(() => {
       fetch("https://localhost:7265/api/Movie")
            .then(response => response.json())
            .then(data => setMovies(data))
    }, [movies])

  return (
    <>
        <div className="d-sm-flex align-items-center justify-content-between mt-4 mb-3">
          <h1 className="h5 mb-0 text-gray-900">Movies</h1>
          <Link href="movies.html" className="d-none d-sm-inline-block text-xs">View All <i className="fas fa-eye fa-sm"></i></Link>
        </div>

        <div className="row">
          {
            movies.map((movie) => (
              <MovieCard key={movie.id} movie={movie} />
            ))
          }
        </div>
    </>
  )
}

export default Movies