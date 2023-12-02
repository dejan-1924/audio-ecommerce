import React, { useContext, useEffect, useState } from "react";
import classes from "./styles/FiltersModal.module.css";
import { Link } from "react-router-dom";
import axios from "axios";
import { ShopContext } from "../../store/shop-store";
const formats = [
  { id: 1, name: "Vinyl" },
  { id: 2, name: "CD" },
];
const FiltersModal = (props: any) => {
  const [toggleArtists, setToggleArtists] = useState(false);
  const [toggleFormats, setToggleFormats] = useState(false);
  const [toggleLabels, setToggleLabels] = useState(false);
  const [artists, setArtists] = useState<any[]>([]);
  const {
    handleSelectedArtist,
    isArtistChecked,
    handleSetSelectedFormats,
    isFormatChecked,
    setFilters,
  } = useContext(ShopContext);

  const [labels, setLabels] = useState<any[]>([]);
  useEffect(() => {
    axios.get(`http://localhost:5100/api/Artist`).then((res) => {
      console.log(res.data);
      setArtists(res.data);
    });
  }, []);

  const handleCheckArtist = (id: number) => {
    handleSelectedArtist(id);
  };

  const isChecked = (id: number) => {
    return isArtistChecked(id);
  };

  const handleCheckFormat = (id: number) => {
    handleSetSelectedFormats(id);
  };
  const hadnleIsFormatChecked = (id: number) => {
    return isFormatChecked(id);
  };

  const handleApplyFilters = () => {
    setFilters();
    props.closeModal();
  };

  return (
    <div className={classes.sidemenu}>
      <div>
        <div className={classes.sidemenu__header}>
          <button
            className={classes.sidemenu__closebutton}
            onClick={props.closeModal}
          >
            X
          </button>
        </div>
        <div className={classes.sidemenu__body}>
          <div className={classes.sidemenu__item}>
            <div onClick={() => setToggleArtists(!toggleArtists)}>Artist</div>

            {toggleArtists && (
              <>
                {artists && (
                  <div className={classes.artists}>
                    {artists.map((artist) => {
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
                )}
              </>
            )}
          </div>
          <div className={classes.sidemenu__item}>
            <div
              onClick={() => {
                setToggleFormats(!toggleFormats);
              }}
            >
              Product types
            </div>

            {toggleFormats && (
              <>
                {formats && (
                  <div className={classes.artists}>
                    {formats.map((format) => {
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
                )}
              </>
            )}
          </div>
          <div className={classes.sidemenu__item}>
            <div onClick={() => setToggleLabels(!toggleLabels)}>Label</div>

            {toggleLabels && (
              <>
                {artists && (
                  <div className={classes.artists}>
                    {artists.map((artist) => {
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
                )}
              </>
            )}
          </div>
        </div>
      </div>
      <div className={classes.applyfilter_button_container}>
        <button
          onClick={handleApplyFilters}
          className={classes.applyfilter_button}
        >
          Apply Filters
        </button>
      </div>
    </div>
  );
};

export default FiltersModal;
