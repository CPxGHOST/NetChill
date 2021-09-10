import { Component, OnInit } from '@angular/core';
import { userDataService } from 'src/app/data-service/userData-service.component';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  constructor(){};

  ngOnInit(): void {
  }

}
