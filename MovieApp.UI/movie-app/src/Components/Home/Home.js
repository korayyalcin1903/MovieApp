import  {useContext} from 'react';
import { ConstantAPIContext } from '../../context/ConstantAPIContext';
import MainLayout from '../../Layouts/MainLayout';
import Slider from './Slider';
import Movies from './Movies';


const Home = () => {
  const {movieList} = useContext(ConstantAPIContext)


  console.log(movieList)


  return (
    <MainLayout>
      <div className="container-fluid">
        <div className="osahan-slider slick-initialized slick-slider">
          <Slider />
        </div>

        <Movies />
      </div>
    </MainLayout>
  );
}

export default Home;