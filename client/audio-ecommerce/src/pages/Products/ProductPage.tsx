import React from "react";
import classes from "./styles/ProductPage.module.css";
import { useNavigate, useParams } from "react-router";
import { useGetProductByIdQuery } from "../../hooks/productHooks";
import FavoriteBorderIcon from "@mui/icons-material/FavoriteBorder";
import { useDispatch, useSelector } from "react-redux";
import { addToCart } from "../../slices/cartSlice";

const ProductPage = () => {
  const params = useParams();
  const { data: product, isLoading, error } = useGetProductByIdQuery(params.id);
  const dispatch = useDispatch();
  const navigate = useNavigate();
  const addToCartHandler = () => {
    dispatch(addToCart({ ...product, amount: 1 }));
  };

  return (
    <>
      {isLoading ? (
        <div>Loading...</div>
      ) : (
        <div className={classes.product}>
          <div className={classes.image__container}>
            <img src={product.imageUrl} className={classes.image}></img>
          </div>
          <div className={classes.info}>
            <div>
              <p className={classes.product__artist} onClick={() => {}}>
                {product.artistName}
              </p>
              <p className={classes.product__title}>{product.name}</p>
            </div>
            <p className={classes.product__price}>{product.price}€</p>
            <div className={classes.product__actions}>
              <button
                className={classes.product__cartbutton}
                onClick={addToCartHandler}
              >
                Add to cart
              </button>
            </div>
            <p>Release date : 1 December, 2023</p>
            <p>
              This unique limited-edition single is released on 7” vinyl as a
              collector’s edition to celebrate New Year 2024. Features the
              tracks “Happy New Year” and “Felicidad”, pressed on splatter blue
              / white vinyl with unique artwork.
            </p>
            <p>Formats: Vinyl 7" Single</p>
            <p>Label: UMR/Polydor</p>
          </div>
        </div>
      )}
    </>
  );
};

export default ProductPage;
