import React from 'react'

const DetailMovieCard = ({movie}) => {
  return (
    <>
        <div className="bg-white p-3 widget shadow rounded mb-4">
            <img src={movie.imageUrl} className="img-fluid rounded" alt="..."/>
            <h1 className="h6 mb-0 mt-3 font-weight-bold text-gray-900">Director</h1>
            <p>J{movie.director}</p>
            <h1 className="h6 mb-0 mt-3 font-weight-bold text-gray-900">Cast</h1>
            <p>Tom Holland,Jake Gyllenhaal,Zendaya</p>
        </div>
    </>
  )
}

export default DetailMovieCard