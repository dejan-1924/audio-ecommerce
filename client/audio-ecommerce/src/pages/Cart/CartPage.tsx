import React from "react";
import { useDispatch, useSelector } from "react-redux";
import { useNavigate } from "react-router";
import ProductCard from "../../components/Product/ProductCard";
import classes from "./styles/Cart.module.css";

const CartPage = () => {
  const navigate = useNavigate();
  const dispatch = useDispatch();

  const cart = useSelector((state) => state.cart);
  const { cartItems } = cart;

  console.log(cartItems);
  return (
    <div className={classes.cart}>
      <div className={classes.title}>
        <h3>My cart</h3>
      </div>
      {cartItems.length > 0 ? (
        cartItems?.map((cartItem) => (
          <ProductCard product={cartItem} page="cart"></ProductCard>
        ))
      ) : (
        <div className={classes.emptycart__container}>Your cart is empty.</div>
      )}
    </div>
  );
};

export default CartPage;
