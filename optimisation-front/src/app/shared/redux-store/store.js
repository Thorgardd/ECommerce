import { createStore, combineReducers, compose, applyMiddleware } from "redux";
import thunk from 'redux-thunk';

import computerReducer from "./reducers/computerReducer";

const composeEnhancer = compose

export default createStore(
    combineReducers({
        computer: computerReducer,
    }), composeEnhancer(applyMiddleware(thunk)))
