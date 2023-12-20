import { useMutation, useQuery } from "@tanstack/react-query";
import axios from "axios";

export const useGetUserByIdQuery = (userId: string) =>
  useQuery({
    queryKey: ["user", userId],
    queryFn: () =>
      fetch(`http://localhost:5100/api/User/${userId}`).then((res) =>
        res.json()
      ),
  });

export const signUpUserFn = async (email: string, password: string) => {
  const response = await axios.post("http://localhost:5100/api/User/login", {
    email: email,
    password: password,
  });
  return { data: response.data };
};

export const useLogin = async (email: any, password: any) =>
  useMutation({
    mutationFn: (newTodo) => {
      return axios.post("http://localhost:5100/api/User/login", {
        email: email,
        password: password,
      });
    },
  });
