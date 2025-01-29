import React from 'react'
import { Link } from 'react-router'

const WatchList = () => {
  return (
    <>
        <div className="tab-pane fade" id="sidebar-1-2" role="tabpanel" aria-labelledby="sidebar-1-2">
                  <div className="d-sm-flex align-items-center justify-content-between mb-3">
                    <h1 className="h5 mb-0 text-gray-900">Watchlist</h1>
                    <Link href="movies.html" className="d-none d-sm-inline-block text-xs">
                      Showing 97 of 97 items
                    </Link>
                  </div>

                  <div className="row">
                    <div className="col-xl-3 col-md-6 mb-4">
                      <div className="card m-card shadow border-0">
                        <Link href="movies-detail.html">
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
                              </small>{' '}
                            </p>
                          </div>
                          <div className="card-body pl-2 pr-2 pb-2 pt-0">
                            <button className="btn btn-danger btn-block btn-sm">
                              <i className="fas fa-trash"></i> Remove
                            </button>
                          </div>
                        </Link>
                      </div>
                    </div>
                    {/* Additional movie cards can be added here */}
                  </div>
                  <nav aria-label="Page navigation example">
                    <ul className="pagination justify-content-center mb-0 pb-0">
                      <li className="page-item disabled">
                        <Link className="page-link" href="#" tabIndex="-1" aria-disabled="true">
                          Previous
                        </Link>
                      </li>
                      <li className="page-item">
                        <Link className="page-link" href="#">
                          1
                        </Link>
                      </li>
                      <li className="page-item">
                        <Link className="page-link" href="#">
                          2
                        </Link>
                      </li>
                      <li className="page-item">
                        <Link className="page-link" href="#">
                          3
                        </Link>
                      </li>
                      <li className="page-item">
                        <Link className="page-link" href="#">
                          Next
                        </Link>
                      </li>
                    </ul>
                  </nav>
                </div>
    </>
  )
}

export default WatchList