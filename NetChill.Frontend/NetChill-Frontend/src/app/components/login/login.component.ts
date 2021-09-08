import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { UserService } from 'src/app/data-service/user-service.component';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  title: string = 'Login here!';

  checkStatus!: boolean;

  constructor(private userService: UserService) {
    this.checkStatus = false;
  }

  ngOnInit(): void {
  }

  onSubmit(signInForm: NgForm) {
    if (signInForm.valid && this.checkStatus) {
      this.userService.LoginUser(signInForm.value).subscribe(
        (res) => {
          alert("Logged in!!");
        },
        (err) => {
          console.log(err);
        }
      )
    }
  }

  switchCheckbox() {
    this.checkStatus = !this.checkStatus;
  }

}
