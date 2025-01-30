import React, { useEffect, useState } from 'react';
import { useLocation, useNavigate } from 'react-router-dom';
import MainLayout from '../../Layouts/MainLayout';
import FilterSideBar from './FilterSideBar';
import MovieCard from '../MovieCard';

const Filter = () => {
  const [movies, setMovies] = useState([]);
  const [categories, setCategories] = useState([]);
  const [selectedCategory, setSelectedCategory] = useState(null);
  const location = useLocation()
  const query = new URLSearchParams(location.search).get('query');
  const navigate = useNavigate();
  
  useEffect(() => {
    if (selectedCategory) { 
      console.log(selectedCategory)
      fetch(`https://localhost:7265/api/Movie/category/${selectedCategory}`)
        .then(response => response.json())
        .then(data => setMovies(data));
    } else {
      fetch("https://localhost:7265/api/Movie")
        .then(response => response.json())
        .then(data => setMovies(data));
    }
  }, [selectedCategory]); 

  useEffect(() => {
    if(query){
      fetch("https://localhost:7265/api/Movie")
        .then(response => response.json())
        .then(data => {
          const filterMovies = data.filter(movie => movie.title.toLowerCase().includes(query.toLowerCase()))
          setMovies(filterMovies)
        });
    }
  }, [query])
  
  useEffect(() => {
    fetch("https://localhost:7265/api/Category")
      .then(response => response.json())
      .then(data => setCategories(data));
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
            <FilterSideBar categories={categories} setSelectedCategory={setSelectedCategory} />
          </div>
          <div className='col-xl-9 col-lg-8'>
            <div className="row">
              {movies.map((movie) => (
                <MovieCard key={movie.id} movie={movie} />
              ))}
            </div>
          </div>
        </div>
      </div>
    </MainLayout>
  );
};

export default Filter;
