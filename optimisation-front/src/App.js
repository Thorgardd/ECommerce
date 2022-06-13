import React, { useState } from 'react';
import { Provider } from 'react-redux'
import { ReactKeycloakProvider } from "@react-keycloak/web";
import Routes from "./app/routes/Routes";
import keycloak from "./Keycloak";
import store from "./app/shared/redux-store/store";
import {ToastContainer} from "react-toastify";

import SearchContext from './app/shared/contexts/searchContext';

import 'antd/dist/antd.css';
import './App.css';
import './app/assets/styles/fonts/fonts.css';

/*const keycloak = window.Keycloak;*/

const App = () => {
    const [search, setSearch] = useState({ search: '', result: {} });
    return (
        <Provider store={store}>
            <ReactKeycloakProvider authClient={keycloak}>
                <SearchContext.Provider value={{ search, setSearch }}>
                    <Routes />
                    <ToastContainer position="top-center"
                                    autoClose={5000}
                                    hideProgressBar={false}
                                    newestOnTop={false}
                                    closeOnClick
                                    rtl={false}
                                    pauseOnFocusLoss
                                    draggable={false}
                                    pauseOnHover/>
                </SearchContext.Provider>
            </ReactKeycloakProvider>
        </Provider>
    );
};

export default App;
