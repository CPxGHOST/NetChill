import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { MovieService } from 'src/app/data-service/movie-service.component';
import { IMovie } from 'src/app/models/IMovie';

@Component({
  selector: 'app-upload-content',
  templateUrl: './upload-content.component.html',
  styleUrls: ['./upload-content.component.css']
})
export class UploadContentComponent implements OnInit {

  imageSrc!: any;  
  newMovie!: IMovie;

  constructor(private movieService: MovieService) { }
  
  ngOnInit(): void {
    throw new Error('Method not implemented.');
  }
  preview(files: any){
    const reader = new FileReader();
    let imagepath = files;
    reader.readAsDataURL(files[0]);
    reader.onload = (_event) => {
      this.imageSrc = reader.result;
    }
  }

  Submit(addMovieForm: NgForm){
    if(addMovieForm.valid){
        this.newMovie = {
          Id: "",
          AvailabilityStarts: addMovieForm.value.AvailabilityStarts,
          Name: addMovieForm.value.Name,
          Category: addMovieForm.value.Category,
          ContentPath: addMovieForm.value.ContentPath,
          Description: addMovieForm.value.Description,
          IsFeatured: addMovieForm.value.IsFeatured,
          PosterPath: addMovieForm.value.PosterPath,
          YearOfRelease: addMovieForm.value.YearOfRelease
        }
    
        this.movieService.AddMovie(this.newMovie).subscribe(
          (res) => {
            alert(`Added ${this.newMovie.Name}`);
            console.log(res);
          },
          (err) => {
            console.log(err);
          }
        ) 
    
      }
  }
}
