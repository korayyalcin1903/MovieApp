import React, { useEffect, useState } from 'react'
import MainLayout from '../../Layouts/MainLayout'
import CastCard from './CastCard'
import { Link } from 'react-router'

const Cast = () => {
  const [casts, setCasts] = useState([])

  useEffect(() => {
    fetch("https://localhost:7265/api/Cast")
      .then(response => response.json())
      .then(data => setCasts(data))
  },[casts])

return (
<MainLayout>
  <div class="container-fluid">

    <div class="d-sm-flex align-items-center justify-content-between mt-4 mb-3">
      <h1 class="h5 mb-0 text-gray-900">Popular People</h1>
      <Link href="#" class="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm">Reset Filters <i
          class="fas fa-times fa-sm text-white-50"></i></Link>
    </div>

    <div class="row">
      <div class="col-xl-12 col-lg-12">
        <div class="row">
          {
            (
              casts.map((cast) => (
                <CastCard cast={cast} key={cast.id}/>
              ))
            )
          }
        </div>
      </div>
    </div>
  </div>
</MainLayout>
)
}

export default Cast