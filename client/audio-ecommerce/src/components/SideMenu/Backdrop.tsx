import React from "react";
import classes from "../Navbar/styles/Navbar.module.css";

const Backdrop = (props: any) => {
  return <div className={classes.backdrop} onClick={props.closeSideMenu}></div>;
};

export default Backdrop;
