import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { SignUpPageComponent } from './sign-up/sign-up-page.component';

@NgModule({
  declarations: [
    AppComponent,
    SignUpPageComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot([
      { path: 'signup', component: SignUpPageComponent} , 
       {path: 'login' , component: LoginComponent}])
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
