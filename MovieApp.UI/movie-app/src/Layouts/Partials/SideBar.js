import React from 'react'
import { Link, NavLink } from 'react-router'

const SideBar = () => {
return (
    <ul className="navbar-nav sidebar sidebar-dark accordion" id="accordionSidebar">

        <NavLink className="sidebar-brand d-flex align-items-center justify-content-center" to="/">
            <div className="sidebar-brand-icon">
                <img src="img/logo-icon.png" alt="" />
            </div>
            <div className="sidebar-brand-text mx-3"><img src="img/logo.png" alt=""/></div>
        </NavLink>

        <li className="nav-item">
            <NavLink className="nav-link" to="/">
                <i className="fas fa-fw fa-film"></i>
                <span>Movies</span></NavLink>
        </li>
        <li className="nav-item">
            <NavLink className="nav-link" to="/filter">
                <i className="fas fa-fw fa-glass-cheers"></i>
                <span>Filter</span></NavLink>
        </li>
        <li className="nav-item">
            <NavLink className="nav-link" to="/cast">
                <i className="fas fa-fw fa-users"></i>
                <span>Cast</span></NavLink>
        </li>
        <li className="nav-item">
            <Link className="nav-link" href="sports.html">
                <i className="fas fa-fw fa-futbol"></i>
                <span>Sports</span></Link>
        </li>

        <hr className="sidebar-divider" />

        <div className="sidebar-heading">Extra</div>

        <li className="nav-item">
            <Link className="nav-link collapsed" href="#" data-toggle="collapse" data-target="#collapseTwo" aria-expanded="true"
                aria-controls="collapseTwo">
                <i className="fas fa-fw fa-pager"></i>
                <span>Pages</span>
            </Link>
            <div id="collapseTwo" className="collapse" aria-labelledby="headingTwo" data-parent="#accordionSidebar">
                <div className="bg-white py-2 collapse-inner rounded">
                    <h6 className="collapse-header">All Pages</h6>
                    <Link className="collapse-item" href="movies.html">Movies</Link>
                    <Link className="collapse-item" href="movies-detail.html">Movie Detail</Link>
                    <Link className="collapse-item" href="events.html">Events</Link>
                    <Link className="collapse-item" href="events-detail.html">Event Detail</Link>
                    <Link className="collapse-item" href="people.html">People</Link>
                    <Link className="collapse-item" href="people-detail.html">People Detail</Link>
                    <Link className="collapse-item" href="sports.html">Sports</Link>
                    <Link className="collapse-item" href="sports-detail.html">Sport Detail</Link>
                </div>
            </div>
        </li>
        <li className="nav-item">
            <Link className="nav-link" href="offers.html">
                <i className="fas fa-fw fa-fire"></i>
                <span>Offers</span></Link>
        </li>
        <li className="nav-item">
            <Link className="nav-link collapsed" href="#" data-toggle="collapse" data-target="#collapsePages" aria-expanded="true"
                aria-controls="collapsePages">
                <i className="fas fa-fw fa-clone"></i>
                <span>Extra Pages</span>
            </Link>
            <div id="collapsePages" className="collapse" aria-labelledby="headingPages" data-parent="#accordionSidebar">
                <div className="bg-white py-2 collapse-inner rounded">
                    <h6 className="collapse-header">Login Screens:</h6>
                    <Link className="collapse-item" to="/login">Login</Link>
                    <Link className="collapse-item" to="/register">Register</Link>
                    <Link className="collapse-item" href="forgot-password.html">Forgot Password</Link>
                    <div className="collapse-divider"></div>
                    <h6 className="collapse-header">Other Pages:</h6>
                    <Link className="collapse-item" href="404.html">404 Page</Link>
                    <Link className="collapse-item" href="blank.html">Blank Page</Link>
                </div>
            </div>
        </li>
    </ul>
)
}

export default SideBar