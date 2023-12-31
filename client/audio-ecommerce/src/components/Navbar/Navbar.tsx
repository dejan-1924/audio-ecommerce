import React, { useEffect, useState, useContext, useRef } from "react";
import classes from "./styles/Navbar.module.css";
import { Link, useLocation, useNavigate } from "react-router-dom";
import PersonOutlineIcon from "@mui/icons-material/PersonOutline";
import ShoppingCartIcon from "@mui/icons-material/ShoppingCart";
import SearchIcon from "@mui/icons-material/Search";
import MenuIcon from "@mui/icons-material/Menu";
import { Badge } from "@mui/material";
import SideMenu from "../SideMenu/SideMenu";
import Backdrop from "../SideMenu/Backdrop";
import { AuthContext } from "../../store/auth-store";
import { ShopContext } from "../../store/shop-store";
import { useSelector } from "react-redux";

import CartModal from "../Cart/CartModal";

const Navbar = () => {
  const [isSideMenuOpen, setIsSideMenuOpen] = useState(false);

  const authCtx = useContext(AuthContext);
  const {
    resetFilters,
    handleSetSearchQuery,
    handleResetPage,
    handleOpenCartModal,
    handleCloseCartModal,
    handleGetCartModal,
  } = useContext(ShopContext);
  const [toggleSearch, setToggleSearch] = useState(false);
  const queryRef = useRef();
  const cart = useSelector((state) => state.cart);
  const { cartItems } = cart;
  const shopCtx = useContext(ShopContext);

  const handleOpenSideMenu = () => {
    setIsSideMenuOpen(true);
  };
  const navigate = useNavigate();
  const closeSideMenuHandler = () => {
    setIsSideMenuOpen(false);
  };
  const closeCartModal = () => {
    handleCloseCartModal();
  };
  const location = useLocation();
  const handleViewRecords = () => {
    if (location.pathname != "/shop") {
      resetFilters();
    }
    navigate("/shop");
  };

  const handleToggleSearch = () => {
    setToggleSearch(!toggleSearch);
  };

  const handleSearch = () => {
    if (queryRef.current.value == "") {
      return;
    }
    handleSetSearchQuery(queryRef.current.value);
    handleResetPage();
    queryRef.current.value = "";
    navigate("/shop");
  };

  let isCartModalOpen = handleGetCartModal();

  useEffect(() => {
    if (isSideMenuOpen || isCartModalOpen) {
      document.body.style.overflow = "hidden";
    } else {
      document.body.style.overflow = "unset";
    }
  }, [isSideMenuOpen, isCartModalOpen]);

  return (
    <div className={classes.navbarContainer}>
      {isSideMenuOpen && (
        <>
          <SideMenu closeModal={closeSideMenuHandler}></SideMenu>
          <Backdrop closeSideMenu={closeSideMenuHandler}></Backdrop>
        </>
      )}
      {handleGetCartModal() && (
        <>
          <CartModal closeModal={closeCartModal}></CartModal>
          <Backdrop closeSideMenu={closeCartModal}></Backdrop>
        </>
      )}
      <div className={classes.navbar}>
        <div className={classes.navbar__left}>
          <div onClick={handleOpenSideMenu}>
            <MenuIcon></MenuIcon>
          </div>
        </div>
        <div className={classes.navbar__left_FS}>
          <div onClick={handleViewRecords} className={classes.navbar__item}>
            Records
          </div>
          <div className={classes.navbar__item}>Clothing</div>
        </div>
        <div className={classes.navbar__actions}>
          <div className={classes.navbar__item}>
            <div
              className={classes.navbar__search}
              onClick={handleToggleSearch}
            >
              <input ref={queryRef} placeholder="Search"></input>
              <SearchIcon onClick={handleSearch}></SearchIcon>
            </div>
          </div>
          {!authCtx?.isLoggedIn ? (
            <Link to="/login" className={classes.navbar__item}>
              <PersonOutlineIcon></PersonOutlineIcon>
            </Link>
          ) : (
            <Link to="/profile" className={classes.navbar__item}>
              <PersonOutlineIcon></PersonOutlineIcon>
            </Link>
          )}

          <div
            className={classes.navbar__item}
            onClick={() => {
              if (location.pathname == "/cart") {
              } else {
                handleOpenCartModal();
              }
            }}
          >
            <Badge
              badgeContent={shopCtx?.numberOfItemsInCart()}
              color="primary"
            >
              <ShoppingCartIcon></ShoppingCartIcon>
            </Badge>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Navbar;
