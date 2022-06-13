import jwt_decode from 'jwt-decode';

const TOKEN_NAME = 'token';

export function setToken(token) {
    localStorage.setItem(TOKEN_NAME, token);
}

export function getToken() {
    return localStorage.getItem(TOKEN_NAME);
}

export function removeToken() {
    localStorage.removeItem(TOKEN_NAME);
}

export function getPayloadToken() {
    return decodeToken();
}

function decodeToken() {
    const token = getToken();
    return jwt_decode(token);
}
