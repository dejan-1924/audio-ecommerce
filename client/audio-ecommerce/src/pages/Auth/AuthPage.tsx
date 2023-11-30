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

const LoginPage = () => {
  const navigate = useNavigate();
  const authCtx = useContext(AuthContext);

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
      alert("SUCCES!");
      navigate("/login");
    } catch (err: any) {
      alert("ERROR!");
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
      navigate("/shop");
    } catch (err: any) {
      alert("ERROR!");
    }
  };

  return (
    <div className={classes.auth}>
      <Login onLogin={handleLogin}></Login>
      <Register onRegister={handleRegister}></Register>
    </div>
  );
};

export default LoginPage;
