// Methode pour ajouter au panier
//
export const AddToCart = (product, state = null, setState = null) => {
    if (
        localStorage.getItem("cart") === undefined ||
        localStorage.getItem("cart") === null
    ) {
        localStorage.setItem("cart", JSON.stringify([product]))
        return false;
    }

    if (state !== null && setState !== null) {
        setState(prevState => prevState?.push(product));
        localStorage.setItem('cart', JSON.stringify(state));
        return true;
    } else {
        let storage = JSON.parse(localStorage.getItem("cart"));
        storage.push(product);
        localStorage.setItem("cart", JSON.stringify(storage));
        return true;
    }
}