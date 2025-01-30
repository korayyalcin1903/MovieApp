import React, { useState } from 'react';
import Footer from './Footer';
import { Link, useNavigate } from 'react-router';

const Main = ({ children }) => {
const [query, setQuery] = useState('');
const navigate = useNavigate();

const handleSearch = () => {
navigate(`/filter?query=${query}`)
}

return (
<div id="content-wrapper" className="d-flex flex-column">
    <div id="content">
        <nav className="navbar navbar-expand navbar-dark topbar mb-4 pl-0 static-top shadow">
        <button id="sidebarToggleTop" class="btn btn-link d-md-none rounded-circle mr-3">
            <i class="fa fa-bars"></i>
        </button>
            <form className="d-none d-sm-inline-block form-inline mr-auto my-2 my-md-0 mw-100 navbar-search">
                <div className="input-group">
                    <input type="text" className="form-control bg-white border-0 small"
                        placeholder="Search for Movies, Events, Plays, Sports and Activities..." aria-label="Search"
                        aria-describedby="basic-addon2" onChange={(e)=> setQuery(e.target.value)}
                    />
                    <div className="input-group-append">
                        <button className="btn bg-white" type="button" onClick={handleSearch}>
                            <i className="fas fa-search fa-sm"></i>
                        </button>
                    </div>
                </div>
            </form>
            <ul class="navbar-nav ml-auto">

                <li class="nav-item dropdown no-arrow d-sm-none">
                    <Link class="nav-link dropdown-toggle" href="#" id="searchDropdown" role="button"
                        data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        <i class="fas fa-search fa-fw"></i>
                    </Link>

                    <div class="dropdown-menu dropdown-menu-right p-3 shadow animated--grow-in"
                        aria-labelledby="searchDropdown">
                        <form class="form-inline mr-auto w-100 navbar-search">
                            <div class="input-group">
                                <input type="text" class="form-control bg-light border-0 small"
                                    placeholder="Search for..." aria-label="Search" aria-describedby="basic-addon2" />
                                <div class="input-group-append">
                                    <button class="btn btn-primary" type="button">
                                        <i class="fas fa-search fa-sm"></i>
                                    </button>
                                </div>
                            </div>
                        </form>
                    </div>
                </li>

                <li class="nav-item no-arrow mx-1">
                    <Link class="nav-link" href="offers.html">
                        <i class="fas fa-fire fa-fw"></i>

                        <span class="badge badge-danger bg-gradient-danger">NEW</span>
                    </Link>
                </li>
                <li class="nav-item dropdown no-arrow mx-1">
                    <Link class="nav-link dropdown-toggle" href="#" id="alertsDropdown" role="button"
                        data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        <i class="fas fa-bell fa-fw"></i>

                        <span class="badge badge-danger badge-counter">8+</span>
                    </Link>

                    <div class="dropdown-list dropdown-menu dropdown-menu-right shadow animated--grow-in"
                        aria-labelledby="alertsDropdown">
                        <h6 class="dropdown-header">
                            Alerts
                        </h6>
                        <Link class="dropdown-item d-flex align-items-center" href="#">
                            <div class="mr-3">
                                <div class="icon-circle bg-primary text-white">
                                    KN
                                </div>
                            </div>
                            <div>
                                <div class="small text-gray-500">December 12, 2019</div>
                                <span class="font-weight-bold">Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                                </span>
                            </div>
                        </Link>
                        <Link class="dropdown-item d-flex align-items-center" href="#">
                            <div class="dropdown-list-image mr-3">
                                <img class="rounded-circle w-60" src="img/s1.png" alt="" />
                                <div class="status-indicator bg-success"></div>
                            </div>
                            <div>
                                <div class="text-truncate">Duis vel est sit amet ipsum egestas efficitur.</div>
                                <div class="small text-gray-500">Gurdeep Osahan · 58m</div>
                            </div>
                        </Link>
                        <Link class="dropdown-item d-flex align-items-center" href="#">
                            <div class="dropdown-list-image mr-3">
                                <img class="rounded-circle w-60" src="img/s2.png" alt="" />
                                <div class="status-indicator"></div>
                            </div>
                            <div>
                                <div class="text-truncate">Pellentesque euismod diam sit amet nibh molestie, imperdiet
                                    feugiat mi feugiat.</div>
                                <div class="small text-gray-500">Jae Chun · 1d</div>
                            </div>
                        </Link>
                        <Link class="dropdown-item d-flex align-items-center" href="#">
                            <div class="dropdown-list-image mr-3">
                                <img class="rounded-circle w-60" src="img/s3.png" alt="" />
                                <div class="status-indicator bg-warning"></div>
                            </div>
                            <div>
                                <div class="text-truncate">Quisque ac justo bibendum nunc fringilla pharetra nec sit
                                    amet mauris.</div>
                                <div class="small text-gray-500">Morgan Alvarez · 2d</div>
                            </div>
                        </Link>
                        <Link class="dropdown-item d-flex align-items-center" href="#">
                            <div class="mr-3">
                                <div class="icon-circle bg-success">
                                    <i class="fas fa-donate text-white"></i>
                                </div>
                            </div>
                            <div>
                                <div class="small text-gray-500">December 7, 2019</div>
                                Sed aliquet nibh nec odio congue, in condimentum massa dapibus.
                            </div>
                        </Link>
                        <Link class="dropdown-item d-flex align-items-center" href="#">
                            <div class="mr-3">
                                <div class="icon-circle bg-warning">
                                    <i class="fas fa-exclamation-triangle text-white"></i>
                                </div>
                            </div>
                            <div>
                                <div class="small text-gray-500">December 2, 2019</div>
                                Pellentesque sit amet nunc consectetur, porta sapien a, bibendum dolor.
                            </div>
                        </Link>
                        <Link class="dropdown-item text-center small text-gray-500" href="#">Show All Alerts</Link>
                    </div>
                </li>

                <li class="nav-item dropdown no-arrow">
                    <Link class="nav-link dropdown-toggle" href="#" id="userDropdown" role="button" data-toggle="dropdown"
                        aria-haspopup="true" aria-expanded="false">
                        <span class="mr-2 d-none d-lg-inline text-gray-600 small">Askbootstrap</span>
                        <img class="img-profile rounded-circle" src="img/s4.png" />
                    </Link>

                    <div class="dropdown-menu dropdown-menu-right shadow animated--grow-in"
                        aria-labelledby="userDropdown">
                        <Link class="dropdown-item" href="profile.html">
                            <i class="fas fa-user-circle fa-sm fa-fw mr-2 text-gray-400"></i>
                            Profile
                        </Link>
                        <Link class="dropdown-item" href="profile.html">
                            <i class="fas fa-heart fa-sm fa-fw mr-2 text-gray-400"></i>
                            Watchlist
                        </Link>
                        <Link class="dropdown-item" href="profile.html">
                            <i class="fas fa-list-alt fa-sm fa-fw mr-2 text-gray-400"></i>
                            Your Lists
                        </Link>
                        <Link class="dropdown-item" href="profile.html">
                            <i class="fas fa-cog fa-sm fa-fw mr-2 text-gray-400"></i>
                            Account Settings
                        </Link>
                        <div class="dropdown-divider"></div>
                        <Link class="dropdown-item" href="#" data-toggle="modal" data-target="#logoutModal">
                            <i class="fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400"></i>
                            Logout
                        </Link>
                    </div>
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