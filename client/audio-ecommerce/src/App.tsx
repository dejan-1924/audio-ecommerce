import "./App.css";
import {
  Navigate,
  Route,
  RouterProvider,
  createBrowserRouter,
  createRoutesFromElements,
} from "react-router-dom";
import { QueryClient, QueryClientProvider } from "@tanstack/react-query";
import RootLayout from "./components/Layout/RootLayout";
import ErrorPage from "./pages/Error/ErrorPage";
import LandingPage from "./pages/Landing/LandingPage";
import LoginPage from "./pages/Auth/LoginPage";
import ProductsPage from "./pages/Products/ProductsPage";
import WishlistPage from "./pages/Wishlist/WishlistPage";
import CartPage from "./pages/Cart/CartPage";
import AuthPage from "./pages/Auth/AuthPage";
import ProfilePage from "./pages/Profile/ProfilePage";
import AuthRoute from "./components/Auth/AuthRoute";
import ProductPage from "./pages/Products/ProductPage";
import store from "./store";
import { Provider } from "react-redux";
import MyOrdersPage from "./pages/Profile/Orders/MyOrdersPage";
import ProfileInfoPage from "./pages/Profile/Information/ProfileInfoPage";

const queryClient = new QueryClient({});

const router = createBrowserRouter(
  createRoutesFromElements(
    <Route
      path="/"
      element={<RootLayout></RootLayout>}
      errorElement={<ErrorPage></ErrorPage>}
    >
      <Route index element={<LandingPage></LandingPage>} />
      <Route path="/login" element={<AuthPage></AuthPage>} />
      <Route path="/shop" element={<ProductsPage></ProductsPage>} />
      <Route path="/shop/item/:id" element={<ProductPage></ProductPage>} />
      <Route path="/cart" element={<CartPage></CartPage>} />
      <Route element={<AuthRoute></AuthRoute>}>
        <Route path="/profile" element={<ProfilePage></ProfilePage>} />
        <Route path="/profile/orders" element={<MyOrdersPage></MyOrdersPage>} />
        <Route
          path="/profile/information"
          element={<ProfileInfoPage></ProfileInfoPage>}
        />
        <Route path="/wishlist" element={<WishlistPage></WishlistPage>} />
      </Route>
      <Route path="*" element={<Navigate to="/" replace />} />
    </Route>
  )
);

function App() {
  return (
    <Provider store={store}>
      <QueryClientProvider client={queryClient}>
        <RouterProvider router={router} />
      </QueryClientProvider>
    </Provider>
  );
}

export default App;
