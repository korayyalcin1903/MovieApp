import React from 'react'

const DetailSummary = ({summary}) => {
return (
<>
    <div className="tab-pane fade show active" id="home" role="tabpanel" aria-labelledby="home-tab">
        {/* <h5 className="mt-0 mb-3">New Year's Eve on the Waterfront</h5> */}
        <p>{summary}</p>
    </div>
</>
)
}

export default DetailSummary