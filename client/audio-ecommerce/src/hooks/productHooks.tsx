import { useQuery } from "@tanstack/react-query";
import axios from "axios";

export const useGetProductsBySearchQuery = (
  page: number,
  searchQuery: string,
  isOrderAscending: boolean,
  artistId: number,
  pageSize: number
) =>
  useQuery({
    queryKey: ["products", page, searchQuery],
    queryFn: () =>
      axios
        .post(`http://localhost:5100/api/Product`, {
          searchQuery,
          page,
          isOrderAscending,
          artistId,
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
      fetch(`http://localhost:3001/api/Product/${productId}`).then((res) =>
        res.json()
      ),
  });
