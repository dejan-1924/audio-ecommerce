import React, { useContext } from "react";
import classes from "../Navbar/styles/Navbar.module.css";
import { Link, useNavigate } from "react-router-dom";
import { ShopContext } from "../../store/shop-store";

const SideMenu = (props: any) => {
  const navigate = useNavigate();
  const { resetFilters } = useContext(ShopContext);
  const handleViewRecords = () => {
    if (location.pathname != "/shop") {
      resetFilters();
    }
    navigate("/shop");
  };

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
          <div onClick={handleViewRecords} className={classes.sidemenu__link}>
            Records
          </div>
        </div>
        <div className={classes.sidemenu__item} onClick={props.closeModal}>
          <div className={classes.sidemenu__link}>Clothing</div>
        </div>
        <div></div>
      </div>
    </div>
  );
};

export default SideMenu;
