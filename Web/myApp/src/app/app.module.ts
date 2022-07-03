import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { ButtonComponent } from './button/button.component';
import { CreateComponent } from './category/create/create.component';
import { DeleteComponent } from './category/delete/delete.component';
import { EditComponent } from './category/edit/edit.component';
import { ListComponent } from './category/list/list.component';
import { BodyComponent } from './main/body/body.component';
import { FooterComponent } from './main/footer/footer.component';
import { HeaderComponent } from './main/header/header.component';
import { SidebarComponent } from './main/sidebar/sidebar.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    SidebarComponent,
    FooterComponent,
    BodyComponent,
    ButtonComponent,
    ListComponent,
    CreateComponent,
    EditComponent,
    DeleteComponent,

  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
