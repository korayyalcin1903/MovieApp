import React from 'react'

const DetailCast = ({casts}) => {
return (
<>
    <div className="tab-pane fade" id="profile" role="tabpanel" aria-labelledby="profile-tab">
        <div className="row">
            <div className="col-xl-4 col-lg-4">
                <h5 className="h6 mt-0 mb-3 font-weight-bold text-gray-900">CAST</h5>
                {
                    casts.length > 0 ? (
                        casts.map((cast) => (
                            <div className="artist-list mb-3" key={cast.id}>
                                <a className="d-flex align-items-center" href="#">
                                    <div className="dropdown-list-image mr-3">
                                        <img className="rounded-circle" src={cast.imgUrl} alt="" />
                                        <div className="status-indicator bg-success"></div>
                                    </div>
                                    <div className="font-weight-bold">
                                        <div className="text-truncate">{cast.fullName}</div>
                                        <div className="small text-gray-500">Acting</div>
                                    </div>
                                </a>
                            </div>
                        ))
                    ) : 
                    (
                        <div>Oyuncular bulunamadı.</div>
                    )
                }
            </div>
        </div>
    </div>
</>
)
}

export default DetailCast