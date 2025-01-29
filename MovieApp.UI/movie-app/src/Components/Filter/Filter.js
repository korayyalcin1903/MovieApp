import React from 'react';
import MainLayout from '../../Layouts/MainLayout';
import FilterSideBar from './FilterSideBar';
import MovieCard from '../MovieCard';
import { Link } from 'react-router';

const Filter = () => {
  return (
    <MainLayout>
      <div className="container-fluid">
      <div className="d-sm-flex align-items-center justify-content-between mt-4 mb-3">
        <h1 className="h5 mb-0 text-gray-900">Events</h1>
        <Link href="#" className="d-none d-sm-inline-block btn btn-sm btn-primary shadow-sm">Reset Filters <i className="fas fa-times fa-sm text-white-50"></i></Link>
      </div>
      <div className="row">
        <div className='col-xl-3 col-lg-4'>
          <FilterSideBar />
        </div>
        <div className='col-xl-9 col-lg-8'>
          <MovieCard />
        </div>
      </div>
      </div>
    </ MainLayout>
  );
};

export default Filter;