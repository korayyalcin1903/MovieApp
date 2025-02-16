import React, { useContext, useEffect, useState } from "react";
import Footer from "./Footer";
import { Link, useNavigate } from "react-router";
import StorageService from "../../services/StorageService";

const Main = ({ children }) => {
  const [query, setQuery] = useState("");
  const navigate = useNavigate();
  let user = StorageService.getUserInfo();

  const handleSearch = () => {
    navigate(`/filter?query=${query}`);
  };

  return (
    <div id="content-wrapper" className="d-flex flex-column">
      <div id="content">
        <nav className="navbar navbar-expand navbar-dark topbar mb-4 pl-0 static-top shadow">
          <button
            id="sidebarToggleTop"
            className="btn btn-link d-md-none rounded-circle mr-3"
          >
            <i className="fa fa-bars"></i>
          </button>
          <form className="d-none d-sm-inline-block form-inline mr-auto my-2 my-md-0 mw-100 navbar-search">
            <div className="input-group">
              <input
                type="text"
                className="form-control bg-white border-0 small"
                placeholder="Search for Movies, Events, Plays, Sports and Activities..."
                aria-label="Search"
                aria-describedby="basic-addon2"
                onChange={(e) => setQuery(e.target.value)}
              />
              <div className="input-group-append">
                <button
                  className="btn bg-white"
                  type="button"
                  onClick={handleSearch}
                >
                  <i className="fas fa-search fa-sm"></i>
                </button>
              </div>
            </div>
          </form>
          <ul className="navbar-nav ml-auto">
            <li className="nav-item dropdown no-arrow d-sm-none">
              <Link
                className="nav-link dropdown-toggle"
                href="#"
                id="searchDropdown"
                role="button"
                data-toggle="dropdown"
                aria-haspopup="true"
                aria-expanded="false"
              >
                <i className="fas fa-search fa-fw"></i>
              </Link>

              <div
                className="dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in"
                aria-labelledby="searchDropdown"
              >
                <form className="form-inline mr-auto w-100 navbar-search">
                  <div className="input-group">
                    <input
                      type="text"
                      className="form-control bg-light border-0 small"
                      placeholder="Search for..."
                      aria-label="Search"
                      aria-describedby="basic-addon2"
                    />
                    <div className="input-group-append">
                      <button className="btn btn-primary" type="button">
                        <i className="fas fa-search fa-sm"></i>
                      </button>
                    </div>
                  </div>
                </form>
              </div>
            </li>

            <li className="nav-item no-arrow mx-1">
              <Link className="nav-link" href="offers.html">
                <i className="fas fa-fire fa-fw"></i>

                <span className="badge badge-danger bg-gradient-danger">
                  NEW
                </span>
              </Link>
            </li>
            <li className="nav-item dropdown no-arrow mx-1">
              <Link
                className="nav-link dropdown-toggle"
                href="#"
                id="alertsDropdown"
                role="button"
                data-toggle="dropdown"
                aria-haspopup="true"
                aria-expanded="false"
              >
                <i className="fas fa-bell fa-fw"></i>

                <span className="badge badge-danger badge-counter">8+</span>
              </Link>

              <div
                className="dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in"
                aria-labelledby="alertsDropdown"
              >
                <h6 className="dropdown-header">Alerts</h6>

                <Link
                  className="dropdown-item text-center small text-gray-500"
                  href="#"
                >
                  Show All Alerts
                </Link>
              </div>
            </li>

            <li className="nav-item dropdown no-arrow d-flex">
              {user ? (
                <>
                  <Link
                    className="nav-link dropdown-toggle"
                    href="#"
                    id="userDropdown"
                    role="button"
                    data-toggle="dropdown"
                    aria-haspopup="true"
                    aria-expanded="false"
                  >
                    <span className="mr-2 d-none d-lg-inline text-gray-600 small">
                      {user.FirstName.toUpperCase()} {user.LastName.toUpperCase()}
                    </span>
                    <img
                      className="img-profile rounded-circle"
                      src="/img/s4.png"
                    />
                  </Link>

                  <div
                    className="dropdown-menu dropdown-menu-right shadow animated--grow-in"
                    aria-labelledby="userDropdown"
                  >
                    <Link className="dropdown-item" to="/profile">
                      <i className="fas fa-user-circle fa-sm fa-fw mr-2 text-gray-400"></i>
                      Profile
                    </Link>
                    <Link className="dropdown-item" to="/profile">
                      <i className="fas fa-heart fa-sm fa-fw mr-2 text-gray-400"></i>
                      Watchlist
                    </Link>
                    <Link className="dropdown-item" to="/profile">
                      <i className="fas fa-list-alt fa-sm fa-fw mr-2 text-gray-400"></i>
                      Your Lists
                    </Link>
                    <Link className="dropdown-item" to="/profile">
                      <i className="fas fa-cog fa-sm fa-fw mr-2 text-gray-400"></i>
                      Account Settings
                    </Link>
                    <div className="dropdown-divider"></div>
                    <Link
                      className="dropdown-item"
                      to="/logout"
                      data-toggle="modal"
                      data-target="#logoutModal"
                    >
                      <i className="fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400"></i>
                      Logout
                    </Link>
                  </div>
                </>
              ) : (
                <>
                  <Link to="/login" className="nav-link dropdown-toggle">Login</Link>
                  <Link to="/register" className="nav-link dropdown-toggle">Register</Link>
                </>
              )}
            </li>
          </ul>
        </nav>

        {children}
      </div>

      <Footer />
    </div>
  );
};

export default Main;
