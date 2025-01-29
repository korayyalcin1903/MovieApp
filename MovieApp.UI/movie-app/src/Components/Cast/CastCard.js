import React from 'react';

const CastCard = () => {
  return (
    <>
      <div className="col-xl-4 col-md-6 mb-4">
        <div className="card p-card shadow border-0">
          <a href="people-detail.html">
            <div className="row no-gutters">
              <div className="col-md-4">
                <img src="img/p1.jpg" className="card-img" alt="..." />
              </div>
              <div className="col-md-8">
                <div className="card-body">
                  <h5 className="card-title text-gray-900">Carla Gugino</h5>
                  <p className="card-text">
                    Carla was born in Sarasota, Florida. Moved with her mother to Paradise,
                    California, when Carla was just five years old...
                  </p>
                  <p className="card-text">
                    <small>
                      <span className="text-muted pr-2">
                        <i className="fas fa-film fa-sm ml-1"></i> Acting
                      </span>{' '}
                      <span className="text-link">Batman v Superman: Dawn of Justice (2016)</span>
                    </small>
                  </p>
                </div>
              </div>
            </div>
          </a>
        </div>
      </div>
    </>
  );
};

export default CastCard;