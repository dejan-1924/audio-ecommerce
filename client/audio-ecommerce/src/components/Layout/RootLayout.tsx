import React from "react";
import { Outlet } from "react-router";
import Navbar from "../Navbar/Navbar";
import SearchBar from "../Navbar/SearchBar";
import classes from "./styles/RootLayout.module.css";
import Footer from "../Footer/Footer";
import { ToastContainer } from "react-toastify";

const RootLayout = () => {
  return (
    <>
      <ToastContainer
        position="top-right"
        autoClose={5000}
        hideProgressBar={false}
        newestOnTop={false}
        closeOnClick
        rtl={false}
        pauseOnFocusLoss
        draggable
        pauseOnHover
        theme="light"
      />
      <Navbar></Navbar>
      <SearchBar></SearchBar>
      <main className={classes.main}>
        <Outlet></Outlet>
      </main>
      <Footer></Footer>
    </>
  );
};

export default RootLayout;
