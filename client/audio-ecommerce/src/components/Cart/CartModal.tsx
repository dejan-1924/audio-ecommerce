import React, { useContext } from "react";
import classes from "./styles/CartModal.module.css";
import { useNavigate } from "react-router";
import { useQuery, useQueryClient } from "@tanstack/react-query";
import ProductCard from "../Product/ProductCard";
import axios from "axios";
import { fetchCart } from "../../hooks/productHooks";
import { AuthContext } from "../../store/auth-store";

const CartModal = (props: any) => {
  const navigate = useNavigate();
  const authCtx = useContext(AuthContext);
  const { data, isLoading } = useQuery({
    queryFn: () => fetchCart(),
    queryKey: ["cartItems"],
  });

  return (
    <div className={classes.sidemenu}>
      <div className={classes.sidemenu__content}>
        <div className={classes.sidemenu__header}>
          <div className={classes.title}>Cart items</div>
        </div>
        <div className={classes.sidemenu__body}>
          {!isLoading ? (
            <>
              {data.items?.length > 0 ? (
                <div>
                  <div className={classes.items__container}>
                    {data.items?.map((cartItem) => (
                      <ProductCard
                        product={cartItem}
                        page="modal"
                      ></ProductCard>
                    ))}
                  </div>
                </div>
              ) : (
                <div className={classes.emptycart__container}>
                  Your cart is empty.
                </div>
              )}
            </>
          ) : (
            <div className={classes.loading}>Loading ...</div>
          )}
        </div>
      </div>
      <div className={classes.sidemenu__footer}>
        {!isLoading && (
          <div className={classes.cart_total}>
            <div>Total price : </div>
            <div>{data.total}€</div>
          </div>
        )}
        <button
          className={classes.applyfilter_button}
          onClick={() => {
            props.closeModal();
            navigate("/cart");
          }}
        >
          View Cart
        </button>
      </div>
    </div>
  );
};

export default CartModal;
