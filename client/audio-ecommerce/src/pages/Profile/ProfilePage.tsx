import React from "react";
import classes from "./styles/ProfilePage.module.css";
import { useContext } from "react";
import { useNavigate } from "react-router";
import { AuthContext } from "../../store/auth-store";

const ProfilePage = () => {
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();
  const handleLogout = () => {
    authCtx?.logout();
    navigate("/");
  };

  return (
    <div className={classes.profile}>
      <div className={classes.header}>
        <h3 className={classes.title}>My Profile</h3>
        <button className={classes.logout__button} onClick={handleLogout}>
          Logout
        </button>
      </div>
      <div className={classes.profile__items}>
        <div className={classes.profile__item}>
          <div className={classes.profile__item_title}>My Customer Data</div>
          <div className={classes.profile__item_body}>
            <button
              className={classes.profile__item_button}
              onClick={() => {
                navigate("/profile/information");
              }}
            >
              Show customer data
            </button>
          </div>
        </div>
        <div className={classes.profile__item}>
          <div className={classes.profile__item_title}>My Orders</div>
          <div className={classes.profile__item_body}>
            <button
              className={classes.profile__item_button}
              onClick={() => {
                navigate("/profile/orders");
              }}
            >
              Show orders
            </button>
          </div>
        </div>
        <div className={classes.profile__item}>
          <div className={classes.profile__item_title}>My Addresses</div>
          <div className={classes.profile__item_body}>
            <button className={classes.profile__item_button}>
              Show addresses
            </button>
          </div>
        </div>
        <div className={classes.profile__item}>
          <div className={classes.profile__item_title}>My Wishlist</div>
          <div className={classes.profile__item_body}>
            <button className={classes.profile__item_button}>
              Show wishlist
            </button>
          </div>
        </div>
      </div>
    </div>
  );
};

export default ProfilePage;
