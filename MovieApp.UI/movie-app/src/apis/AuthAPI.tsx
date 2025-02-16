import { BaseApI } from "./BaseAPI";
import * as environment from "../config/environment"
import StorageService, { SessionStorageService } from "../services/StorageService"
import { jwtDecode } from "jwt-decode";

class AuthAPI extends BaseApI{
    constructor() {
        const baseUrl = environment.API_URL + "Auth"
        super(baseUrl);   
    }
    
    async signIn(request: SignInRequest){
        StorageService.clearAll()
        const response = await this.post("login", request)
        let verifyData = jwtDecode(response.token)
        console.log(response)
        if (response?.token) {
            StorageService.setUserInfo(verifyData);
          }
        return response
    }
}

export class SignInRequest {
    email: string
    password: string

    constructor(email: string, password:string) {
        this.email = email
        this.password = password
    }
}


export default new AuthAPI()