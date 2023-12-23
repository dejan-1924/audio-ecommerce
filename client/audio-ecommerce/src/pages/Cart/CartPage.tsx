import React, { useContext, useEffect, useState } from "react";
import { useDispatch, useSelector } from "react-redux";
import { useNavigate } from "react-router";
import ProductCard from "../../components/Product/ProductCard";
import classes from "./styles/Cart.module.css";
import axios from "axios";
import { AuthContext } from "../../store/auth-store";
import { clearCartItems, resetCart } from "../../slices/cartSlice";
import { toast } from "react-toastify";
import { ShopContext } from "../../store/shop-store";
import { useMutation, useQuery, useQueryClient } from "@tanstack/react-query";
import { fetchCart } from "../../hooks/productHooks";

const CartPage = () => {
  const navigate = useNavigate();
  const dispatch = useDispatch();
  const { token } = useContext(AuthContext);
  const cart = useSelector((state) => state.cart);
  const { cartItems } = cart;
  const [datas, setData] = useState([]);
  const shopCtx = useContext(ShopContext);
  const queryClient = useQueryClient();
  const authCtx = useContext(AuthContext);

  const { data, isLoading } = useQuery({
    queryFn: () => fetchCart(),
    queryKey: ["cartItems"],
  });

  const handleOrder = () => {
    let cart: any = [];
    cartItems.map((item: any) => {
      cart.push({ id: item.id, amount: item.amount });
    });

    const token = console.log(localStorage.getItem("token"));

    const URL = "https://localhost:7049/api/Order/create";
    const headers = {
      Authorization: "Bearer " + localStorage.getItem("token"),
    };
    fetch(URL, { method: "POST", headers })
      .then((response) => {})
      .then((data) => {
        toast.success("You have successfully placed an order!", {
          position: "top-center",
          autoClose: 5000,
          hideProgressBar: true,
          closeOnClick: true,
          pauseOnHover: false,
          draggable: true,
          progress: undefined,
          theme: "light",
        });
        shopCtx?.getNumberOfItemsInCart();
        navigate("/profile/orders");
      })
      .catch((error) => {
        toast.error(error.response.data.message, {
          position: "top-center",
          autoClose: 5000,
          hideProgressBar: true,
          closeOnClick: true,
          pauseOnHover: false,
          draggable: true,
          progress: undefined,
          theme: "light",
        });
      });
  };

  return (
    <div className={classes.cart}>
      <div className={classes.title}>
        <h3>My cart</h3>
      </div>
      {authCtx?.isLoggedIn ? (
        <>
          {!isLoading ? (
            <>
              {data.items?.length > 0 ? (
                <div>
                  {data.items?.map((cartItem) => (
                    <ProductCard product={cartItem} page="cart"></ProductCard>
                  ))}
                  <div className={classes.cart_total}>
                    <div>Total price : {data.total}€</div>
                    <div className={classes.order__button_container}>
                      <button
                        className={classes.order__button}
                        onClick={handleOrder}
                      >
                        Order
                      </button>
                    </div>
                  </div>
                </div>
              ) : (
                <div className={classes.emptycart__container}>
                  Your cart is empty.
                </div>
              )}
            </>
          ) : (
            <div>Loading ...</div>
          )}
        </>
      ) : (
        <div>Log in to see your cart.</div>
      )}
    </div>
  );
};

export default CartPage;
