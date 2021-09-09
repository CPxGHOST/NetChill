import { Component, OnInit } from '@angular/core';
import { userDataService } from 'src/app/data-service/userData-service.component';

@Component({
  selector: 'app-add-movie',
  templateUrl: './add-movie.component.html',
  styleUrls: ['./add-movie.component.css']
})
export class AddMovieComponent implements OnInit {
  imageSrc!: any;  
  constructor(private userDataService: userDataService) { }

  ngOnInit(): void {
  }

  // AddImagePreview(event: any){
  //   const reader = new FileReader();
  //   if(event.target.files && event.target.files.length){
  //     const [file] = event.target.files; 
  //     reader.readAsDataURL(file);

  //     reader.onload = () => {
  //       this.imageSrc = reader.result;
  //       alert(this.imageSrc);   
  //     }
  //   }
      
  // }

  preview(files: any){
    const reader = new FileReader();
    let imagepath = files;
    reader.readAsDataURL(files[0]);
    reader.onload = (_event) => {
      this.imageSrc = reader.result;
    }
  }

}
