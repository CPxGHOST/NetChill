import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { MovieService } from 'src/app/data-service/movie-service.component';
import { IMovie } from 'src/app/models/IMovie';

@Component({
  selector: 'app-display-movies',
  templateUrl: './display-movies.component.html',
  styleUrls: ['./display-movies.component.css']
})
export class DisplayMoviesComponent implements OnInit {
  movies : IMovie[] = [];
  errorMessage = '';
  sub!: Subscription;
  // Get Value represents which function to call Home==> 0 , Featured ==> 1 , New Releases => 2 , Upcoming => 3 , My List => 4
  @Input()
  getValue: number = -1;

  constructor(private movieService: MovieService , private router : Router){}

  ngOnInit(): void {
    if(this.getValue == 0){
      this.GetAllMovies();
    }else if(this.getValue == 1){
      this.GetAllMovies();
    }else if(this.getValue == 2){
      this.GetAllMovies();
    }else if(this.getValue == 3){
      this.GetUpcomingMovies();
    }else if(this.getValue == 4){
      this.GetAllMovies();
    }else{
      alert("Error!! Returning to home!");
      this.router.navigate(['/movies']);
    }
  }

  GetAllMovies(){
    this.sub = this.movieService.GetAllMovies().subscribe({
      next: movies => {
        this.movies = movies;
      },
      error: err => this.errorMessage = err
  });
  }

  GetUpcomingMovies(){
    this.sub = this.movieService.GetUpcomingMovies().subscribe({
      next: movies => {
        this.movies = movies;
      },
      error: err => this.errorMessage = err
  });
  }

  ngOnDestroy(): void {
      this.sub.unsubscribe();
  }

}
