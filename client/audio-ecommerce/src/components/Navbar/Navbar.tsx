import React, { useEffect, useState, useContext } from "react";
import classes from "./styles/Navbar.module.css";
import { Link } from "react-router-dom";
import FavoriteBorderIcon from "@mui/icons-material/FavoriteBorder";
import PersonOutlineIcon from "@mui/icons-material/PersonOutline";
import ShoppingCartIcon from "@mui/icons-material/ShoppingCart";
import SearchIcon from "@mui/icons-material/Search";
import MenuIcon from "@mui/icons-material/Menu";
import { Badge, autocompleteClasses } from "@mui/material";
import SideMenu from "../SideMenu/SideMenu";
import Backdrop from "../SideMenu/Backdrop";
import { AuthContext } from "../../store/auth-store";

const Navbar = () => {
  const [isSideMenuOpen, setIsSideMenuOpen] = useState(false);
  const authCtx = useContext(AuthContext);
  const handleOpenSideMenu = () => {
    setIsSideMenuOpen(true);
  };

  const closeSideMenuHandler = () => {
    setIsSideMenuOpen(false);
  };

  return (
    <div className={classes.navbarContainer}>
      {isSideMenuOpen && (
        <SideMenu closeModal={closeSideMenuHandler}></SideMenu>
      )}
      {isSideMenuOpen && (
        <Backdrop closeSideMenu={closeSideMenuHandler}></Backdrop>
      )}
      <div className={classes.navbar}>
        <div className={classes.navbar__left}>
          <div onClick={handleOpenSideMenu}>
            <MenuIcon></MenuIcon>
          </div>
        </div>

        <div className={classes.navbar__actions}>
          {!authCtx?.isLoggedIn ? (
            <Link to="/login" className={classes.navbar__item}>
              <PersonOutlineIcon></PersonOutlineIcon>
            </Link>
          ) : (
            <Link to="/profile" className={classes.navbar__item}>
              <PersonOutlineIcon></PersonOutlineIcon>
            </Link>
          )}
          <Link to="/wishlist" className={classes.navbar__item}>
            <FavoriteBorderIcon></FavoriteBorderIcon>
          </Link>
          <Link to="/cart" className={classes.navbar__item}>
            <Badge badgeContent={1} color="primary">
              <ShoppingCartIcon></ShoppingCartIcon>
            </Badge>
          </Link>
        </div>
      </div>
    </div>
  );
};

export default Navbar;
