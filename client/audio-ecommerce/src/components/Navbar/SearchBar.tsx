import React, { useContext } from "react";
import classes from "./styles/Navbar.module.css";
import SearchIcon from "@mui/icons-material/Search";
import TextField from "@mui/material/TextField";
import InputAdornment from "@mui/material/InputAdornment";
import { useRef } from "react";
import { ShopContext } from "../../store/shop-store";
import { useNavigate } from "react-router";

const SearchBar = () => {
  const queryRef = useRef();
  const shopCtx = useContext(ShopContext);
  const navigate = useNavigate();

  const handleSearch = () => {
    shopCtx?.handleSetSearchQuery(queryRef.current.value);
    shopCtx?.handleResetPage();
    queryRef.current.value = "";
    navigate("/shop");
  };

  return (
    <div className={classes.searchbar}>
      <TextField
        sx={{
          input: {
            color: "black",
            backgroundColor: "rgb(247, 245, 245)",
            padding: "0.5rem",
            "&::placeholder": {
              color: "grey",
              opacity: "1 !important",
            },
          },
        }}
        inputRef={queryRef}
        id="input-with-icon-textfield"
        InputProps={{
          endAdornment: (
            <InputAdornment
              position="start"
              sx={{
                padding: "1.2rem",
                margin: "0rem",
                backgroundColor: "rgb(247, 245, 245)",
              }}
            >
              <SearchIcon onClick={handleSearch} />
            </InputAdornment>
          ),
        }}
        variant="standard"
        fullWidth
        placeholder="Search"
      />
    </div>
  );
};

export default SearchBar;
