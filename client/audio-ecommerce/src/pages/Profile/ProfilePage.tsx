import React from "react";
import { AuthContext } from "../../store/auth-store";
import { useContext } from "react";
import { useNavigate } from "react-router";
const ProfilePage = () => {
  const authCtx = useContext(AuthContext);
  const navigate = useNavigate();

  const handleLogout = () => {
    authCtx?.logout();
    navigate("/");
  };

  return <button onClick={handleLogout}>Logout</button>;
};

export default ProfilePage;
