import React from "react";
import Select from "react-select";
import { useForm } from "react-hook-form";
import axios from "axios";
import { useNavigate } from "react-router";
import { useContext } from "react";
import classes from "../../pages/Auth/styles/AuthPage.module.css";
import { z } from "zod";
import { zodResolver } from "@hookform/resolvers/zod";

const Register = (props: any) => {
  const navigate = useNavigate();

  const schema = z
    .object({
      firstName: z
        .string()
        .min(1, { message: "Firstname is required" })
        .max(30),
      lastName: z.string().min(1, { message: "Lastname is required" }).max(30),
      email: z
        .string()
        .email({
          message: "Please enter a valid email-address",
        })
        .min(1, { message: "Email is required" }),
      password: z
        .string()
        .min(8, { message: "Password must be atleast 8 characters" })
        .regex(
          new RegExp(/^(?=.*[A-Z])(?=.*[!@#$&*])(?=.*[0-9])(?=.*[a-z]).{8,}$/)
        ),
      confirmPassword: z.string(),
    })
    .refine((data) => data.password === data.confirmPassword, {
      message: "Passwords do not match",
      path: ["confirmPassword"],
    });

  const {
    handleSubmit,
    register,
    formState: { errors },
  } = useForm({ resolver: zodResolver(schema) });

  const onSubmit = async (values: any) => {
    props.onRegister({
      name: values.firstName,
      password: values.password,
      surname: values.lastName,
      email: values.email,
    });
  };

  return (
    <div className={classes.register}>
      <form onSubmit={handleSubmit(onSubmit)} className={classes.login__form}>
        <h3 className={classes.title}>I am a new customer</h3>
        <input
          className={classes.input}
          placeholder="Firstname*"
          {...register("firstName")}
        />
        {errors.firstName && (
          <span className={classes.form__validation_error}>
            {" "}
            {errors.firstName?.message}
          </span>
        )}
        <input
          className={classes.input}
          placeholder="Lastname*"
          {...register("lastName")}
        />
        {errors.lastName && (
          <span className={classes.form__validation_error}>
            {" "}
            {errors.lastName?.message}
          </span>
        )}
        <input
          className={classes.input}
          placeholder="E-Mail*"
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
          placeholder="Password*"
          type="password"
          {...register("password", {
            required: "Required",
          })}
        />
        {errors.password && (
          <span className={classes.form__validation_error}>
            {" "}
            {errors.password?.message}
          </span>
        )}
        <input
          className={classes.input}
          placeholder="Confirm Password*"
          type="password"
          {...register("confirmPassword")}
        />
        {errors.confirmPassword && (
          <span className={classes.form__validation_error}>
            {" "}
            {errors.confirmPassword?.message}
          </span>
        )}
        <button type="submit" className={classes.login__button}>
          Register
        </button>
      </form>
    </div>
  );
};

export default Register;
