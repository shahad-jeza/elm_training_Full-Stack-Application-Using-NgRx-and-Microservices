import { createAction, props } from '@ngrx/store';
import { Product } from '../../models/product.model';

// Load Products
export const loadProducts = createAction('[Product] Load Products');
export const loadProductsSuccess = createAction(
  '[Product] Load Products Success',
  props<{ products: Product[] }>()
);
export const loadProductsFailure = createAction(
  '[Product] Load Products Failure',
  props<{ error: string }>()
);

// Add Product
export const addProduct = createAction(
  '[Product] Add Product',
  props<{ product: Product }>()
);

// Delete Product
export const deleteProduct = createAction(
  '[Product] Delete Product',
  props<{ id: number }>()
);