import { useQuery } from "@tanstack/react-query";
import axios from "axios";

export const useGetProductsBySearchQuery = (
  page: number,
  searchQuery: string,
  ordering: string,
  artistIds: number,
  pageSize: number
) =>
  useQuery({
    queryKey: ["products", page, searchQuery, artistIds, ordering],
    queryFn: () =>
      axios
        .post(`http://localhost:5100/api/Product`, {
          searchQuery,
          page,
          ordering,
          artistIds,
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
