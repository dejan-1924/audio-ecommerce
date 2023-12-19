import React from "react";
import Select from "react-select";
import { useForm } from "react-hook-form";
import axios from "axios";
import { useNavigate } from "react-router";
import { useContext } from "react";
import classes from "../../pages/Auth/styles/AuthPage.module.css";
import { z } from "zod";
import { zodResolver } from "@hookform/resolvers/zod";

const Login = (props: any) => {
  const navigate = useNavigate();

  const schema = z.object({
    email: z
      .string()
      .email({
        message: "Please enter a valid email-address",
      })
      .min(1, { message: "Please enter your email" }),
    password: z.string().min(1, { message: "Please enter your password" }),
  });

  const {
    handleSubmit,
    register,
    formState: { errors },
  } = useForm({ resolver: zodResolver(schema) });

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
          {...register("email")}
        />
        {errors.email && (
          <span className={classes.form__validation_error}>
            {" "}
            {errors.email?.message}
          </span>
        )}
        <input
          className={classes.input}
          placeholder="Password"
          type="password"
          {...register("password")}
        />
        {errors.password && (
          <span className={classes.form__validation_error}>
            {" "}
            {errors.password?.message}
          </span>
        )}
        <button type="submit" className={classes.login__button}>
          Login
        </button>
      </form>
    </div>
  );
};

export default Login;
