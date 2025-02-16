import React from 'react';
import MainLayout from './MainLayout';
import SideBar from '../Components/Profile/SideBar';
import Profile from '../Components/Profile/Profile';
import AccountSetting from '../Components/Profile/AccountSetting';
import WatchList from '../Components/Profile/WatchList';
import { Link } from 'react-router';
import StorageService from '../services/StorageService';

const ProfileLayout = () => {
  var user = StorageService.getUserInfo()
  return (
    <MainLayout>
      <div className="container-fluid">
        <section className="pt-5 pb-5 bg-gradient-primary text-white pl-4 pr-4 inner-profile mb-4">
          <div className="row gutter-2 gutter-md-4 align-items-end">
            <div className="col-md-6 text-center text-md-left">
              {
                user && (
                  <h1 className="mb-1">{user.FirstName.toUpperCase()} {user.LastName.toUpperCase()}</h1>
                )
              }
            </div>
          </div>
        </section>
        <div className="row">
          <SideBar />
          <div className="col-xl-9 col-lg-9">
            <div className="bg-white p-3 widget shadow rounded mb-4">
              <div className="tab-content" id="myTabContent">
                <Profile user={user}/>
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