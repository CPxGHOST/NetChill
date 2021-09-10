import { Component, OnInit } from '@angular/core';
import { userDataService } from 'src/app/data-service/userData-service.component';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.css']
})
export class MovieListComponent implements OnInit {

  public isAdmin: boolean = false;

  constructor(private userDataService: userDataService) {
      if(userDataService.loggedInUser.Role == 1){
        this.isAdmin = true;
      }
   }

  ngOnInit(): void {
   
  }
}
