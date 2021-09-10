import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { userDataService } from 'src/app/data-service/userData-service.component';

@Component({
  selector: 'app-view-movie',
  templateUrl: './view-movie.component.html',
  styleUrls: ['./view-movie.component.css']
})
export class ViewMovieComponent implements OnInit {

  constructor(private userDataService: userDataService , private router: Router) { }

  ngOnInit(): void {
    if(this.userDataService.loggedInUser == null){
      this.router.navigate(['/login']);
    }
  }

}
