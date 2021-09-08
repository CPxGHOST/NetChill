import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { SignUpPageComponent } from './components/sign-up/sign-up-page.component';
import { AfterLoginNavbarComponent } from './components/shared/after-login-navbar/after-login-navbar.component';
import { BeforeLoginNavbarComponent } from './components/shared/before-login-navbar/before-login-navbar.component';
import { HomeComponent } from './components/home/home.component';
import { MovieListComponent } from './components/movies/movie-list.component';
import { MovieCardComponent } from './components/movie-card/movie-card.component';

@NgModule({
  declarations: [
    AppComponent,
    SignUpPageComponent,
    LoginComponent,
    AfterLoginNavbarComponent,
    BeforeLoginNavbarComponent,
    MovieListComponent,
    HomeComponent,
    MovieCardComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot([
      { path: 'signup', component: SignUpPageComponent} , 
      {path: 'login' , component: LoginComponent},
      { path: 'home', component: HomeComponent },
      { path: 'movies', component: MovieListComponent },
      { path: '', redirectTo: 'home', pathMatch: 'full' },
      { path: '**', redirectTo: 'home', pathMatch: 'full' }
    ])
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
