import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-after-login-navbar',
  templateUrl: './after-login-navbar.component.html',
  styleUrls: ['./after-login-navbar.component.css']
})
export class AfterLoginNavbarComponent implements OnInit {
  pageTitle : string = 'NetChill';
  constructor() { }

  ngOnInit(): void {
  }

}
