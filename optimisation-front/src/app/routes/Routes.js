import React from 'react';
import {BrowserRouter, Route} from 'react-router-dom';
import Header from "../components/layouts/Header";
import {URL_ADD_PRODUCT, URL_MANAGE_CART} from "../shared/constants/urls/urlConstants";
import ProductAddition from "../components/products/ProductAddition";
import CatalogView from "../views/CatalogView";
import ServiceBar from "../components/layouts/servicebar/ServiceBar";
import Footer from "../components/layouts/Footer";
import HomeView from "../views/HomeView";
import SearchView from "../views/SearchView";
import CartView from "../views/CartView";
import DetailView from "../views/DetailView";

const Routes = () => {
    return (
        <BrowserRouter>
            <div className="mb-auto flex flex-col bg-white cursor-default">
                <Header />
                <main className="mt-[105px] mb-auto md:mt-[130px]">
                    <Route exact path="/"
                           component={HomeView}/>
                    <Route path="/details/:reference"
                           component={DetailView}/>
                    <Route path="/search"
                           component={SearchView}/>
                    <Route path="/catalog" component={CatalogView} />
                    <Route path="/gaming" component={CatalogView} />
                    <Route path="/device" component={CatalogView} />
                    <Route path={URL_ADD_PRODUCT} component={ProductAddition} />
                    <Route path={URL_MANAGE_CART} component={CartView}/>
                    {/* <Route exact path="/" component={HomeView} />
                    <Route
                        path="/secured"
                        component={
                            <PrivateRoute>
                                <AdminHomeView />
                            </PrivateRoute>}
                    />
                    <Route path={URL_LOGIN} component={LoginView} /> */}
                </main>
                <ServiceBar />
                <Footer />
            </div>
        </BrowserRouter>
    );
};

export default Routes;
