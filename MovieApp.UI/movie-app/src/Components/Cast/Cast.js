import React, { useContext, useEffect, useState } from 'react'
import MainLayout from '../../Layouts/MainLayout'
import CastCard from './CastCard'
import { Link } from 'react-router'
import { ConstantAPIContext } from '../../context/ConstantAPIContext'
import CastAPI from '../../apis/CastAPI'

const Cast = () => {
  const [casts, setCasts] = useState([])
  const {castList} = useContext(ConstantAPIContext)

  useEffect(() => {
    const fetchData = async() => {
      var response = await CastAPI.getAllCast()
      console.log(response)
      setCasts(response)
    }
    fetchData()
  },[])

return (
<MainLayout>
  <div className="container-fluid">

    <div className="d-sm-flex align-items-center justify-content-between mt-4 mb-3">
      <h1 className="h5 mb-0 text-gray-900">Popular People</h1>
      <Link href="#" className="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm">Reset Filters <i
          className="fas fa-times fa-sm text-white-50"></i></Link>
    </div>

    <div className="row">
      <div className="col-xl-12 col-lg-12">
        <div className="row">
          {
            casts.length > 0 ? 
              (
                casts.map((cast) => (
                  <CastCard cast={cast} key={cast.id}/>
                ))
              ) : (
                <h4>Oyuncular bulunamadı</h4>
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