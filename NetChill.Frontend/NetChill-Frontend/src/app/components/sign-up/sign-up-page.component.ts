import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { UserService } from 'src/app/data-service/user-service.component';

@Component({
  selector: 'app-signup',
  templateUrl: './sign-up-page.component.html',
  styleUrls: ['./sign-up-page.component.css']
})
export class SignUpPageComponent implements OnInit {
  title: string = 'Sign-up here!';
  constructor(private userDataService: UserService) { }

  ngOnInit(): void {
  }

  onSubmit(signUpForm: NgForm) {
    if (signUpForm.valid) {
      this.userDataService.AddUser(signUpForm.value).subscribe(
        (res) => {
          alert("Signed up!");
        },
        err => {
          console.log(err);
        }
      )
    }
  }

}
