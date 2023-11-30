import React, { useContext, useEffect, useState } from "react";
import classes from "./styles/FiltersModal.module.css";
import { Link } from "react-router-dom";
import axios from "axios";
import { ShopContext } from "../../store/shop-store";
const FiltersModal = (props: any) => {
  const [toggleArtists, setToggleArtists] = useState(false);
  const [artists, setArtists] = useState<any[]>([]);
  const { handleSelectedArtist, isArtistChecked } = useContext(ShopContext);

  useEffect(() => {
    axios.post(`http://localhost:5100/api/Artist`).then((res) => {
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

  return (
    <div className={classes.sidemenu}>
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
        <div className={classes.sidemenu__item}>Label</div>
        <div></div>
      </div>
    </div>
  );
};

export default FiltersModal;
