export interface OrderItem {
  id: number;
  productId: number; // Required
  quantity: number; // Required
  orderId: number;
}

export interface Order {
  id: number;
  orderItems: OrderItem[]; // Must match the backend property name
}