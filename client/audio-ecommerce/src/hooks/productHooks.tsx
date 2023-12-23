import { useMutation, useQuery } from "@tanstack/react-query";
import axios from "axios";

export const useGetProductsBySearchQuery = (
  page: number,
  searchQuery: string,
  ordering: string,
  filters: Array<any>,
  pageSize: number
) =>
  useQuery({
    queryKey: ["products", page, searchQuery, filters, ordering],
    queryFn: () =>
      axios
        .post(`http://localhost:5100/api/Product`, {
          searchQuery,
          page,
          ordering,
          artistIds: filters.artistIds,
          formatIds: filters.formatIds,
          labelIds: filters.labelIds,
          pageSize,
        })
        .then((res) => {
          console.log(res);
          return res.data;
        }),
  });
export const useGetProductByIdQuery = (productId: string) =>
  useQuery({
    queryKey: ["products", productId],
    queryFn: () =>
      fetch(`http://localhost:5100/api/Product/${productId}`).then((res) =>
        res.json()
      ),
  });

export const handleChangeItemAmountInCart = async (item: any) => {
  const addToCartItem = { id: item.id, amount: item.amount, isReplace: true };

  const { data: response } = await axios.post(
    "https://localhost:7049/api/Cart/addItem",
    addToCartItem,
    {
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + localStorage.getItem("token"),
      },
    }
  );
  return response;
};

export const handleAddItemToCart = async (productId: number) => {
  const { data: response } = await axios.post(
    "https://localhost:7049/api/Cart/addItem",
    { id: productId, amount: 1, isReplace: false },
    {
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + localStorage.getItem("token"),
      },
    }
  );

  return response;
};

export const handleRemoveFromCart = async (itemId: number) => {
  const { data: response } = await axios.delete(
    "https://localhost:7049/api/Cart/deleteItem/" + itemId,
    {
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + localStorage.getItem("token"),
      },
    }
  );
  return response;
};

export const fetchCart = async () => {
  const { data: response } = await axios.get(
    "https://localhost:7049/api/Cart",
    {
      headers: {
        "Content-Type": "application/json",
        Authorization: "Bearer " + localStorage.getItem("token"),
      },
    }
  );

  return response;
};
