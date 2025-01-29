import React from 'react';

const MovieCard = () => {
  return (
    <>
      <div className="col-xl-4 col-md-6 mb-4">
        <div className="card m-card shadow border-0">
          <a href="movies-detail.html">
            <div className="m-card-cover">
              <div className="position-absolute bg-white shadow-sm rounded text-center p-2 m-2 love-box">
                <h6 className="text-gray-900 mb-0 font-weight-bold">
                  <i className="fas fa-heart text-danger"></i> 88%
                </h6>
                <small className="text-muted">23,421</small>
              </div>
              <img src="img/m1.jpg" className="card-img-top" alt="..." />
            </div>
            <div className="card-body p-3">
              <h5 className="card-title text-gray-900 mb-1">Jumanji: The Next Level</h5>
              <p className="card-text">
                <small className="text-muted">English</small>{' '}
                <small className="text-danger">
                  <i className="fas fa-calendar-alt fa-sm text-gray-400"></i> 22 AUG
                </small>
              </p>
            </div>
          </a>
        </div>
      </div>
    </>
  );
};

export default MovieCard;