import React from 'react'
import { Link } from 'react-router'

const Movies = () => {
  return (
    <>
        <div className="d-sm-flex align-items-center justify-content-between mt-4 mb-3">
          <h1 className="h5 mb-0 text-gray-900">Movies</h1>
          <Link href="movies.html" className="d-none d-sm-inline-block text-xs">View All <i className="fas fa-eye fa-sm"></i></Link>
        </div>

        <div className="row">
          <div className="col-xl-3 col-md-6 mb-4">
            <div className="card m-card shadow border-0">
              <Link href="movies-detail.html">
                <div className="m-card-cover">
                  <div className="position-absolute bg-white shadow-sm rounded text-center p-2 m-2 love-box">
                    <h6 className="text-gray-900 mb-0 font-weight-bold"><i className="fas fa-heart text-danger"></i> 88%</h6>
                    <small className="text-muted">23,421</small>
                  </div>
                  <img src="img/m1.jpg" className="card-img-top" alt="..." />
                </div>
                <div className="card-body p-3">
                  <h5 className="card-title text-gray-900 mb-1">Jumanji: The Next Level</h5>
                  <p className="card-text"><small className="text-muted">English</small> <small className="text-danger"><i className="fas fa-calendar-alt fa-sm text-gray-400"></i> 22 AUG</small> </p>
                </div>
              </Link>
            </div>
          </div>
          <div className="col-xl-3 col-md-6 mb-4">
            <div className="card m-card shadow border-0">
              <Link href="movies-detail.html">
                <div className="m-card-cover">
                  <div className="position-absolute bg-white shadow-sm rounded text-center p-2 m-2 love-box">
                    <h6 className="text-gray-900 mb-0 font-weight-bold"><i className="fas fa-heart text-danger"></i> 50%</h6>
                    <small className="text-muted">8,784</small>
                  </div>
                  <img src="img/m2.jpg" className="card-img-top" alt="..." />
                </div>
                <div className="card-body p-3">
                  <h5 className="card-title text-gray-900 mb-1">Gemini Man</h5>
                  <p className="card-text"><small className="text-muted">English</small> <small className="text-danger"><i className="fas fa-calendar-alt fa-sm text-gray-400"></i> 22 AUG</small> </p>
                </div>
              </Link>
            </div>
          </div>
          <div className="col-xl-3 col-md-6 mb-4">
            <div className="card m-card shadow border-0">
              <Link href="movies-detail.html">
                <div className="m-card-cover">
                  <div className="position-absolute bg-white shadow-sm rounded text-center p-2 m-2 love-box">
                    <h6 className="text-gray-900 mb-0 font-weight-bold"><i className="fas fa-heart text-danger"></i> 20%</h6>
                    <small className="text-muted">69,123</small>
                  </div>
                  <img src="img/m3.jpg" className="card-img-top" alt="..." />
                </div>
                <div className="card-body p-3">
                  <h5 className="card-title text-gray-900 mb-1">The Current War</h5>
                  <p className="card-text"><small className="text-muted">English</small> <small className="text-danger"><i className="fas fa-calendar-alt fa-sm text-gray-400"></i> 22 AUG</small> </p>
                </div>
              </Link>
            </div>
          </div>
          <div className="col-xl-3 col-md-6 mb-4">
            <div className="card m-card shadow border-0">
              <Link href="movies-detail.html">
                <div className="m-card-cover">
                  <div className="position-absolute bg-white shadow-sm rounded text-center p-2 m-2 love-box">
                    <h6 className="text-gray-900 mb-0 font-weight-bold"><i className="fas fa-heart text-danger"></i> 74%</h6>
                    <small className="text-muted">88,865</small>
                  </div>
                  <img src="img/m4.jpg" className="card-img-top" alt="..." />
                </div>
                <div className="card-body p-3">
                  <h5 className="card-title text-gray-900 mb-1">Charlie's Angels</h5>
                  <p className="card-text"><small className="text-muted">English</small> <small className="text-danger"><i className="fas fa-calendar-alt fa-sm text-gray-400"></i> 22 AUG</small> </p>
                </div>
              </Link>
            </div>
          </div>
        </div>

        <div className="d-sm-flex align-items-center justify-content-between mt-1 mb-3">
          <h1 className="h5 mb-0 text-gray-900">Collections</h1>
        </div>

        <div className="row">
          <div className="col-xl-12 col-md-12 mb-4">
            <div className="collections-slider slick-initialized slick-slider">
              <button className="slick-prev slick-arrow" aria-label="Previous" type="button">Previous</button>
              <div className="slick-list draggable">
                <div className="slick-track" style={{ opacity: 1, width: "3268px", transform: 'translate3d(-1204px, 0px, 0px)' }}>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide slick-cloned" data-slick-index="-5" aria-hidden="true" tabIndex="-1" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="-1"><img src="img/c3.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide slick-cloned" data-slick-index="-4" aria-hidden="true" tabIndex="-1" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="-1"><img src="img/c4.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide slick-cloned" data-slick-index="-3" aria-hidden="true" tabIndex="-1" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="-1"><img src="img/c5.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide slick-cloned" data-slick-index="-2" aria-hidden="true" tabIndex="-1" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="-1"><img src="img/c2.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide slick-cloned" data-slick-index="-1" aria-hidden="true" tabIndex="-1" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="-1"><img src="img/c3.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide" data-slick-index="0" aria-hidden="true" tabIndex="-1" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="-1"><img src="img/c1.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide" data-slick-index="1" aria-hidden="true" tabIndex="-1" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="-1"><img src="img/c2.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide slick-current slick-active" data-slick-index="2" aria-hidden="false" tabIndex="0" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="0"><img src="img/c3.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide slick-active" data-slick-index="3" aria-hidden="false" tabIndex="0" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="0"><img src="img/c4.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide slick-active" data-slick-index="4" aria-hidden="false" tabIndex="0" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="0"><img src="img/c5.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide slick-active" data-slick-index="5" aria-hidden="false" tabIndex="0" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="0"><img src="img/c2.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide slick-active" data-slick-index="6" aria-hidden="false" tabIndex="0" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="0"><img src="img/c3.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide slick-cloned" data-slick-index="7" aria-hidden="true" tabIndex="-1" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="-1"><img src="img/c1.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide slick-cloned" data-slick-index="8" aria-hidden="true" tabIndex="-1" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="-1"><img src="img/c2.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide slick-cloned" data-slick-index="9" aria-hidden="true" tabIndex="-1" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="-1"><img src="img/c3.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide slick-cloned" data-slick-index="10" aria-hidden="true" tabIndex="-1" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="-1"><img src="img/c4.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide slick-cloned" data-slick-index="11" aria-hidden="true" tabIndex="-1" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="-1"><img src="img/c5.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide slick-cloned" data-slick-index="12" aria-hidden="true" tabIndex="-1" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="-1"><img src="img/c2.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                  <div className="card c-card shadow border-0 overflow-hidden slick-slide slick-cloned" data-slick-index="13" aria-hidden="true" tabIndex="-1" style={{ width: "156px"}}>
                    <Link href="#" tabIndex="-1"><img src="img/c3.jpg" className="img-fluid" alt="..." /></Link>
                  </div>
                </div>
              </div>
              <button className="slick-next slick-arrow" aria-label="Next" type="button">Next</button>
            </div>
          </div>
        </div>
    </>
  )
}

export default Movies