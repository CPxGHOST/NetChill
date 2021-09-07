import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { SignUpPageComponent } from './sign-up/sign-up-page.component';

@NgModule({
  declarations: [
    AppComponent,
    SignUpPageComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot([
      { path: 'signup', component: SignUpPageComponent}
    ])
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
