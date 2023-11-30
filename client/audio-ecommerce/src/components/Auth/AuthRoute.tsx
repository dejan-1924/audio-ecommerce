import React from "react";
import { useContext } from "react";
import { Navigate } from "react-router";
import { Outlet } from "react-router";
import { AuthContext } from "../../store/auth-store";

const AuthRoute = (children: any) => {
  const authCtx = useContext(AuthContext);

  return authCtx?.isLoggedIn ? <Outlet /> : <Navigate to="/login" />;
};

export default AuthRoute;
