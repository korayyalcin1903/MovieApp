import React from 'react'
import { Link, NavLink } from 'react-router'

const SideBar = () => {
return (
    <ul className="navbar-nav sidebar sidebar-dark accordion" id="accordionSidebar">

        <NavLink className="sidebar-brand d-flex align-items-center justify-content-center" to="/">
            <div className="sidebar-brand-icon">
                <img src="/img/logo-icon.png" alt="" />
            </div>
            <div className="sidebar-brand-text mx-3"><img src="/img/logo.png" alt=""/></div>
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
        <hr className="sidebar-divider" />

    </ul>
)
}

export default SideBar