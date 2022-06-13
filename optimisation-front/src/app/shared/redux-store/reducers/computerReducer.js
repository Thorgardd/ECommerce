const initialState = {
    price: undefined,
    isOnSale: undefined,
    reference: undefined,
    os: undefined,
    cpu: undefined,
    powerSupply: undefined,
    sound: undefined,
    graphProds: [],
    hardDisks: [],
    memories: [],
    connectors: [],
    brand: undefined,
    images: [],
    colors: [],
    ranks: [],
    mouse: undefined,
    screen: undefined,
    category: undefined,
    criticalStock: undefined,
    tags: [],
    stock: undefined
}

const computer = (state = initialState, action) => {
    switch (action.type) {
        case "GET_COMPUTER":
            return {
                ...state,
                price: action.price,
                isOnSale: action.isOnSale,
                reference: action.reference,
                os: action.os,
                cpu: action.cpu,
                powerSupply: action.powerSupply,
                sound: action.sound,
                graphProds: action.graphProds,
                hardDisks: action.hardDisks,
                memories: action.memories,
                connectors: action.connectors,
                brand: action.brand,
                images: action.images,
                colors: action.colors,
                ranks: action.ranks,
                mouse: action.mouse,
                screen: action.screen,
                category: action.category,
                criticalStock: action.criticalStock,
                tags: action.tags,
                stock: action.stock
            }
        default:
            return {...initialState}
    }
}

export default computer;