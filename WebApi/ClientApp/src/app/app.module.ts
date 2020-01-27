import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { GuardaRotas } from './autorizacao/guarda.rotas';
import { HomeComponent } from './home/home.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { PaisComponent } from './pais/pais.component';
import { UsuarioServico } from './servicos/usuario/usuario.servico';
import { LoginComponent } from './usuario/login/login.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    PaisComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
        { path: 'pais', component: PaisComponent, canActivate: [GuardaRotas] },
      { path: 'entrar', component: LoginComponent }
    ])
    ],
    providers: [UsuarioServico],
  bootstrap: [AppComponent]
})
export class AppModule { }
