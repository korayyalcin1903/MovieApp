import { BaseApI } from "./BaseAPI";
import * as environment from "../config/environment"

class CastAPI extends BaseApI{
    constructor() {
        const baseUrl = environment.API_URL
        console.log(baseUrl)
        super(baseUrl);
        
    }

    getCastByMovieId(movieId?:string){
        return this.get(`Cast/GetCastByMovieId/${movieId}`)
    }

    getAllCast(){
        return this.get("Cast")
    }
}

export default new CastAPI()