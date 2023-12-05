import { createSlice } from "@reduxjs/toolkit";

const initialState: any = localStorage.getItem("cart")
  ? JSON.parse(localStorage.getItem("cart"))
  : { cartItems: [] };

export const updateCart = (state) => {
  localStorage.setItem("cart", JSON.stringify(state));

  return state;
};

const cartSlice = createSlice({
  name: "cart",
  initialState,
  reducers: {
    addToCart: (state, action) => {
      const { ...item } = action.payload;

      if (state.cartItems.length < 1) {
        state.cartItems = [...state.cartItems, item];
      } else {
        const existItem = state.cartItems.find((x) => x.id === item.id);

        if (existItem) {
          state.cartItems = state.cartItems.map((cartItem) =>
            cartItem.id === existItem.id
              ? { ...cartItem, amount: cartItem.amount + 1 }
              : cartItem
          );
        } else {
          state.cartItems = [...state.cartItems, item];
        }
      }
      return updateCart(state, item);
    },
    removeFromCart: (state, action) => {
      console.log(action.payload);
      state.cartItems = state.cartItems.filter((x) => x.id !== action.payload);
      return updateCart(state);
    },
    changeAmount: (state, action) => {
      console.log(action.payload.id);
      console.log(action.payload.amount);
      state.cartItems = state.cartItems.map((cartItem) =>
        cartItem.id === action.payload.id
          ? { ...cartItem, amount: action.payload.amount }
          : cartItem
      );
      return updateCart(state);
    },
    clearCartItems: (state, action) => {
      state.cartItems = [];
      localStorage.setItem("cart", JSON.stringify(state));
    },

    resetCart: (state) => (state = initialState),
  },
});

export const {
  addToCart,
  removeFromCart,
  clearCartItems,
  changeAmount,
  resetCart,
} = cartSlice.actions;

export default cartSlice.reducer;
