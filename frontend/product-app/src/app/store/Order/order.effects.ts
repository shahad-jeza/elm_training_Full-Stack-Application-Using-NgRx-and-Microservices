import { Injectable } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';
import { of } from 'rxjs';
import { catchError, map, mergeMap } from 'rxjs/operators';
import { OrderService } from '../../order-service.service';
import * as OrderActions from './order.actions';

@Injectable()
export class OrderEffects {
  // Load Orders Effect
  loadOrders$ = createEffect(() =>
    this.actions$.pipe(
      ofType(OrderActions.loadOrders),
      mergeMap(() =>
        this.orderService.getOrders().pipe(
          map((orders) => OrderActions.loadOrdersSuccess({ orders })),
          catchError((error) => of(OrderActions.loadOrdersFailure({ error: error.message })))
        )
      )
    ));

  // Add Order Effect
  // Add Order Effect
  addOrder$ = createEffect(() =>
    this.actions$.pipe(
      ofType(OrderActions.addOrder),
      mergeMap((action) => {
        console.log('Dispatching addOrder effect with payload:', action.order); // Debugging
        return this.orderService.addOrder(action.order).pipe(
          map((order) => {
            console.log('Order created successfully:', order); // Debugging
            return OrderActions.addOrderSuccess({ order });
          }),
          catchError((error) => {
            console.error('Error creating order:', error); // Debugging
            return of(OrderActions.addOrderFailure({ error: error.message }));
          })
        );
      })
    ));

  constructor(
    private actions$: Actions,
    private orderService: OrderService
  ) {}
}