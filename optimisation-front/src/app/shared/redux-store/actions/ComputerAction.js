export const GET_COMPUTER = "GET_COMPUTER";

export const getComputer = (data) => {
    return (dispatch) => {
        dispatch({
            type: GET_COMPUTER,
            price: data.price,
            isOnSale: data.isOnSale,
            reference: data.reference,
            os: data.os,
            cpu: data.cpu,
            powerSupply: data.powerSupply,
            sound: data.sound,
            graphProds: data.graphProds,
            hardDisks: data.hardDisks,
            memories: data.memories,
            connectors: data.connectors,
            brand: data.brand,
            images: data.images,
            colors: data.colors,
            ranks: data.ranks,
            mouse: data.mouse,
            screen: data.screen,
            category: data.category,
            criticalStock: data.criticalStock,
            tags: data.tags,
            stock: data.stock
        })
    }
}