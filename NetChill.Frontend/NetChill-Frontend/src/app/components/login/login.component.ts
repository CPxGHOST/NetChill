import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  title:string = 'Login here!';

  checkStatus!: boolean;

  constructor() {
    this.checkStatus = false;
   }

  ngOnInit(): void {
  }

  onSubmit(signInForm : NgForm){
      if(signInForm.valid && this.checkStatus){
        alert("Pressed Submit!");
      }
  }

  switchCheckbox(){
    this.checkStatus = !this.checkStatus;
  }

}
