import React from "react";
import classes from "./styles/Product.module.css";
import { useNavigate } from "react-router";

const Product = (props: any) => {
  const navigate = useNavigate();

  const navigateToProduct = (id: number) => {
    navigate(`/shop/item/${id}`);
  };

  return (
    <div className={classes.product}>
      <div className={classes.image__container}>
        <img
          src={props.imageUrl}
          className={classes.product__image}
          onClick={() => {
            navigateToProduct(props.id);
          }}
        ></img>
      </div>
      <div className={classes.product__info}>
        <p className={classes.product__artist}>{props.artist}</p>
        <p className={classes.product__title}>{props.name}</p>
        <p className={classes.product__price}>€{props.price}</p>
      </div>
    </div>
  );
};

export default Product;
