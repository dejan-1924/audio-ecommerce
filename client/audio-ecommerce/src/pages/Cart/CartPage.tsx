import React, { useContext } from "react";
import { useDispatch, useSelector } from "react-redux";
import { useNavigate } from "react-router";
import ProductCard from "../../components/Product/ProductCard";
import classes from "./styles/Cart.module.css";
import axios from "axios";
import { AuthContext } from "../../store/auth-store";

const CartPage = () => {
  const navigate = useNavigate();
  const dispatch = useDispatch();
  const { token } = useContext(AuthContext);
  const cart = useSelector((state) => state.cart);

  const { cartItems } = cart;

  const handleOrder = () => {
    let cart: any = [];
    const jwt: any = token();
    cartItems.map((item: any) => {
      cart.push({ id: item.id, amount: item.amount });
    });

    console.log(jwt);
    fetch("https://localhost:7049/api/Order/create", {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + jwt,
      },
      body: JSON.stringify(cart),
    })
      .then((res) => {
        return res.json();
      })
      .then((data) => {
        alert("Success!");
      })
      .catch((error) => {
        alert(error);
      });
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
