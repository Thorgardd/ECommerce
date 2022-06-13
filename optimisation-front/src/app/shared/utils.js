// Methode pour faire un delay
export const delay = (callback, ms) => {
    let timer = 0;
    return function() {
        let context = this, args = arguments;
        clearTimeout(timer);
        timer = setTimeout(function() {
            callback.apply(context, args);
        }, ms || 0);
    };
};


// Methode pour switcher les titres des
// souris en fonction du fil / sans fil
export const TitleSwitch = (boolValue) => {
    if (boolValue) return "Souris Sans Fil";
    else return "Souris Filaire";
};


// Methode pour switcher les images des
// souris en fonction du fil / sans fil
export const ImageSwitch = (boolValue, wirelessPath, linkPath) => {
    if (boolValue) return wirelessPath;
    else return linkPath;
};


// Methode pour calculer la réduction
// d'un produit
export const SaleRateCalc = (originalPrice, rate) => {
    return Math.round((originalPrice * rate) * 100) / 100;
}


// Methode pour calculer la valeur initiale
// d'un produit après réduction
export const PriceBeforeSale = (soldedPrice, rate) => {
    return Math.round(soldedPrice / rate);
}