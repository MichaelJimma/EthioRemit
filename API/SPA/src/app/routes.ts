import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { OrdersComponent } from './orders/orders.component';
import { AgentsComponent } from './agents/agents.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
  { path: '', component: HomeComponent },

  {
    path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
      { path: 'agents', component: AgentsComponent },
      { path: 'orders', component: OrdersComponent, canActivate: [AuthGuard] },
    ]
  },
  
  { path: '**', redirectTo: '', pathMatch: 'full' },
];
