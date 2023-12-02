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
  handleGetSelectedArtists: () => Array<number>;
  handleSetSelectedFormats: (id: number) => void;
  handleGetSelectedFormats: () => Array<number>;
  isFormatChecked: (id: number) => boolean;
  isArtistChecked: (id: number) => boolean;
  handleGetOrdering: () => string;
  handleSetOrdering: (ordering: string) => void;
  resetFormats: () => void;
  resetArtists: () => void;
  resetFilters: () => void;
  setFilters: () => void;
  getFilters: () => Array<any>;
}

export const ShopContext = createContext<IShopContext | null>(null);

export const ShopContextProvider = (props: any) => {
  const authCtx = useContext(AuthContext);

  const [searchQuery, setSearchQuery] = useState<string>("");
  const [page, setPage] = useState(1);
  const [selectedArtists, setSelectedArtists] = useState<number[]>([]);
  const [selectedFormats, setSelectedFormats] = useState<number[]>([]);
  const [selectedFilters, setSelectedFilters] = useState<{}>({
    artistIds: [],
    formatIds: [],
  });

  const [ordering, setOrdering] = useState<any>({
    value: "REL",
    label: "Relevance",
  });

  const handleSelectedArtist = (id: number) => {
    let artists = [];
    handleResetPage();
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

  const handleGetSelectedFormats = () => {
    return selectedFormats;
  };
  const handleSetSelectedFormats = (id: number) => {
    let formats = [];
    handleResetPage();
    if (selectedFormats.length < 1) {
      formats.push(id);
      setSelectedFormats(formats);
    }
    let isFormatSelected =
      selectedFormats.filter((formatId) => formatId == id).length == 0;

    if (isFormatSelected) {
      formats = [...selectedFormats];
      formats.push(id);
      setSelectedFormats(formats);
    } else {
      formats = selectedFormats.filter((formatId) => formatId !== id);
      setSelectedFormats(formats);
    }
  };

  const isFormatChecked = (id: number) => {
    return selectedFormats.filter((formatId) => formatId == id).length !== 0;
  };

  const resetArtists = () => {
    setSelectedArtists([]);
  };
  const resetFormats = () => {
    setSelectedFormats([]);
  };

  const resetFilters = () => {
    setSelectedFormats([]);
    setSelectedArtists([]);
    setSearchQuery("");
    handleResetPage();
  };

  const setFilters = () => {
    setSelectedFilters({
      artistIds: handleGetSelectedArtists(),
      formatIds: handleGetSelectedFormats(),
    });
  };

  const getFilters = () => {
    return selectedFilters;
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
    handleSetSelectedFormats,
    handleGetSelectedFormats,
    isFormatChecked,
    resetArtists,
    resetFormats,
    resetFilters,
    setFilters,
    getFilters,
  };

  return (
    <ShopContext.Provider value={contextValue}>
      {props.children}
    </ShopContext.Provider>
  );
};