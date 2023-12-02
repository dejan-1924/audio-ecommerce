import React, { useEffect } from "react";
import classes from "./styles/Filters.module.css";
import { useContext, useState } from "react";
import { useGetProductsBySearchQuery } from "../../hooks/productHooks";
import { Pagination } from "@mui/material";
import { ShopContext } from "../../store/shop-store";
import axios from "axios";
import KeyboardArrowDownIcon from "@mui/icons-material/KeyboardArrowDown";

const ordering_options = [
  { label: "Relevance", value: "REL" },
  { label: "Price, low to high", value: "PRICE_ASC" },
  { label: "Price, high to low", value: "PRICE_DESC" },
  { label: "Alphabetically", value: "AZ" },
];
const formats = [
  { id: 1, name: "Vinyl" },
  { id: 2, name: "CD" },
];

const itemNumber = 10;
const Filters = (props: any) => {
  const [toggleOrdering, setToggleOrdering] = useState(false);
  const [toggleArtists, setToggleArtists] = useState(false);
  const [toggleFormats, setToggleFormats] = useState(false);
  const [artists, setArtists] = useState<any[]>([]);
  const {
    handleGetPage,
    handleSetPage,
    handleGetSearchQuery,
    handleGetSelectedArtists,
    handleSelectedArtist,
    isArtistChecked,
    handleGetOrdering,
    handleSetOrdering,
    handleSetSelectedFormats,
    handleGetSelectedFormats,
    isFormatChecked,
    setFilters,
  } = useContext(ShopContext);

  useEffect(() => {
    axios.get(`http://localhost:5100/api/Artist`).then((res) => {
      console.log(res.data);
      setArtists(res.data);
    });
  }, []);

  const handleToggleOrdering = () => {
    setToggleOrdering(!toggleOrdering);
  };
  const handleToggleArtists = () => {
    setToggleArtists(!toggleArtists);
  };
  const handleToggleFormats = () => {
    setToggleFormats(!toggleFormats);
  };

  const isChecked = (id: number) => {
    return isArtistChecked(id);
  };

  const handleCheckArtist = (id: number) => {
    handleSelectedArtist(id);
  };
  const handleCheckFormat = (id: number) => {
    handleSetSelectedFormats(id);
  };
  const hadnleIsFormatChecked = (id: number) => {
    return isFormatChecked(id);
  };

  const handleApplyArtists = () => {
    setFilters();
    setToggleArtists(false);
  };

  return (
    <div className={classes.filters}>
      <div className={classes.filter}>
        <div className={classes.filter__item_container}>
          <div className={classes.filter__item} onClick={handleToggleOrdering}>
            <div className={classes.filter__item_applied}>
              {handleGetOrdering().label}{" "}
              <KeyboardArrowDownIcon></KeyboardArrowDownIcon>
            </div>
          </div>
        </div>
        {toggleOrdering && (
          <div className={classes.filter__menu_ordering}>
            <ul>
              {ordering_options.map((option) => {
                return (
                  <li
                    onClick={() => {
                      handleSetOrdering(option);
                      setToggleOrdering(false);
                    }}
                    className={
                      option.value === handleGetOrdering().value
                        ? classes.filter__item_selected
                        : ""
                    }
                  >
                    {option.label}
                  </li>
                );
              })}
            </ul>
          </div>
        )}
      </div>
      <div className={classes.filter}>
        <div className={classes.filter__item_container}>
          <div
            className={classes.filter__item_artist}
            onClick={handleToggleArtists}
          >
            <div className={classes.filter__item_applied}>
              Artist
              <KeyboardArrowDownIcon></KeyboardArrowDownIcon>
            </div>
          </div>
        </div>
        {toggleArtists && (
          <>
            {artists && (
              <div className={classes.artists__container}>
                <div className={classes.artists}>
                  {artists.map((artist: any) => {
                    return (
                      <label className={classes.artist}>
                        <input
                          type="checkbox"
                          checked={isChecked(artist.id)}
                          onChange={() => handleCheckArtist(artist.id)}
                        ></input>
                        {artist.name}
                      </label>
                    );
                  })}
                </div>
                <div className={classes.applyfilter__container}>
                  <button
                    className={classes.applyfilter__button}
                    onClick={handleApplyArtists}
                  >
                    Apply
                  </button>
                </div>
              </div>
            )}
          </>
        )}
      </div>
      <div className={classes.filter}>
        <div className={classes.filter__item_container}>
          <div
            className={classes.filter__item_artist}
            onClick={handleToggleFormats}
          >
            <div className={classes.filter__item_applied}>
              Format
              <KeyboardArrowDownIcon></KeyboardArrowDownIcon>
            </div>
          </div>
        </div>
        {toggleFormats && (
          <>
            <div className={classes.formats__container}>
              <div className={classes.artists}>
                {formats.map((format: any) => {
                  return (
                    <label className={classes.artist}>
                      <input
                        type="checkbox"
                        checked={hadnleIsFormatChecked(format.id)}
                        onChange={() => handleCheckFormat(format.id)}
                      ></input>
                      {format.name}
                    </label>
                  );
                })}
              </div>
              <div className={classes.applyfilter__container}>
                <button
                  className={classes.applyfilter__button}
                  onClick={handleApplyArtists}
                >
                  Apply
                </button>
              </div>
            </div>
          </>
        )}
      </div>
    </div>
  );
};

export default Filters;
