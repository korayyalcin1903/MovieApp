import React, { useContext, useEffect } from 'react'
import { useLocation, useNavigate } from 'react-router'
import { ConstantAPIContext } from '../../context/ConstantAPIContext'

function Logout() {
  const location = useLocation()
  const navigate = useNavigate()
  const { setKullaniciVarMi } = useContext(ConstantAPIContext);

  useEffect(() => {
    console.log(location)
      if(location.pathname === '/logout'){
        setKullaniciVarMi(false)
        sessionStorage.removeItem("userInfo")
        navigate('/login')
      }
  },[])
  return (
    <div>Yönlendiriliyorsunuz...</div>
  )
}

export default Logout