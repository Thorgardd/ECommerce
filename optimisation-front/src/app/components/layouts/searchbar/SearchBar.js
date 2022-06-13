import React, {useState, useContext, useEffect} from 'react'
import { useHistory } from 'react-router-dom'
import {URL_SEARCH_GET} from "../../../shared/constants/urls/urlBackEnd";
import axios from "axios";
import SearchContext from "../../../shared/contexts/searchContext";

const SearchBar = () => {

    const history = useHistory();
    const [style, setStyle] = useState(styles.default);
    const { search, setSearch } = useContext(SearchContext);

    useEffect(() => {
        for (const field in search.result) {
            if (search.result[field]) {
                if (search.result[field].length >= 1) {
                    history.push('/search');
                    break;
                }
            }
        }
    }, [search.result, history]);

    const requestOnChange = (event) => {
        setSearch((prevState) => ({
            ...prevState,
            search: event.target.value
        }));
    }

    const onClickSearch = () => {
        axios.get(URL_SEARCH_GET + "/" + search.search)
            .then(async res => {
                setSearch((prevState) => ({
                    ...prevState,
                    result: res.data
                }));
            })
            .catch(err => console.log(err))
    }

    const onKeyDown = (e) => {
        e.preventDefault()
        if (e.key === "Enter") {
            onClickSearch();
        }
    }

    const handleFocus = () => {
        setStyle({
            style: styles.active
        });
    };

    const handleBlur = () => {
        setStyle({
            style: styles.default
        });
    };

    return (
        <div className={`flex w-full border-b border-${style.colorClass} group hover:border-black-secondary transition-border`}>
            <button className="flex items-center justify-center px-3 md:px-4">
                <svg className="h-3.5 md:h-5 w-3.5 md:w-5" viewBox="0 0 20 20">
                    <path className={`fill-current text-${style.colorClass} group-hover:text-black-secondary transition-colors`} d="m19.53 18.469-4.694-4.694A8.208 8.208 0 0 0 16.75 8.5c0-4.549-3.7-8.25-8.25-8.25C3.951.25.25 3.951.25 8.5c0 4.549 3.701 8.25 8.25 8.25 2.005 0 3.844-.72 5.275-1.914l4.694 4.694a.748.748 0 0 0 1.06 0 .75.75 0 0 0 .001-1.061ZM1.75 8.5A6.758 6.758 0 0 1 8.5 1.75a6.758 6.758 0 0 1 6.75 6.75 6.758 6.758 0 0 1-6.75 6.75A6.758 6.758 0 0 1 1.75 8.5Z" />
                </svg>
            </button>
            <input
                type="text"
                className={`h-6 md:h-8 w-[82%] font-open-sans text-xs md:text-sm leading-3 md:leading-4 border-0 outline-none focus:ring-0`}
                onFocus={handleFocus}
                onBlur={handleBlur}
                placeholder={style.placeholderTxt}
                onChange={(e) => requestOnChange(e)}
                onKeyDown={() => onKeyDown()}
            />
            <button className="btn" onClick={() => onClickSearch()}>Rechercher</button>
        </div>
    );
}

export default SearchBar

const styles = {
    default: {
        placeholderTxt: 'Rechercher un outil',
        colorClass: 'gray-400'
    },
    active: {
        placeholderTxt: 'Recherche en cours...',
        colorClass: 'black-secondary'
    }
}