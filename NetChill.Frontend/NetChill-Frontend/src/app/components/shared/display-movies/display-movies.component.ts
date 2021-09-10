import { Component, OnInit } from '@angular/core';
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

  constructor(private movieService: MovieService){}

  ngOnInit(): void {
      this.sub = this.movieService.GetAllMovies().subscribe({
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
