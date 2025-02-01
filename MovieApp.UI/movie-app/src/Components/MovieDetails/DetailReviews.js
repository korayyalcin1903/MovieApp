import React from 'react'

const DetailReviews = () => {
return (
<>
    <div className="tab-pane fade" id="contact" role="tabpanel" aria-labelledby="contact-tab">
        <div className="card-body p-0 reviews-card">
            <div className="media mb-4">
                <img className="d-flex mr-3 rounded-circle" src="/img/s1.png" alt="" />
                <div className="media-body">
                    <div className="mt-0 mb-1">
                        <span className="h6 mr-2 font-weight-bold text-gray-900">Stave Martin</span>
                        <span><i className="fa fa-calendar"></i> Feb 12, 2018</span>
                        <div className="stars-rating float-right"> <i className="fa fa-star active"></i>
                            <i className="fa fa-star active"></i>
                            <i className="fa fa-star"></i>
                            <i className="fa fa-star"></i>
                            <i className="fa fa-star"></i> <span
                                className="rounded bg-warning text-dark pl-1 pr-1">5/3</span>
                        </div>
                    </div>
                    <p>Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante
                        sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra
                        turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue
                        felis in faucibus.</p>
                </div>
            </div>
            <div className="media">
                <img className="d-flex mr-3 rounded-circle" src="/img/s2.png" alt="" />
                <div className="media-body">
                    <div className="mt-0 mb-1">
                        <span className="h6 mr-2 font-weight-bold text-gray-900">Mark Smith</span> <span><i
                                className="fa fa-calendar"></i> Feb 12, 2018</span>
                        <div className="stars-rating float-right"> <i className="fa fa-star active"></i>
                            <i className="fa fa-star active"></i>
                            <i className="fa fa-star"></i>
                            <i className="fa fa-star"></i>
                            <i className="fa fa-star"></i> <span
                                className="rounded bg-warning text-dark pl-1 pr-1">5/3</span>
                        </div>
                    </div>
                    <p>Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque ante
                        sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus viverra
                        turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec lacinia congue
                        felis in faucibus.</p>
                    <div className="media mt-4">
                        <img className="d-flex mr-3 rounded-circle" src="/img/s3.png" alt="" />
                        <div className="media-body">
                            <div className="mt-0 mb-1">
                                <span className="h6 mr-2 font-weight-bold text-gray-900">Ryan Printz</span>
                                <span><i className="fa fa-calendar"></i> Feb 12, 2018</span>
                                <div className="stars-rating float-right"> <i className="fa fa-star active"></i>
                                    <i className="fa fa-star active"></i>
                                    <i className="fa fa-star"></i>
                                    <i className="fa fa-star"></i>
                                    <i className="fa fa-star"></i> <span
                                        className="rounded bg-warning text-dark pl-1 pr-1">5/3</span>
                                </div>
                            </div>
                            <p>Cras sit amet nibh libero, in gravida nulla. Nulla vel metus scelerisque
                                ante sollicitudin. Cras purus odio, vestibulum in vulputate at, tempus
                                viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla.
                                Donec lacinia congue felis in faucibus.</p>
                        </div>
                    </div>
                </div>
            </div>
            <div className="media mt-4">
                <img className="d-flex mr-3 rounded-circle" src="/img/s4.png" alt="" />
                <div className="media-body">
                    <div className="mt-0 mb-1">
                        <span className="h6 mr-2 font-weight-bold text-gray-900">Stave Mark</span> <span><i
                                className="fa fa-calendar"></i> Feb 12, 2018</span>
                        <div className="stars-rating float-right"> <i className="fa fa-star active"></i>
                            <i className="fa fa-star active"></i>
                            <i className="fa fa-star"></i>
                            <i className="fa fa-star"></i>
                            <i className="fa fa-star"></i> <span
                                className="rounded bg-warning text-dark pl-1 pr-1">5/3</span>
                        </div>
                    </div>
                    <p className="mb-0">Cras sit amet nibh libero, in gravida nulla. Nulla vel metus
                        scelerisque ante sollicitudin. Cras purus odio, vestibulum in vulputate at,
                        tempus viverra turpis. Fusce condimentum nunc ac nisi vulputate fringilla. Donec
                        lacinia congue felis in faucibus.</p>
                </div>
            </div>
        </div>
        <div className="p-4 bg-light rounded mt-4">
            <h5 className="card-title mb-4">Leave a Review</h5>
            <form name="sentMessage">
                <div className="row">
                    <div className="control-group form-group col-lg-4 col-md-4">
                        <div className="controls">
                            <label>Your Name <span className="text-danger">*</span></label>
                            <input type="text" className="form-control" required="" />
                        </div>
                    </div>
                    <div className="control-group form-group col-lg-4 col-md-4">
                        <div className="controls">
                            <label>Your Email <span className="text-danger">*</span></label>
                            <input type="email" className="form-control" required="" />
                        </div>
                    </div>
                    <div className="control-group form-group col-lg-4 col-md-4">
                        <div className="controls">
                            <label>Rating <span className="text-danger">*</span></label>
                            <select className="form-control custom-select">
                                <option>1 Star</option>
                                <option>2 Star</option>
                                <option>3 Star</option>
                                <option>4 Star</option>
                                <option>5 Star</option>
                            </select>
                        </div>
                    </div>
                </div>
                <div className="control-group form-group">
                    <div className="controls">
                        <label>Review <span className="text-danger">*</span></label>
                        <textarea rows="3" cols="100" className="form-control"></textarea>
                    </div>
                </div>
                <div className="text-right">
                    <button type="submit" className="btn btn-primary">Send Message</button>
                </div>
            </form>
        </div>
    </div>
</>
)
}

export default DetailReviews