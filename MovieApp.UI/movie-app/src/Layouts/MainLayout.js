import React from 'react'
import SideBar from './Partials/SideBar'
import Main from './Partials/Main'

const MainLayout = ({children}) => {
  return (
    <>
        <div id='wrapper'>
            <SideBar />
            <Main>
                {children}
            </Main>
        </div>
    </>
  )
}

export default MainLayout