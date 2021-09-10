import { HttpClient, HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { SignUpPageComponent } from './components/sign-up/sign-up-page.component';
import { AfterLoginNavbarComponent } from './components/shared/after-login-navbar/after-login-navbar.component';
import { BeforeLoginNavbarComponent } from './components/shared/before-login-navbar/before-login-navbar.component';
import { WelcomeComponent } from './components/welcome/welcome.component';
import { MovieListComponent } from './components/movies/movie-list.component';
import { MovieCardComponent } from './components/movie-card/movie-card.component';
import { AddMovieComponent } from './components/add-movie/add-movie.component';
import { UploadContentComponent } from './components/upload-content/upload-content.component';
import { FeaturedMoviesComponent } from './components/featured-movies/featured-movies.component';
import { ViewMovieComponent } from './components/view-movie/view-movie.component';
import { HomeComponent } from './components/home/home.component';
import { DisplayMoviesComponent } from './components/shared/display-movies/display-movies.component';
import { MoviesNavbarComponent } from './components/shared/movies-navbar/movies-navbar.component';



@NgModule({
  declarations: [
    AppComponent,
    SignUpPageComponent,
    LoginComponent,
    AfterLoginNavbarComponent,
    BeforeLoginNavbarComponent,
    MovieListComponent,
    WelcomeComponent,
    MovieCardComponent,
    UploadContentComponent,
    AddMovieComponent,
    FeaturedMoviesComponent,
    ViewMovieComponent,
    HomeComponent,
    DisplayMoviesComponent,
    MoviesNavbarComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot([
      { path: 'featured', component: FeaturedMoviesComponent},
      { path: 'signup', component: SignUpPageComponent} , 
      { path: 'login' , component: LoginComponent},
      { path: 'welcome', component: WelcomeComponent },
      { path: 'movies/:id', component: ViewMovieComponent},
      { path: 'upload', component: UploadContentComponent},
      { path: 'movies', component: MovieListComponent },
      { path: 'home', component: HomeComponent },
      { path: 'display', component: DisplayMoviesComponent},
      { path: '', redirectTo: 'welcome', pathMatch: 'full' },
      { path: '**', redirectTo: 'welcome', pathMatch: 'full' }
    ])
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }