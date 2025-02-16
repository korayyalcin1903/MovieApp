import React from 'react'

const Profile = ({user}) => {
  return (
    <>
        <div
                  className="tab-pane fade show active"
                  id="sidebar-1-1"
                  role="tabpanel"
                  aria-labelledby="sidebar-1-1"
                >
                  <div className="d-sm-flex align-items-center justify-content-between mb-3">
                    <h1 className="h5 mb-0 text-gray-900">Profile</h1>
                  </div>
                  {
                    user && (
                      <div className="row gutter-1">
                        <div className="col-md-12">
                          <div className="form-group">
                            <label htmlFor="exampleInput1">Id</label>
                            <input id="exampleInput1" type="text" value={user.sub ? user.sub : ""} className="form-control" placeholder="First name" readOnly/>
                          </div>
                        </div>
                        <div className="col-md-6">
                          <div className="form-group">
                            <label htmlFor="exampleInput1">First Name</label>
                            <input id="exampleInput1" type="text" value={user.FirstName ? user.FirstName : ""} className="form-control" placeholder="First name" />
                          </div>
                        </div>
                        <div className="col-md-6">
                          <div className="form-group">
                            <label htmlFor="exampleInput2">Last Name</label>
                            <input id="exampleInput2" type="text" value={user.LastName ? user.LastName : ""} className="form-control" placeholder="Last name" />
                          </div>
                        </div>
                        <div className="col-md-6">
                          <div className="form-group">
                            <label htmlFor="exampleInput4">Email</label>
                            <input id="exampleInput4" value={user.email ? user.email : ""} type="text" className="form-control" placeholder="Email" />
                          </div>
                        </div>
                        <div className="col-md-3">
                          <div className="form-group">
                            <label htmlFor="exampleInput3">Username</label>
                            <input id="exampleInput3" type="text" value={user.unique_name ? user.unique_name : ""} className="form-control" placeholder="Username" />
                          </div>
                        </div>
                        <div className="col-md-3">
                          <div className="form-group">
                            <label htmlFor="exampleInput5">Zip</label>
                            <input id="exampleInput5" type="text" className="form-control" placeholder="Zip" />
                          </div>
                        </div>
                        <div className="col-md-6">
                          <div className="form-group">
                            <label htmlFor="exampleInput6">Telephone</label>
                            <input id="exampleInput6" type="text" className="form-control" placeholder="Telephone" />
                          </div>
                        </div>
                        <div className="col-md-6">
                          <div className="form-group">
                            <label htmlFor="exampleInput7">Email</label>
                            <input id="exampleInput7" type="text" className="form-control" placeholder="Email" />
                          </div>
                        </div>
                      </div>
                    )
                  }
                  <div className="row">
                    <div className="col">
                      <a href="#!" className="btn btn-primary">
                        Save Changes
                      </a>
                    </div>
                  </div>
                </div>
    </>
  )
}

export default Profile