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
import { HomeComponent } from './components/home/home.component';
import { MovieListComponent } from './components/movies/movie-list.component';
import { MovieCardComponent } from './components/movie-card/movie-card.component';
import { AddMovieComponent } from './components/add-movie/add-movie.component';
import { UploadContentComponent } from './components/upload-content/upload-content.component';
import { AllMoviesComponent } from './components/all-movies/all-movies.component';
import { FeaturedMoviesComponent } from './components/featured-movies/featured-movies.component';


@NgModule({
  declarations: [
    AppComponent,
    SignUpPageComponent,
    LoginComponent,
    AfterLoginNavbarComponent,
    BeforeLoginNavbarComponent,
    MovieListComponent,
    HomeComponent,
    MovieCardComponent,
    UploadContentComponent,
    AddMovieComponent,
    AllMoviesComponent,
    FeaturedMoviesComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot([
     { path: 'signup',   component: SignUpPageComponent}, 
     { path: 'login',    component: LoginComponent},
     { path: 'home',     component: HomeComponent },
     { path: 'upload',   component: AddMovieComponent},
     { path: 'movies',   component: MovieListComponent},
     { path: 'featured', component: FeaturedMoviesComponent},
     { path: '', redirectTo: 'home', pathMatch: 'full'},
     { path: '**', redirectTo: 'home', pathMatch: 'full'}
    ])
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }