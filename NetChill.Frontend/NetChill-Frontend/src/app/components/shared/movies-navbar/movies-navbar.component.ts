import { Component, OnInit } from '@angular/core';
import { userDataService } from 'src/app/data-service/userData-service.component';

@Component({
  selector: 'app-movies-navbar',
  templateUrl: './movies-navbar.component.html',
  styleUrls: ['./movies-navbar.component.css']
})
export class MoviesNavbarComponent implements OnInit {
  public isAdmin: boolean = false;

  constructor(private userDataService: userDataService) {
      if(this.userDataService.loggedInUser != null && this.userDataService.loggedInUser.Role == 1){
        this.isAdmin = true;
      }
   }

  ngOnInit(): void {
  }

}
