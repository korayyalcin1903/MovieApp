import React from 'react'
import { Link } from 'react-router'

function Footer() {
  return (
    <footer className="sticky-footer bg-white">
        <div className="container my-auto">
            <div className="copyright text-center my-auto">
                <span>Copyright © Bookishow 2019 | Made with <i className="fas fa-heart fa-fw text-danger"></i> by <Link target="_blank" href="#">Askbootstrap</Link></span>
            </div>
        </div>
    </footer>
  )
}

export default Footer