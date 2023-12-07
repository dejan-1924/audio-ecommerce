import React, { useEffect, useState } from "react";
import classes from "./styles/ProfileInfo.module.css";
import { useGetUserByIdQuery } from "../../../hooks/userHooks";
import dayjs from "dayjs";

const ProfileInfoPage = () => {
  const { data: user, isLoading, error } = useGetUserByIdQuery("1");

  return (
    <div>
      {isLoading ? (
        <div>s</div>
      ) : (
        <div className={classes.info__containers}>
          <h3>Information</h3>
          <div className={classes.info__container}>
            <div className={classes.info__container_title}>Login details</div>
            <div className={classes.info__container_body}>
              <div>
                <span>E-mail address: {user.email}</span>
              </div>
              <div>
                <span>Password: *****</span>
              </div>
            </div>
          </div>
          <div className={classes.info__container}>
            <div className={classes.info__container_title}>Contact data</div>
            <div className={classes.info__container_body}>
              <div>
                <span>Firstname: {user.name}</span>
              </div>
              <div>
                <span>Lastname: {user.surname}</span>
              </div>
              <div>
                <span>
                  Date of birth: {dayjs(user.birthDate).format("DD.MM.YYYY")}
                </span>
              </div>
            </div>
          </div>
          <h3>Addresses</h3>
          {user.addresses.map((address: any, index) => {
            return (
              <div className={classes.info__container}>
                <div className={classes.info__container_title}>
                  Address {index + 1}
                </div>
                <div className={classes.info__container_body}>
                  <div>
                    <span>{address.street}</span>
                  </div>
                  <div>
                    <span>
                      {address.zipCode}, {address.city}
                    </span>
                  </div>
                  <div>
                    <span>{address.country}</span>
                  </div>
                  <div>
                    <span>Tel: {address.phoneNumber}</span>
                  </div>
                  <div>
                    <label>
                      <input
                        type="checkbox"
                        defaultChecked={address.isShipping}
                      ></input>
                      {"  "}
                      Preferred Shipping Address
                    </label>
                  </div>
                  <div>
                    <label>
                      <input
                        type="checkbox"
                        defaultChecked={address.isBilling}
                      ></input>
                      {"  "}
                      Preferred Billing Address
                    </label>
                  </div>
                </div>
              </div>
            );
          })}
        </div>
      )}
    </div>
  );
};

export default ProfileInfoPage;
