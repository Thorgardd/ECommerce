import { getPayloadToken, getToken } from './tokenServices';

export function accountRoles() {
    const payload = getPayloadToken();
    return payload.auth.split(',');
}

export function accountLogin() {
    const payload = getPayloadToken();
    return payload.sub;
}

export function hasRole(role) {
    return accountRoles().includes(role);
}

export function isAuthenticated() {
    try {
        const token = getToken();
        //  console.log('token', token);
        const payload = getPayloadToken();
        // console.log('payload', payload);
        const roles = payload.auth.split(',');
        // console.log('roles', roles);
        const expirationDate = payload.exp;
        // console.log('expiration', expirationDate);
        const login = payload.sub;
        //console.log('login', login);
        const dateNow = new Date();
        return token && roles.length > 0 && login && expirationDate < dateNow.getTime();
    } catch {
        //  console.log('CATCH FALSE');
        return false;
    }
}
