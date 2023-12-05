import React from "react";
import classes from "./styles/ProductCard.module.css";
import Select from "react-select";
import { useDispatch } from "react-redux";
import {
  addToCart,
  removeFromCart,
  changeAmount,
} from "../../slices/cartSlice";

let orderOptions: Array<{ value: any; label: any }> = [];
for (let i = 1; i <= 5; i++) {
  orderOptions.push({ value: i, label: i });
}

const ProductCard = (props: any) => {
  const dispatch = useDispatch();

  const removeFromCartHandler = () => {
    dispatch(removeFromCart(props.product.id));
  };

  return (
    <div className={classes.product__container}>
      <img
        src={props.product.imageUrl}
        className={classes.product__image}
        onClick={() => {}}
      ></img>
      <div className={classes.product__topcontainer}>
        <div className={classes.product__infocontainer}>
          <div className={classes.product__info} onClick={() => {}}>
            <p className={classes.product__artist}>
              {props.product.artistName}
            </p>
            <p className={classes.product__title}>{props.product.name}</p>
            <p className={classes.product__details}>2LP | 2023</p>
          </div>
          <div className={classes.product__price}>
            {props.page == "cart" ? (
              <div className={classes.total__price}>
                <p className={classes.product__price}>
                  {props.product.price * props.product.amount}€
                </p>
                <div
                  className={classes.product__amountprice}
                >{`(${props.product.amount} x  ${props.product.price}€)`}</div>
              </div>
            ) : (
              <p className={classes.productPrice}>{props.product.price}€</p>
            )}
          </div>
        </div>
        <div className={classes.product__actions}>
          <div className={classes.cart__actions}>
            {props.page === "products" ? (
              <></>
            ) : props.page === "wishlist" ? (
              <p className={classes.remove__item}>Remove item</p>
            ) : (
              <>
                <Select
                  components={{
                    IndicatorSeparator: () => null,
                  }}
                  defaultValue={{
                    value: props.product.amount,
                    label: props.product.amount,
                  }}
                  options={orderOptions}
                  onChange={(event: any) =>
                    dispatch(
                      changeAmount({
                        id: props.product.id,
                        amount: event.value,
                      })
                    )
                  }
                />

                <p
                  className={classes.remove__item}
                  onClick={removeFromCartHandler}
                >
                  Remove item
                </p>
              </>
            )}
          </div>
        </div>
      </div>
    </div>
  );
};

export default ProductCard;
