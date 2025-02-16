
import React, {useState, useEffect} from "react"
import { BrowserRouter } from "react-router-dom"
import {ConstantAPIContext} from "./context/ConstantAPIContext"
import MovieAPI from "./apis/MovieAPI"
import AppRouter from "./Routers/AppRouter";
import StorageService from "./services/StorageService";


export default function App(){

  const [movieList, setMovieList] = useState([]);
  const [movieDetay, setMovieDetay] = useState([])
  const [kullaniciVarMi, setKullaniciVarMi] = useState(() => {
    const user = StorageService.getUserInfo()
    return !!user
  })

  useEffect(() => {
    const user = StorageService.getUserInfo()
    setKullaniciVarMi(!!user)
  }, [])
  

  useEffect(() => {
    const fetchData =  async () => {
      try{
        const [movieList] = await Promise.all([
          MovieAPI.getAllMovie(),
        ])
          setMovieList(movieList)
      } catch (error){
        console.log(error)
      } 
    }

    fetchData()
  }, []);

  return (
    <BrowserRouter>
      <ConstantAPIContext.Provider
        value={{
          movieList: movieList,
          kullaniciVarMi: kullaniciVarMi,
          setKullaniciVarMi: setKullaniciVarMi
        }}
      >
        <AppRouter/>
      </ConstantAPIContext.Provider>
    </BrowserRouter>
  )
}


