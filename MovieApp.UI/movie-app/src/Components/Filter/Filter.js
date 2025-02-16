import React, { useContext, useEffect, useState } from 'react';
import { useLocation, useNavigate } from 'react-router-dom';
import MainLayout from '../../Layouts/MainLayout';
import FilterSideBar from './FilterSideBar';
import MovieCard from '../MovieCard';
import CategoryAPI from '../../apis/CategoryAPI';
import { ConstantAPIContext } from '../../context/ConstantAPIContext';
import MovieAPI from '../../apis/MovieAPI';

const Filter = () => {
  const [movies, setMovies] = useState([]);
  const [categories, setCategories] = useState([]);
  const [selectedCategory, setSelectedCategory] = useState(null);
  const {movieFilterByCategory} = useContext(ConstantAPIContext)
  const location = useLocation()
  const query = new URLSearchParams(location.search).get('query');
  const navigate = useNavigate();
  
  useEffect(() => {
    if (selectedCategory) { 
      console.log(selectedCategory)
      const fetchData = async() => {
        var response = await CategoryAPI.categoryFilter(selectedCategory)
        console.log(response)
        setMovies(response)
      }
      fetchData()
    } else {
      const fetchData = async() => {
        var response = await MovieAPI.getAllMovie()
        console.log(response)
        setMovies(response)
      }
      fetchData()
    }
  }, [selectedCategory]); 

  useEffect(() => {
    if(query){
      fetch("https://localhost:7265/api/Movie")
        .then(response => response.json())
        .then(data => {
          const filterMovies = data.filter(movie => movie.title.toLowerCase().includes(query.toLowerCase()))
          setMovies(filterMovies)
        })
        .catch(err => console.log(err))
    }
  }, [query])
  
  useEffect(() => {
    fetch("https://localhost:7265/api/Category")
      .then(response => response.json())
      .then(data => setCategories(data))
      .catch(err => console.log(err))
  }, []);

  const handleResetFilters = () => {
    setSelectedCategory(null); 
    navigate('/filter'); 
    window.location.reload()
  }

  return (
    <MainLayout>
      <div className="container-fluid">
        <div className="d-sm-flex align-items-center justify-content-between mt-4 mb-3">
          <h1 className="h5 mb-0 text-gray-900">Events</h1>
          <button 
            className="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm" 
            onClick={() => handleResetFilters()}
          >
            Reset Filters <i className="fas fa-times fa-sm text-white-50"></i>
          </button>

        </div>
        <div className="row">
          <div className='col-xl-3 col-lg-4'>
            {
              categories.length > 0 ? (
                <FilterSideBar categories={categories} setSelectedCategory={setSelectedCategory} />
              ) : (
                <b>Kategoriler bulunamadı</b>
              )
            }
          </div>
          <div className='col-xl-9 col-lg-8'>
            <div className="row">
              {
                movies.length > 0 ? 
                movies.map((movie) => (
                  <MovieCard key={movie.id} movie={movie} />
                )) : (
                  <h4>Filmler bulunamadı</h4>
                )
              }
            </div>
          </div>
        </div>
      </div>
    </MainLayout>
  );
};

export default Filter;
