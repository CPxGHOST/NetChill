import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { UserService } from 'src/app/data-service/user-service.component';
import { IUser } from 'src/app/models/IUser';

@Component({
  selector: 'app-signup',
  templateUrl: './sign-up-page.component.html',
  styleUrls: ['./sign-up-page.component.css']
})
export class SignUpPageComponent implements OnInit {
  title: string = 'Sign-up here!';
  newUser!: IUser;
  constructor(private userDataService: UserService) { }

  ngOnInit(): void {
  }

  onSubmit(signUpForm: NgForm) {
    if (signUpForm.valid) {
      this.newUser = {
        Id: '',
        Email: signUpForm.value.Email,
        FullName: signUpForm.value.FullName,
        Password: signUpForm.value.Password,
        Role: 0
      };
      console.log(this.newUser);
      this.userDataService.AddUser(this.newUser).subscribe(
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
