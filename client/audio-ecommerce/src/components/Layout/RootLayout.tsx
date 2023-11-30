import React from "react";
import { Outlet } from "react-router";
import Navbar from "../Navbar/Navbar";
import SearchBar from "../Navbar/SearchBar";
import classes from "./styles/RootLayout.module.css";

const RootLayout = () => {
  return (
    <>
      <Navbar></Navbar>
      <SearchBar></SearchBar>
      <main className={classes.main}>
        <Outlet></Outlet>
      </main>
    </>
  );
};

export default RootLayout;
