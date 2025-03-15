import { Routes } from '@angular/router';
import { ProductListComponent } from './product-list/product-list.component';
import { AddProductComponent } from './add-product/add-product.component';
import { ProductDetailsComponent } from './product-details/product-details.component';
import { OrderListComponent } from './order-list/order-list.component';
import { PlaceOrderComponent } from './place-order/place-order.component';
import { OrderDetailsComponent } from './order-details/order-details.component';

export const routes: Routes = [
  { path: '', component: ProductListComponent },
  { path: 'add-product', component: AddProductComponent },
  { path: 'product/:id', component: ProductDetailsComponent },
  { path: 'orders', component: OrderListComponent },
  { path: 'place-order', component: PlaceOrderComponent },
  { path: 'order/:id', component: OrderDetailsComponent },
];