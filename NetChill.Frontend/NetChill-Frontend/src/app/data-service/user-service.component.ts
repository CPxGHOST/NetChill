import { HttpClient, HttpErrorResponse, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { IUser } from "../models/IUser";

@Injectable({
    providedIn: 'root'
})

export class UserService {
    private dataUrl = "https://localhost:44322/api/users";
    constructor(private http: HttpClient) { }

    AddUser(user: IUser) {

        console.log(`In Data Service = ${user.Email}`);
        return this.http.post(this.dataUrl, user);
    }
}