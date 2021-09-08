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
        return this.http.post(this.dataUrl, user);
    }
}