import { createReducer, on } from '@ngrx/store';
import { Order } from '../../models/order.model';
import * as OrderActions from './order.actions';

export interface OrderState {
  orders: Order[];
  loading: boolean;
  error: string | null;
}

export const initialState: OrderState = {
  orders: [],
  loading: false,
  error: null,
};

export const orderReducer = createReducer(
  initialState,
  on(OrderActions.loadOrders, (state) => ({
    ...state,
    loading: true,
    error: null,
  })),
  on(OrderActions.loadOrdersSuccess, (state, { orders }) => ({
    ...state,
    orders,
    loading: false,
  })),
  on(OrderActions.loadOrdersFailure, (state, { error }) => ({
    ...state,
    error,
    loading: false,
  })),
  on(OrderActions.addOrder, (state, { order }) => ({
    ...state,
    orders: [...state.orders, order],
  })),
  on(OrderActions.deleteOrder, (state, { id }) => ({
    ...state,
    orders: state.orders.filter((o) => o.id !== id),
  }))
);