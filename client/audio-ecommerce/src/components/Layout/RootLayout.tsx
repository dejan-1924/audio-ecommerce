import React from "react";
import { Outlet } from "react-router";
import Navbar from "../Navbar/Navbar";
import SearchBar from "../Navbar/SearchBar";

const RootLayout = () => {
  return (
    <>
      <Navbar></Navbar>
      <SearchBar></SearchBar>
      <main>
        <Outlet></Outlet>
      </main>
    </>
  );
};

export default RootLayout;
