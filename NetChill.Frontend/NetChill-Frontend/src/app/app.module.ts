import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { SignUpPageComponent } from './components/sign-up/sign-up-page.component';
import { AfterLoginNavbarComponent } from './components/shared/after-login-navbar/after-login-navbar.component';
import { BeforeLoginNavbarComponent } from './components/shared/before-login-navbar/before-login-navbar.component';

@NgModule({
  declarations: [
    AppComponent,
    SignUpPageComponent,
    LoginComponent,
    AfterLoginNavbarComponent,
    BeforeLoginNavbarComponent
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
