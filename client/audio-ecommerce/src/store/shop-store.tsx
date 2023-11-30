import {
  ReactNode,
  createContext,
  useEffect,
  useState,
  useContext,
} from "react";
import { AuthContext } from "./auth-store";
import { useNavigate } from "react-router";

export interface IShopContext {
  handleSetSearchQuery: (query: string) => void;
  handleGetSearchQuery: () => string;
  handleResetPage: () => void;
  handleGetPage: () => number;
  handleSetPage: (page: number) => void;
  handleSelectedArtist: (id: number) => void;
  handleGetSelectedArtists: () => number;
  isArtistChecked: (id: number) => boolean;
  handleGetOrdering: () => string;
  handleSetOrdering: (ordering: string) => void;
}

export const ShopContext = createContext<IShopContext | null>(null);

export const ShopContextProvider = (props: any) => {
  const authCtx = useContext(AuthContext);

  const [searchQuery, setSearchQuery] = useState<string>("");
  const [page, setPage] = useState(1);
  const [selectedArtists, setSelectedArtists] = useState<number[]>([]);

  const [ordering, setOrdering] = useState<string>("REL");

  const handleSelectedArtist = (id: number) => {
    let artists = [];
    if (selectedArtists.length < 1) {
      artists.push(id);
      setSelectedArtists(artists);
    }
    let isArtistsSelected =
      selectedArtists.filter((artistId) => artistId == id).length == 0;

    if (isArtistsSelected) {
      artists = [...selectedArtists];
      artists.push(id);
      setSelectedArtists(artists);
    } else {
      artists = selectedArtists.filter((artistId) => artistId !== id);
      setSelectedArtists(artists);
    }
  };

  const handleSetSearchQuery = (query: string) => {
    setSearchQuery(query);
  };

  const handleGetSearchQuery = () => {
    return searchQuery;
  };

  const handleGetOrdering = () => {
    return ordering;
  };

  const handleSetOrdering = (ordering: string) => {
    setOrdering(ordering);
  };

  const handleResetPage = () => {
    setPage(1);
  };
  const handleGetPage = () => {
    return page;
  };

  const handleSetPage = (page: number) => {
    setPage(page);
  };

  const handleGetSelectedArtists = () => {
    return selectedArtists;
  };

  const isArtistChecked = (id: number) => {
    return selectedArtists.filter((artistId) => artistId == id).length !== 0;
  };

  const contextValue: IShopContext = {
    handleSetSearchQuery,
    handleGetSearchQuery,
    handleSetPage,
    handleResetPage,
    handleGetPage,
    handleSelectedArtist,
    handleGetSelectedArtists,
    isArtistChecked,
    handleSetOrdering,
    handleGetOrdering,
  };

  return (
    <ShopContext.Provider value={contextValue}>
      {props.children}
    </ShopContext.Provider>
  );
};
