import { ApplicationConfig } from '@angular/core';
import { provideRouter } from '@angular/router';
import { provideStore } from '@ngrx/store';
import { provideEffects } from '@ngrx/effects';
import { provideHttpClient } from '@angular/common/http';
import { routes } from './app.routes';
import { productReducer } from './store/product/product.reducer';
import { ProductEffects } from './store/product/product.effects';
import { orderReducer } from './store/Order/order.reducer';
import { OrderEffects } from './store/Order/order.effects';

export const appConfig: ApplicationConfig = {
  providers: [
    provideRouter(routes),
    provideStore({ 
      products: productReducer, 
      orders: orderReducer 
    }),
    provideEffects([ProductEffects, OrderEffects]),
    provideHttpClient(),
  ],
};