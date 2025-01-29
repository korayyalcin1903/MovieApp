import React from 'react';
import MainLayout from './MainLayout';
import SideBar from '../Components/Profile/SideBar';
import Profile from '../Components/Profile/Profile';
import AccountSetting from '../Components/Profile/AccountSetting';
import WatchList from '../Components/Profile/WatchList';
import { Link } from 'react-router';

const ProfileLayout = ({ children }) => {
  return (
    <MainLayout>
      <div className="container-fluid">
        <section className="pt-5 pb-5 bg-gradient-primary text-white pl-4 pr-4 inner-profile mb-4">
          <div className="row gutter-2 gutter-md-4 align-items-end">
            <div className="col-md-6 text-center text-md-left">
              <h1 className="mb-1">Gurdeep Osahan</h1>
              <span className="text-muted text-gray-500">
                <i className="fas fa-map-marker-alt fa-fw fa-sm mr-1"></i> India, Punjab
              </span>
            </div>
            <div className="col-md-6 text-center text-md-right">
              <Link href="#" data-toggle="modal" data-target="#logoutModal" className="btn btn-light">
                Sign out
              </Link>
            </div>
          </div>
        </section>
        <div className="row">
          <SideBar />
          <div className="col-xl-9 col-lg-9">
            <div className="bg-white p-3 widget shadow rounded mb-4">
              <div className="tab-content" id="myTabContent">
                <Profile />
                <WatchList />
                <AccountSetting />

                

                
              </div>
            </div>
          </div>
        </div>
      </div>
    </MainLayout>
  );
};

export default ProfileLayout;