import React from "react";
import Select from "react-select";
import { useForm } from "react-hook-form";
import axios from "axios";
import { useNavigate } from "react-router";
import { useContext } from "react";
import classes from "../../pages/Auth/styles/AuthPage.module.css";

const Register = (props: any) => {
  const navigate = useNavigate();

  const {
    control,
    handleSubmit,
    register,
    formState: { errors },
  } = useForm({
    defaultValues: {
      firstName: "",
      lastName: "",
      email: "",
      password: "",
    },
  });

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
          {...register("firstName", {
            required: "Required",
            maxLength: 30,
            minLength: 1,
          })}
        />
        {errors.firstName && errors.firstName.type === "maxLength" && (
          <span>Firstname must be shorter than 30 characters.</span>
        )}
        {errors.firstName && errors.firstName.type === "minLength" && (
          <span>Firstname must not be empty.</span>
        )}
        <input
          className={classes.input}
          placeholder="Lastname*"
          {...register("lastName", {
            required: "Required",
            maxLength: 30,
            minLength: 1,
          })}
        />
        {errors.lastName && errors.lastName.type === "maxLength" && (
          <span>Lastname must be shorter than 30 characters.</span>
        )}
        {errors.lastName && errors.lastName.type === "minLength" && (
          <span>Lastname must not be empty.</span>
        )}
        <input
          className={classes.input}
          placeholder="E-Mail*"
          type="email"
          {...register("email", {
            required: "Required",
            pattern: {
              value: /^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}$/i,
              message: "invalid email address",
            },
          })}
        />
        {errors.email && errors.email.message}

        <input
          className={classes.input}
          placeholder="Password*"
          type="password"
          {...register("password", {
            required: "Required",
          })}
        />
        {errors.password && <span>{errors.password.message}.</span>}

        <button type="submit" className={classes.login__button}>
          Register
        </button>
      </form>
    </div>
  );
};

export default Register;
