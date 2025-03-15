import { createFeatureSelector, createSelector } from '@ngrx/store';
import { OrderState } from './order.reducer';

export const selectOrderState = createFeatureSelector<OrderState>('orders');

export const selectOrders = createSelector(
  selectOrderState,
  (state) => state.orders
);

export const selectLoading = createSelector(
  selectOrderState,
  (state) => state.loading
);

export const selectError = createSelector(
  selectOrderState,
  (state) => state.error
);

export const selectOrderById = (id: number) => 
  createSelector(selectOrders, (orders) => 
    orders.find((order) => order.id === id)
);