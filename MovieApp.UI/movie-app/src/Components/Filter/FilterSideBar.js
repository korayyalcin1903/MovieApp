import React from 'react';
import { Link } from 'react-router';

const FilterSideBar = () => {
  return (
    <>
      <div className="filters shadow rounded bg-white mb-3 d-none d-sm-none d-md-block">
        <div className="filters-header border-bottom p-3">
          <h6 className="m-0 text-dark">Filter By</h6>
        </div>
        <div className="filters-body">
          <div id="accordion">
            <div className="filters-card border-bottom p-3">
              <div className="filters-card-header" id="headingTwo">
                <h6 className="mb-0">
                  <Link
                    href="#"
                    className="btn-link"
                    data-toggle="collapse"
                    data-target="#collapsetwo"
                    aria-expanded="true"
                    aria-controls="collapsetwo"
                  >
                    Genre
                    <i className="fas fa-angle-down float-right"></i>
                  </Link>
                </h6>
              </div>
              <div id="collapsetwo" className="collapse show" aria-labelledby="headingTwo" data-parent="#accordion">
                <div className="filters-card-body card-shop-filters">
                  <form className="filters-search mb-3">
                    <div className="form-group">
                      <i className="fas fa-search"></i>
                      <input type="text" className="form-control" placeholder="Start typing to search..." />
                    </div>
                  </form>
                  <div className="custom-control custom-checkbox">
                    <input type="checkbox" className="custom-control-input" id="osahan11q" />
                    <label className="custom-control-label" htmlFor="osahan11q">
                      Action <small className="text-black-50">156</small>
                    </label>
                  </div>
                  <div className="mt-2">
                    <Link href="#" className="link">
                      See all
                    </Link>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default FilterSideBar;