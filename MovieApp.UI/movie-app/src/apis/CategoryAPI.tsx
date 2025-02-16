import { BaseApI } from "./BaseAPI";
import * as environment from "../config/environment"

class CategoryAPI extends BaseApI{
    constructor() {
        const baseUrl = environment.API_URL
        super(baseUrl);
    }

    categoryFilter(categoryId?:string){
        return this.get(`Movie/category/${categoryId}`)
    }
}

export default new CategoryAPI()