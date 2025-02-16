import React, { useContext, useEffect } from 'react'
import { Route, Routes, useNavigate } from 'react-router'
import Home from '../Components/Home/Home'
import Filter from '../Components/Filter/Filter'
import Cast from '../Components/Cast/Cast'
import Login from '../Components/Auth/Login'
import Register from '../Components/Auth/Register'
import DetailPage from '../Components/MovieDetails/DetailPage'
import ProfileLayout from '../Layouts/ProfileLayout'
import StorageService, { SessionStorageService } from '../services/StorageService'
import { ConstantAPIContext } from '../context/ConstantAPIContext'
import Logout from '../Components/Auth/Logout'

const AppRouter = () => {
  let user = StorageService.getUserInfo();
  const { kullaniciVarMi } = useContext(ConstantAPIContext);
  const navigate = useNavigate();

  useEffect(() => {
    const restrictedRoutes = ["/register", "/login"];
    if (kullaniciVarMi && restrictedRoutes.includes(window.location.pathname)) {
      navigate("/");
    }
  }, [kullaniciVarMi, navigate]);

  return (
        <Routes>
            <Route path='/' element={<Home />}/>
            <Route path='/movie/:id' element={<DetailPage />}/>
            <Route path='/filter' element={<Filter />}/>
            <Route path='/cast' element={<Cast />}/>
            {kullaniciVarMi && <Route path="/profile" element={<ProfileLayout />} />}
            {!kullaniciVarMi && <Route path="/login" element={<Login />} />}
            {!kullaniciVarMi && <Route path="/register" element={<Register />} />}
            {kullaniciVarMi && <Route path="/logout" element={<Logout />} />}
        </Routes>
  )
}

export default AppRouter