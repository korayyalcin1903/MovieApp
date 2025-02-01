import React from 'react'
import { BrowserRouter, Route, Routes } from 'react-router'
import Home from '../Components/Home/Home'
import Filter from '../Components/Filter/Filter'
import Cast from '../Components/Cast/Cast'
import ProfileLayout from '../Layouts/ProfileLayout'
import Login from '../Components/Auth/Login'
import Register from '../Components/Auth/Register'
import DetailPage from '../Components/MovieDetails/DetailPage'

const AppRouter = () => {
  return (
    <BrowserRouter basename='/'>
        <Routes>
            <Route path='/' element={<Home />}></Route>
            <Route path='/movie/:id' element={<DetailPage />}></Route>
            <Route path='/filter' element={<Filter />}></Route>
            <Route path='/cast' element={<Cast />}></Route>
            <Route path='profile' element={<ProfileLayout />}></Route>
            <Route path='/login' element={<Login />}></Route>
            <Route path='/register' element={<Register />}></Route>
        </Routes>
    </BrowserRouter>
  )
}

export default AppRouter