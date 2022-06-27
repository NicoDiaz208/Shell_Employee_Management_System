import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePage } from './home.page';
import { MainDashboardComponent } from './pages/main-dashboard/main-dashboard.component';

const routes: Routes = [
  {
    path: 'home',
    component: HomePage,
    children: [
      { path: 'main-dashboard', component: MainDashboardComponent },
      { path: '', redirectTo: '/home/main-dashboard', pathMatch: 'full' }
    ]
  },
  { path: '', redirectTo: '/home/main-dashboard', pathMatch: 'full' },
  { path: '**', redirectTo: '/home/main-dashboard' }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomePageRoutingModule {}
