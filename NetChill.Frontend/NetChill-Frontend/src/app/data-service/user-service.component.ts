import { HttpClient, HttpErrorResponse, HttpHeaders } from "@angular/common/http";

export class UserService {
    private dataUrl = "https://localhost:44322/api/users";

    constructor(private http : HttpClient){}

}