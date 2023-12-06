import { useQuery } from "@tanstack/react-query";
import axios from "axios";

export const useGetUserByIdQuery = (userId: string) =>
  useQuery({
    queryKey: ["user", userId],
    queryFn: () =>
      fetch(`http://localhost:5100/api/User/${userId}`).then((res) =>
        res.json()
      ),
  });
