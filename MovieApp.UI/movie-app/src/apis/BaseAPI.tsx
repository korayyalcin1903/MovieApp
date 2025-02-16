import axios , {AxiosInstance} from "axios";

export abstract class BaseApI {
    protected axiosInstance: AxiosInstance | any = null;
    constructor(baseUrl:string) {
        this.axiosInstance = axios.create({
            baseURL: baseUrl,
            withCredentials: true
        })
    }

    protected get(endpoint?: string, params?:any): Promise<any>{
        return this.axiosInstance.get(endpoint, params).then((response: any) => {
            return response.data
        })
    }

    protected post(endpoint?: string, params?:any): Promise<any>{
        return this.axiosInstance.post(endpoint, params).then((response: any) => {
            return response.data
        })
    }
}