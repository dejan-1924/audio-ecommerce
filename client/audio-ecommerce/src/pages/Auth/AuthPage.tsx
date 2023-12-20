import React from "react";
import Select from "react-select";
import { useForm } from "react-hook-form";
import axios from "axios";
import { useNavigate } from "react-router";
import { useContext } from "react";
import classes from "./styles/AuthPage.module.css";
import Login from "../../components/Auth/Login";
import Register from "../../components/Auth/Register";
import { AuthContext } from "../../store/auth-store";
import { ToastContainer, toast } from "react-toastify";
import "react-toastify/dist/ReactToastify.css";
import { ShopContext } from "../../store/shop-store";
const LoginPage = () => {
  const navigate = useNavigate();
  const authCtx = useContext(AuthContext);
  const shopCtx = useContext(ShopContext);
  const handleRegister = async (values: any) => {
    try {
      const result = await axios.post(
        "http://localhost:5100/api/User/register",
        {
          name: values.name,
          password: values.password,
          surname: values.surname,
          email: values.email,
        }
      );
      toast.success("You registered successfully", {
        position: "top-center",
        autoClose: 5000,
        hideProgressBar: true,
        closeOnClick: true,
        pauseOnHover: false,
        draggable: true,
        progress: undefined,
        theme: "light",
      });
    } catch (err: any) {
      toast.error("There is already an account with that email address!", {
        position: "top-center",
        autoClose: 5000,
        hideProgressBar: true,
        closeOnClick: true,
        pauseOnHover: false,
        draggable: true,
        progress: undefined,
        theme: "light",
      });
    }
  };

  const handleLogin = async (values: any) => {
    try {
      const result = await axios.post("http://localhost:5100/api/User/login", {
        email: values.email,
        password: values.password,
      });
      console.log(result.data);
      authCtx?.login(result.data.token);
      shopCtx?.getNumberOfItemsInCart();
      toast.success("You are logged in!", {
        position: "top-center",
        autoClose: 5000,
        hideProgressBar: true,
        closeOnClick: true,
        pauseOnHover: false,
        draggable: true,
        progress: undefined,
        theme: "light",
      });
      navigate("/shop");
    } catch (err: any) {
      toast.error("Wrong credentials!", {
        position: "top-center",
        autoClose: 5000,
        hideProgressBar: true,
        closeOnClick: true,
        pauseOnHover: false,
        draggable: true,
        progress: undefined,
        theme: "light",
      });
    }
  };

  return (
    <>
      <div className={classes.auth}>
        <Login onLogin={handleLogin}></Login>
        <Register onRegister={handleRegister}></Register>
      </div>
    </>
  );
};

export default LoginPage;
