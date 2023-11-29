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
}

export const ShopContext = createContext<IShopContext | null>(null);

export const ShopContextProvider = (props: any) => {
  const authCtx = useContext(AuthContext);

  const [searchQuery, setSearchQuery] = useState<string>("");
  const [searchBefore, setSearchBefore] = useState<string>("");
  const [page, setPage] = useState(1);

  const handleSetSearchQuery = (query: string) => {
    setSearchQuery(query);
  };

  const handleGetSearchQuery = () => {
    return searchQuery;
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

  const contextValue: IShopContext = {
    handleSetSearchQuery,
    handleGetSearchQuery,
    handleSetPage,
    handleResetPage,
    handleGetPage,
  };

  return (
    <ShopContext.Provider value={contextValue}>
      {props.children}
    </ShopContext.Provider>
  );
};
