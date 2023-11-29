import React from "react";
import classes from "../Navbar/styles/Navbar.module.css";
import { Link } from "react-router-dom";
const FiltersModal = (props: any) => {
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
          Artist
        </div>
        <div className={classes.sidemenu__item} onClick={props.closeModal}>
          Label
        </div>
        <div></div>
      </div>
    </div>
  );
};

export default FiltersModal;
