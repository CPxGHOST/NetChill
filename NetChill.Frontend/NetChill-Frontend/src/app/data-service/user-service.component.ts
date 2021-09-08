import { HttpClient, HttpErrorResponse, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { IUser } from "../models/IUser";

@Injectable({
    providedIn: 'root'
})

export class UserService {
    private loginUrl = "https://localhost:44322/api/login";
    private signUpUrl = "https://localhost:44322/api/signup";
    constructor(private http: HttpClient) { }

    AddUser(user: IUser) {
        console.log(`In Data Service = ${user.Email}`);
        return this.http.post(this.signUpUrl, user);
    }

    LoginUser(user: IUser) {
        console.log(`In Data Service = ${user}`);
        return this.http.post(this.loginUrl, user);
    }
}