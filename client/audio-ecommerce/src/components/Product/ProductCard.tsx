import React from "react";
import classes from "./styles/ProductCard.module.css";
import Select from "react-select";
import { useDispatch } from "react-redux";
import {
  addToCart,
  removeFromCart,
  changeAmount,
} from "../../slices/cartSlice";
import { useNavigate } from "react-router";

function createOptions(amount: number) {
  console.log(amount);
  let orderOptions: Array<{ value: any; label: any }> = [];
  const max = amount > 5 ? 5 : amount;
  for (let i = 1; i <= max; i++) {
    orderOptions.push({ value: i, label: i });
  }
  return orderOptions;
}

const ProductCard = (props: any) => {
  const dispatch = useDispatch();
  const navigate = useNavigate();
  const removeFromCartHandler = () => {
    dispatch(removeFromCart(props.product.id));
  };

  return (
    <>
      {props.product.inStock < 1 && (
        <>
          <div className={classes.product__container_message}>
            Item is currently sold out. Please remove it from cart.
          </div>
          <div className={classes.product__container_arrow}></div>
        </>
      )}
      <div className={classes.product__container}>
        <img
          src={props.product.imageUrl}
          className={classes.product__image}
          onClick={() => {
            navigate(`/shop/item/${props.product.id}`);
          }}
        ></img>
        <div className={classes.product__topcontainer}>
          <div className={classes.product__infocontainer}>
            <div className={classes.product__info}>
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
                  {props.product.inStock < 1 ? (
                    <Select
                      components={{
                        IndicatorSeparator: () => null,
                      }}
                      defaultValue={{
                        value: props.product.amount,
                        label: props.product.amount,
                      }}
                      isDisabled
                      options={createOptions(props.product.inStock)}
                      onChange={(event: any) =>
                        dispatch(
                          changeAmount({
                            id: props.product.id,
                            amount: event.value,
                          })
                        )
                      }
                    />
                  ) : (
                    <Select
                      components={{
                        IndicatorSeparator: () => null,
                      }}
                      defaultValue={{
                        value: props.product.amount,
                        label: props.product.amount,
                      }}
                      options={createOptions(props.product.inStock)}
                      onChange={(event: any) =>
                        props.changeAmount({
                          id: props.product.id,
                          amount: event.value,
                        })
                      }
                    />
                  )}

                  <p
                    className={classes.remove__item}
                    onClick={() => props.remove(props.product.id)}
                  >
                    Remove item
                  </p>
                </>
              )}
            </div>
          </div>
        </div>
      </div>
    </>
  );
};

export default ProductCard;
