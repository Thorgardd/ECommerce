import React, { useContext } from "react"
import SearchContext from "../shared/contexts/searchContext";
import Card from "../components/components/Card";

const SearchView = () => {

    const { search } = useContext(SearchContext)

    return(
        <div className="SearchView">
            {search.result?.gcard?.length >= 1 &&
                <div>
                    <p>Cartes Graphiques</p>
                    {search.result?.gcard?.map((card, index) => <Card name={card.type} key={`gcard-${card.type}`} price="Non déstiné à la vente"/>)}
                </div>
            }
            {search.result?.memory?.length >= 1 &&
                <div>
                    <p>Barettes Ram</p>
                    {search.result?.memory?.map((memory, index) => <Card name={memory.model} key={`memory-${memory.model}`} price="Non déstiné à la vente"/>)}
                </div>
            }
            {search.result?.mouse?.length >= 1 &&
                <div>
                    <p>Barettes Ram</p>
                    {search.result?.mouse?.map((mouse, index) => <Card name={mouse.reference} key={`memory-${mouse.reference}`} price={mouse.price}/>)}
                </div>
            }
            {search.result?.os?.length >= 1 &&
                <div>
                    <p>Systèmes d'Exploitation</p>
                    {search.result?.os?.map((os, index) => <Card name={os.version} key={`memory-${os.version}`} price={"Non déstiné à la vente"}/>)}
                </div>
            }
            {search.result?.power?.length >= 1 &&
                <div>
                    <p>Systèmes d'Exploitation</p>
                    {search.result?.power?.map((power, index) => <Card name={power.power} key={`memory-${power.power}`} price={"Non déstiné à la vente"}/>)}
                </div>
            }
        </div>
    )
}

export default SearchView