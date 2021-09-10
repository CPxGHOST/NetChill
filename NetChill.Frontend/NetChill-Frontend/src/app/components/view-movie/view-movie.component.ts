import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { MovieService } from 'src/app/data-service/movie-service.component';
import { IMovie } from 'src/app/models/IMovie';
import { Router } from '@angular/router';
import { userDataService } from 'src/app/data-service/userData-service.component';

@Component({
  selector: 'app-view-movie',
  templateUrl: './view-movie.component.html',
  styleUrls: ['./view-movie.component.css']
})
export class ViewMovieComponent implements OnInit {
    errorMessage = '';
    movie: IMovie | undefined;

    constructor(private route: ActivatedRoute,
      private router: Router,
      private movieService: MovieService,
      private userDataService: userDataService) {
    }
    
    ngOnInit(): void {
      if(this.userDataService.loggedInUser == null){
          this.router.navigate(['/login']);
      }
      const id = this.route.snapshot.paramMap.get('id');
      console.log(id);
      if (id) {
        this.GetMovie(id);
      }
    }
    
    GetMovie(id: string){
      this.movieService.GetMovie(id).subscribe(
        {
            next: movie => {
              this.movie = movie;
              console.log(this.movie);
            },
            error: err => this.errorMessage = err
        }
    )}
}
