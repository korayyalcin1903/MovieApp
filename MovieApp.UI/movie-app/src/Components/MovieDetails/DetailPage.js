import { useState, useEffect } from "react"
import { useParams } from "react-router"
import MainLayout from "../../Layouts/MainLayout"
import DetailSummary from "./DetailSummary"
import DetailMovieCard from "./DetailMovieCard"
import DetailHeadInfo from "./DetailHeadInfo"
import DetailCast from "./DetailCast"
import DetailVideos from "./DetailVideos"
import DetailReviews from "./DetailReviews"

const DetailPage = () => {
    const [movie, setMovie] = useState(null)
    const [casts, setCasts] = useState([]);
    const params = useParams()

    useEffect(() => {
           fetch("https://localhost:7265/api/Movie/" + params.id)
                .then(response => response.json())
                .then(data => setMovie(data))
                .catch(err => console.log(err))
        }, [params.id])

    useEffect(() => {
        fetch("https://localhost:7265/api/Cast/GetCastByMovieId/" + params.id)
                .then(response => response.json())
                .then(data => setCasts(data))
                .catch(err => console.log(err))
    }, [params.id])

  return (
    <>
        <MainLayout>
            {
                !movie ? (<div>Loading ...</div>):
                (
                    <div className="container-fluid">
                        <div className="row">
                            <div className="col-xl-12 col-lg-12">
                                <div className="cover-pic">
                                    <div className="position-absolute bg-white shadow-sm rounded text-center p-2 m-4 love-box">
                                        <h6 className="text-gray-900 mb-0 font-weight-bold"><i className="fas fa-heart text-danger"></i> 50%</h6>
                                        <small className="text-muted">8,784</small>
                                    </div>
                                    <img src={movie.bgImage} style={{objectFit: "cover", width: "100%", height:"60vh"}} className="img-fluid" alt="..."/>
                                </div>
                            </div>
                            <div className="col-xl-3 col-lg-3">
                                <DetailMovieCard movie={movie}/>
                            </div>
                            <div className="col-xl-9 col-lg-9">
                                < DetailHeadInfo movie={movie}/>
                                <div className="bg-white p-3 widget shadow rounded mb-4">
                                    <ul className="nav nav-tabs" id="myTab" role="tablist">
                                        <li className="nav-item">
                                            <a className="nav-link active" id="home-tab" data-toggle="tab" href="#home" role="tab"
                                                aria-controls="home" aria-selected="true">Summary</a>
                                        </li>
                                        <li className="nav-item">
                                            <a className="nav-link" id="profile-tab" data-toggle="tab" href="#profile" role="tab"
                                                aria-controls="profile" aria-selected="false">Cast
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a className="nav-link" id="videos-tab" data-toggle="tab" href="#videos" role="tab"
                                                aria-controls="videos" aria-selected="false">Videos
                                            </a>
                                        </li>
                                        <li className="nav-item">
                                            <a className="nav-link" id="contact-tab" data-toggle="tab" href="#contact" role="tab"
                                                aria-controls="contact" aria-selected="false">Reviews</a>
                                        </li>
                                    </ul>
                                    <div className="tab-content" id="myTabContent">
                                        <DetailSummary summary={movie.description}/>
                                        <DetailCast casts={casts}/>
                                        <DetailVideos />
                                        <DetailReviews />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                )
            }
            
        </MainLayout>
    </>
  )
}

export default DetailPage