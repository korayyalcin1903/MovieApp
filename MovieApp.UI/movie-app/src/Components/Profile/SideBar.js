import React from 'react'

const SideBar = () => {
  return (
    <div className="col-xl-3 col-lg-3">
            <div className="bg-white p-3 widget shadow rounded mb-4">
              <div className="nav nav-pills flex-column lavalamp" id="sidebar-1" role="tablist">
                <a
                  className="nav-link active"
                  data-toggle="tab"
                  href="#sidebar-1-1"
                  role="tab"
                  aria-controls="sidebar-1-1"
                  aria-selected="true"
                >
                  <i className="fas fa-user-circle fa-sm fa-fw mr-2 text-gray-400"></i> Profile
                </a>
                <a
                  className="nav-link"
                  data-toggle="tab"
                  href="#sidebar-1-2"
                  role="tab"
                  aria-controls="sidebar-1-2"
                  aria-selected="false"
                >
                  <i className="fas fa-heart fa-sm fa-fw mr-2 text-gray-400"></i> Watchlist
                </a>
                <a
                  className="nav-link"
                  data-toggle="tab"
                  href="#sidebar-1-4"
                  role="tab"
                  aria-controls="sidebar-1-4"
                  aria-selected="false"
                >
                  <i className="fas fa-cog fa-sm fa-fw mr-2 text-gray-400"></i> Account Settings
                </a>
                <a className="nav-link" href="#" data-toggle="modal" data-target="#logoutModal">
                  <i className="fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400"></i> Logout
                </a>
              </div>
            </div>
          </div>
  )
}

export default SideBar