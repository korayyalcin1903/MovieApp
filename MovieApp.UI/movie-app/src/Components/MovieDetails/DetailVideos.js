import React from 'react'

const DetailVideos = () => {
return (
<>
    <div className="tab-pane fade" id="videos" role="tabpanel" aria-labelledby="videos-tab">
        <div className="row">
            <div className="col-xl-12 col-lg-12">
                <div className="mb-4">
                <iframe width="100%" height="300px" src="https://www.youtube.com/embed/UGDY5AG9bQA?si=RWRi_VfRe-lcP2dl" title="YouTube video player" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"></iframe>
                </div>
            </div>
        </div>
    </div>
</>
)
}

export default DetailVideos