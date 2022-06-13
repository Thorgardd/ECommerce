const options = { year: 'numeric', month: 'numeric', day: 'numeric' };

export const dateFormat = (date) => {
    return new Date(date).toLocaleDateString('fr-FR', options) // Possibilité de changer le pays pour adapter le format
}

export const getDateNowForBdd = () => {
    let d = new Date(),
        month = '' + (d.getMonth() + 1),
        day = '' + d.getDate(),
        year = d.getFullYear();

    if (month.length < 2)
        month = '0' + month;
    if (day.length < 2)
        day = '0' + day;

    return [year, month, day].join('-');
}