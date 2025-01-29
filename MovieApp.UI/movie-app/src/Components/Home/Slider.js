import React from 'react';

const Slider = () => {
  return (
    <>
      <button className="slick-prev slick-arrow" aria-label="Previous" type="button" style={{}}>Previous</button>
      <div className="slick-list draggable" style={{ padding: '0px 200px' }}>
        <div className="slick-track" style={{ opacity: 1, width: '3920px', transform: 'translate3d(-1470px, 0px, 0px)' }}>
          <div className="osahan-slider-item slick-slide slick-cloned" data-slick-index="-2" aria-hidden="true" tabIndex="-1" style={{ width: '474px' }}>
            <img src="img/slider2.jpg" className="img-fluid rounded" alt="..." />
          </div>
          <div className="osahan-slider-item slick-slide slick-cloned" data-slick-index="-1" aria-hidden="true" tabIndex="-1" style={{ width: '474px' }}>
            <img src="img/slider3.jpg" className="img-fluid rounded" alt="..." />
          </div>
          <div className="osahan-slider-item slick-slide" data-slick-index="0" aria-hidden="true" tabIndex="-1" style={{ width: '474px' }}>
            <img src="img/slider1.jpg" className="img-fluid rounded" alt="..." />
          </div>
          <div className="osahan-slider-item slick-slide slick-current slick-active slick-center" data-slick-index="1" aria-hidden="false" tabIndex="0" style={{ width: '474px' }}>
            <img src="img/slider2.jpg" className="img-fluid rounded" alt="..." />
          </div>
          <div className="osahan-slider-item slick-slide" data-slick-index="2" aria-hidden="true" tabIndex="-1" style={{ width: '474px' }}>
            <img src="img/slider3.jpg" className="img-fluid rounded" alt="..." />
          </div>
          <div className="osahan-slider-item slick-slide slick-cloned" data-slick-index="3" aria-hidden="true" tabIndex="-1" style={{ width: '474px' }}>
            <img src="img/slider1.jpg" className="img-fluid rounded" alt="..." />
          </div>
          <div className="osahan-slider-item slick-slide slick-cloned" data-slick-index="4" aria-hidden="true" tabIndex="-1" style={{ width: '474px' }}>
            <img src="img/slider2.jpg" className="img-fluid rounded" alt="..." />
          </div>
          <div className="osahan-slider-item slick-slide slick-cloned" data-slick-index="5" aria-hidden="true" tabIndex="-1" style={{ width: '474px' }}>
            <img src="img/slider3.jpg" className="img-fluid rounded" alt="..." />
          </div>
        </div>
      </div>
      <button className="slick-next slick-arrow" aria-label="Next" type="button" style={{}}>Next</button>
    </>
  );
};

export default Slider;