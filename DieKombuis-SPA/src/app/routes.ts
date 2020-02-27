import {Routes} from '@angular/router';
import { HomeComponent } from './home/home.component';
import { MenuListComponent } from './menu-list/menu-list.component';
import { OrdersComponent } from './orders/orders.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
    { path: '', component: HomeComponent},
    {
        path: '',
        runGuardsAndResolvers: 'always',
        canActivate: [AuthGuard],
        children : [
            { path: 'menu', component: MenuListComponent},
            { path: 'orders', component: OrdersComponent},
        ]
    },
    { path: '**', redirectTo: '', pathMatch: 'full'}

];
