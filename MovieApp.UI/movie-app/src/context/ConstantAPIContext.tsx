import { createContext } from "react";

interface ConstantAPI {
    movieList: MovieListResponse[],
    movieDetayList: MovieDetayResponse[]
    castMovieList: CastMovieResponse[],
    movieFilterByCategory : FilterCategoryResponse[]
    castList: CastListResponse[]
    kullaniciVarMi:boolean
    setKullaniciVarMi:React.Dispatch<React.SetStateAction<boolean>>
}

export const ConstantAPIContext = createContext<ConstantAPI>({
    movieList: [],
    movieDetayList: [],
    castMovieList: [],
    movieFilterByCategory: [],
    castList: [],
    setKullaniciVarMi: () => { },
    kullaniciVarMi: false
})

export interface MovieListResponse{
    id?:string,
    title?: string,
    imageUrl?: string,
    categoryName?: string
}

export interface MovieDetayResponse{
    id?:string,
    title?:string,
    description?:string,
    bgImage?:string,
    imageUrl?:string,
    director?:string,
    budget?:number,
    createdDate?:Date,
    categoryName?:string
}

export interface CastMovieResponse {
    id?:string,
    fullName?:string,
    imgUrl?:string,
    biography?:string
}

export interface FilterCategoryResponse{
    id?: string,
    title?: string,
    imageUrl?: string,
    createdDate?: string,
    categoryId?: string,
    userId?:string
}

export interface CastListResponse{
    id?: string,
    fullName?:string,
    imgUrl?:string,
    biography?:string
}