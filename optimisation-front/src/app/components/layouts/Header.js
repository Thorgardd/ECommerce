import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import { Disclosure, Transition } from '@headlessui/react';
import { MenuIcon, XIcon } from '@heroicons/react/solid';
import { useKeycloak } from '@react-keycloak/web';

import Logo from '../../assets/images/logo/cerveau.svg';
import basketIcon from '../../assets/images/icons/shopping-basket.svg';
import userIcon from '../../assets/images/icons/user.svg';

import SearchBar from './searchbar/SearchBar';
import Navbar from './navbar/Navbar';
import IcoButton from './icon-button/IcoButton';

import {
    URL_HOME,
    URL_LOGIN,
    URL_USERPROFILE,
    URL_SETTINGS,
} from '../../shared/constants/urls/urlConstants';
import Cart from './navbar/Cart';


const Header = () => {
    return (
        <header className="top-0 fixed z-50 w-full bg-white md:shadow-md">
            <Disclosure as="div" className="h-16 md:h-[84px] border-b border-primary-light/[.5]">
                {({ open }) => (
                    <>
                        <div className="mx-auto lg:mx-20 px-8">
                            <div className="flex justify-between py-3 md:justify-start md:space-x-10">
                                <div className="-mr-2 flex md:hidden">
                                    {/* Mobile menu button */}
                                    <Disclosure.Button
                                        className="inline-flex items-center justify-center p-2 rounded-md text-black-secoary hover:text-white hover:bg-primary 
                                focus:outline-none transform active:scale-95 active:ring-2 active:ring-offset-2 active:ring-primary"
                                    >
                                        {open ? (
                                            <XIcon className="block h-6 w-6" aria-hidden="true" />
                                        ) : (
                                            <MenuIcon className="block h-6 w-6" aria-hidden="true" />
                                        )}
                                    </Disclosure.Button>
                                </div>

                                <div className="flex items-center justify-center ml-4 md:ml-0 md:justify-start flex-auto md:flex-none">
                                    <Link
                                        to={URL_HOME}
                                        className="flex flex-row md:mx-auto"
                                    >
                                        <img
                                            className="h-8 md:h-[60px] w-auto cursor-pointer"
                                            src={Logo}
                                            alt="Qual-it Logo"
                                        />
                                        <span className="mx-2 md:mx-3 font-dosis font-bold text-[22px] h-7 leading-7 md:text-[34px] md:h-[43px] md:leading-[43px] pt-px md:pt-2">
                                            QUAL-IT
                                        </span>
                                    </Link>
                                </div>

                                <div className="hidden md:flex items-center justify-center flex-auto">
                                    <div className="mx-auto w-[75%] xl:w-[500px]">
                                        <SearchBar />
                                    </div>
                                </div>

                                <div className="flex items-center justify-end">
                                    <MenuButtons />
                                </div>
                            </div>
                        </div>

                        <Transition
                            enter="transition"
                            enterFrom="transform opacity-0 scale-95"
                            enterTo="transform opacity-100 scale-100"
                            leave="transition"
                            leaveFrom="transform opacity-100 scale-100"
                            leaveTo="transform opacity-0 scale-95"
                        >
                            <Disclosure.Panel className="md:hidden p-5 pb-16 relative z-40 w-full bg-white">
                                <nav className="navbar-small">
                                    <Navbar />
                                </nav>
                            </Disclosure.Panel>
                        </Transition>
                    </>
                )}
            </Disclosure>

            <div className="hidden md:flex justify-center">
                <nav className="navbar">
                    <Navbar />
                </nav>
            </div>

            <div className="md:hidden justify-center my-2 mx-[10vw] flex flex-auto">
                <div className="w-full max-w-[420px]">
                    <SearchBar />
                </div>
            </div>
        </header>
    );
};

export default Header;

const MenuButtons = () => {
    const { keycloak } = useKeycloak();

    const [isOpen, setIsOpen] = useState(false);

    const openCart = () => {
        setIsOpen(!isOpen);
    }

    const closeIt = () => {
        setIsOpen(!isOpen)
    }

    const DropDownUserMenu = () => {
        return (
            <ul className="w-20 md:w-[101px] py-[3px] bg-white border border-primary/[.4] text-center text-black-primary font-open-sans text-[10px] md:text-xs leading-3 md:leading-4">
                <li className="mb-1">
                    <Link to={URL_USERPROFILE} className="block hover:text-primary-dark">
                        Mon profil
                    </Link>
                </li>
                <li className="my-1">
                    <Link to={URL_SETTINGS} className="block hover:text-primary-dark">
                        Paramètres
                    </Link>
                </li>
                <li className="my-1">
                    <Link to="/" className="block hover:text-primary-dark">
                        Achats
                    </Link>
                </li>
                <li className="my-1">
                    <Link to="/" className="block hover:text-primary-dark">
                        Aide
                    </Link>
                </li>
                <li className="mt-1">
                    <button
                        className="w-full hover:text-primary-dark"
                        type="button"
                        onClick={() => keycloak.logout()}
                    >
                        Déconnexion
                    </button>
                </li>
            </ul>
        );
    };

    return (
        <div className="flex flex-row space-x-3 md:space-x-6">
            <IcoButton isLink={false} imageSrc={basketIcon} imageAlt="Basket Icon" onClick={openCart} btnClasses="bg-primary-light hover:bg-primary-light/[.6]" />
            {!keycloak.authenticated ? (
                <IcoButton linkTo={URL_LOGIN} onClick={() => keycloak.login()} imageSrc={userIcon} imageAlt="User Icon" btnClasses="bg-primary-light hover:bg-primary-light/[.6]" />
            ) : (
                <Disclosure as="div" className="relative inline-flex justify-center">
                    {() => (
                        <>
                            {/* screen > 768px : menu déroulant au survol */}
                            <div className="hidden md:inline-flex p-0 h-10 w-10 rounded-xl bg-primary-light justify-center items-center peer">
                                <img className="h-5 w-5" src={userIcon} alt="User Icon" />
                            </div>

                            {/* screen < 768px ("version mobile") : menu déroulant au clic */}
                            <Disclosure.Button className="md:hidden btn p-0 h-8 w-8 rounded-lg bg-primary-light">
                                <img className="h-4 w-4" src={userIcon} alt="User Icon" />
                            </Disclosure.Button>

                            <div className="absolute top-8 md:top-10 h-5 md:h-6 min-w-[78px] md:min-w-[96px] max-w-[90px] md:max-w-[112px] leading-4 md:leading-6 font-dosis text-xs md:text-sm text-center text-primary-dark peer">
                                <span className="block truncate">
                                    {keycloak.tokenParsed.name}
                                </span>
                            </div>

                            <div className="absolute top-[62px] hidden hover:block peer-hover:md:block">
                                <DropDownUserMenu />
                            </div>

                            {/* Nb: laisser "md:hidden" dans le cas où le menu déroulant est ouvert puis l'écran élargi... */}
                            <Disclosure.Panel as="div" className="absolute z-50 top-12 md:hidden">
                                <DropDownUserMenu />
                            </Disclosure.Panel>
                        </>
                    )}
                </Disclosure>
            )}
            {isOpen === true ? <div className="absolute top-24 right-16 "> <Cart closeIt={closeIt} /> </div> : null}
        </div>
    );
};
