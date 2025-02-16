import * as environment from "../config/environment"
import { BaseApI } from "./BaseAPI";

class MovieAPI extends BaseApI{
    constructor() {
        const baseUrl = environment.API_URL;
        console.log(baseUrl);
        super(baseUrl);
    }

    getAllMovie(){
        return this.get("Movie")
    }

    getByIdMovie(movieId?: string) {
        return this.get(`Movie/${movieId}`);
    }    
    
}

export default new MovieAPI()