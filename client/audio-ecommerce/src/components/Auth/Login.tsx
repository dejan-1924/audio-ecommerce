import React from "react";
import Select from "react-select";
import { useForm } from "react-hook-form";
import axios from "axios";
import { useNavigate } from "react-router";
import { useContext } from "react";
import classes from "../../pages/Auth/styles/AuthPage.module.css";

const Login = (props: any) => {
  const navigate = useNavigate();

  const {
    handleSubmit,
    register,
    formState: { errors },
  } = useForm();

  const onSubmit = async (values: any) => {
    props.onLogin({ email: values.email, password: values.password });
  };

  return (
    <div className={classes.login}>
      <form onSubmit={handleSubmit(onSubmit)} className={classes.login__form}>
        <h3 className={classes.title}>I am already a customer</h3>
        <input
          className={classes.input}
          placeholder="E-mail address"
          type="email"
          {...register("email", {
            required: "Required",
            pattern: {
              value: /^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$/i,
              message: "invalid email address",
            },
          })}
        />

        <input
          className={classes.input}
          placeholder="Password"
          type="password"
          {...register("password", {
            required: "Required",
          })}
        />

        <button type="submit" className={classes.login__button}>
          Login
        </button>
      </form>
    </div>
  );
};

export default Login;
