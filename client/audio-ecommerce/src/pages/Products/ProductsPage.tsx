import React, { useContext, useState } from "react";
import { useGetProductsBySearchQuery } from "../../hooks/productHooks";
import { Pagination } from "@mui/material";
import classes from "./styles/ProductsPage.module.css";
import Product from "../../components/Product/Product";
import { ShopContext } from "../../store/shop-store";
import TuneIcon from "@mui/icons-material/Tune";
import ImportExportIcon from "@mui/icons-material/ImportExport";
import FiltersModal from "../../components/Filters/FiltersModal";
import Backdrop from "../../components/SideMenu/Backdrop";

const ordering_options = [
  { label: "Relevance", value: "REL" },
  { label: "Price, low to high", value: "PRICE_ASC" },
  { label: "Price, high to low", value: "PRICE_DESC" },
  { label: "Alphabetically", value: "AZ" },
];

const ProductsPage = () => {
  const {
    handleGetPage,
    handleSetPage,
    handleGetSearchQuery,
    handleGetSelectedArtists,
    handleGetOrdering,
    handleSetOrdering,
  } = useContext(ShopContext);
  const {
    data: products,
    isLoading,
    error,
  } = useGetProductsBySearchQuery(
    handleGetPage(),
    handleGetSearchQuery(),
    handleGetOrdering(),
    handleGetSelectedArtists(),
    10
  );
  const [toggleFilters, setToggleFilters] = useState(false);
  const [toggleOrdering, setToggleOrdering] = useState(false);
  const handleOpenFilterModal = () => {
    setToggleFilters(true);
  };

  const closeFilterModal = () => {
    setToggleFilters(false);
  };

  const handleToggleOrdering = () => {
    setToggleOrdering(!toggleOrdering);
  };

  return (
    <div className={classes.page__container}>
      {toggleFilters && (
        <FiltersModal closeModal={closeFilterModal}></FiltersModal>
      )}
      {toggleFilters && <Backdrop closeSideMenu={closeFilterModal}></Backdrop>}
      {!isLoading ? (
        <>
          <div className={classes.productlist__container}>
            {handleGetSearchQuery() !== "" && (
              <div className={classes.searchinfo}>
                <span
                  className={classes.searchinfo__query}
                >{`Search "${handleGetSearchQuery()}"`}</span>
                <span
                  className={classes.searchinfo__productnumber}
                >{` ${products?.totalCount} Items`}</span>
              </div>
            )}
            <div>
              <div></div>
              <div className={classes.filters__container}>
                <div className={classes.orderbuttons_container}>
                  <button
                    className={classes.orderbutton}
                    onClick={handleToggleOrdering}
                  >
                    <ImportExportIcon></ImportExportIcon>
                  </button>
                  {toggleOrdering && (
                    <div className={classes.ordering}>
                      <ul>
                        {ordering_options.map((option) => {
                          return (
                            <li
                              onClick={() => handleSetOrdering(option.value)}
                              className={
                                option.value === handleGetOrdering()
                                  ? classes.ordering__selected
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
                <button
                  className={classes.filterbutton}
                  onClick={handleOpenFilterModal}
                >
                  <TuneIcon></TuneIcon>
                </button>
              </div>
            </div>
            {products?.entities?.length > 0 ? (
              <>
                <div className={classes.productlist}>
                  {products?.entities?.map((product: any) => {
                    return (
                      <Product
                        name={product.name}
                        imageUrl={product.imageUrl}
                        artist={product.artistName}
                        id={product.id}
                        price={product.price}
                      ></Product>
                    );
                  })}
                </div>
                {Math.ceil(products?.totalCount / 6) > 1 && (
                  <div className={classes.pagination}>
                    <Pagination
                      count={Math.ceil(products?.totalCount / 6)}
                      variant="outlined"
                      shape="rounded"
                      page={handleGetPage()}
                      onChange={(e, value) => handleSetPage(value)}
                    />
                  </div>
                )}
              </>
            ) : (
              <div className={classes.noitems__container}>
                <h3>No items have been found.</h3>
              </div>
            )}
          </div>
        </>
      ) : (
        <div>Loading...</div>
      )}
    </div>
  );
};

export default ProductsPage;
