import React from 'react';

const CastCard = ({cast}) => {
  return (
    <>
      <div className="col-xl-4 col-md-6 mb-4">
        <div className="card p-card shadow border-0">
          <a href="people-detail.html">
            <div className="row no-gutters">
              <div className="col-md-4">
                <img src={cast.imgUrl} className="card-img" style={{height: "200px"}} alt="..." />
              </div>
              <div className="col-md-8">
                <div className="card-body">
                  <h5 className="card-title text-gray-900">{cast.fullName}</h5>
                  <p className="card-text">
                    {cast.biography.length > 100 ? `${cast.biography.slice(0, 100)}...` : cast.biography}
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