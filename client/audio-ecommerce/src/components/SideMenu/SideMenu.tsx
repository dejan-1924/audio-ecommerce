import React from "react";
import classes from "../Navbar/styles/Navbar.module.css";
import { Link } from "react-router-dom";

const SideMenu = (props: any) => {
  return (
    <div className={classes.sidemenu}>
      <div className={classes.sidemenu__header}>
        <button
          className={classes.sidemenu__closebutton}
          onClick={props.closeModal}
        >
          X
        </button>
      </div>
      <div className={classes.sidemenu__body}>
        <div className={classes.sidemenu__item} onClick={props.closeModal}>
          <Link to="/shop" className={classes.sidemenu__link}>
            Records
          </Link>
        </div>
        <div className={classes.sidemenu__item} onClick={props.closeModal}>
          <Link to="/" className={classes.sidemenu__link}>
            Clothing
          </Link>
        </div>
        <div></div>
      </div>
    </div>
  );
};

export default SideMenu;
