import React from 'react'

const DetailHeadInfo = ({movie}) => {
  return (
    <>
        <div className="bg-white info-header shadow rounded mb-4">
            <div className="row d-flex align-items-center justify-content-between p-3 border-bottom">
                <div className="col-lg-7 m-b-4">
                    <h3 className="text-gray-900 mb-0 mt-0 font-weight-bold">{movie.title} <small>{new Date(movie.createdDate).getFullYear()}</small>
                    </h3>
                    <p className="mb-0 text-gray-800"><small className="text-muted"><i
                                className="fas fa-film fa-fw fa-sm mr-1"></i> {movie.categoryName}
                            </small></p>
                </div>
                <div className="col-lg-5 text-right">
                    <a href="#" className="d-sm-inline-block btn btn-primary shadow-sm"><i
                            className="fas fa-share-alt"></i></a>
                    <a href="#" className="d-sm-inline-block btn btn-danger shadow-sm"> Add to Watchlist <i
                            className="fas fa-plus fa-sm  ml-1"></i></a>
                </div>
            </div>
            <div className="row d-flex align-items-center justify-content-between py-3 px-4">
                <div className="col-lg-6 m-b-4">
                    <p className="mb-0 text-gray-900"><i className="fas fa-money-bill fa-sm fa-fw mr-1"></i> BUDGET - <span
                            className="text-white rounded px-2 py-1 bg-info">${movie.budget.toLocaleString('tr-TR')}</span></p>
                </div>
                <div className="col-lg-6 text-right">
                    <a href="#" className="btn btn-sm btn-primary btn-circle">
                        <i className="fab fa-facebook-f"></i>
                    </a>
                    <a href="#" className="btn btn-sm btn-danger btn-circle">
                        <i className="fab fa-youtube"></i>
                    </a>
                    <a href="#" className="btn btn-sm btn-warning btn-circle">
                        <i className="fab fa-snapchat-ghost"></i>
                    </a>
                    <a href="#" className="btn btn-sm btn-info btn-circle">
                        <i className="fab fa-twitter"></i>
                    </a>
                </div>
            </div>
        </div>
    </>
  )
}

export default DetailHeadInfo