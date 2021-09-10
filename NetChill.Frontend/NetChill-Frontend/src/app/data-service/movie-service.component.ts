import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { IMovie } from "../models/IMovie";

@Injectable({
    providedIn: "root"
})

export class MovieService{
    private movieUrl = "https://localhost:44322/api/movies";
   
    constructor(private http : HttpClient) {}

    AddMovie(movie: IMovie){
      return this.http.post<IMovie>(this.movieUrl , movie);
    }

    GetAllMovies(){
      return this.http.get<IMovie[]>(this.movieUrl);
    }

    GetMovie(id : string){
      return this.http.get<IMovie>(this.movieUrl + `/${id}`);
    }
}