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

  const handleOrder = () => {
    let cart: any = [];

    cartItems.map((item: any) => {
      cart.push({ id: item.id, amount: item.amount });
    });

    console.log(cart);
  };

  return (
    <div className={classes.cart}>
      <div className={classes.title}>
        <h3>My cart</h3>
      </div>

      {cartItems.length > 0 ? (
        <div>
          {cartItems?.map((cartItem) => (
            <ProductCard product={cartItem} page="cart"></ProductCard>
          ))}
          <div className={classes.cart_total}>
            <div>
              Total price :{" "}
              {cartItems
                .reduce((acc, item) => acc + item.amount * item.price, 0)
                .toFixed(2)}{" "}
              €
            </div>
            <div className={classes.order__button_container}>
              <button className={classes.order__button} onClick={handleOrder}>
                Order
              </button>
            </div>
          </div>
        </div>
      ) : (
        <div className={classes.emptycart__container}>Your cart is empty.</div>
      )}
    </div>
  );
};

export default CartPage;
