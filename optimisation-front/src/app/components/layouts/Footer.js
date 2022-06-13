import React from 'react';
import { Link } from 'react-router-dom';

import IcoButton from './icon-button/IcoButton';

import facebookIcon from '../../assets/images/icons/socials/vector-facebook.svg';
import linkedInIcon from '../../assets/images/icons/socials/vector-linkedin.svg';
import youtubeIcon from '../../assets/images/icons/socials/vector-youtube.svg';
import twitterIcon from '../../assets/images/icons/socials/vector-twitter.svg';

import visaIcon from '../../assets/images/icons/payment/visa-icon.svg';
import mastercardIcon from '../../assets/images/icons/payment/mastercard-icon.svg';
import cbIcon from '../../assets/images/icons/payment/cb-icon.svg';
import paypalIcon from '../../assets/images/icons/payment/paypal-icon.svg';


const Footer = () => {
    return (
        <footer className="w-full bg-white md:border-t border-primary/[.4] font-open-sans text-black-secondary py-2 text-[13px] leading-4">
            <div className="mx-5 md:mx-[5vw]">
                {/* Haut du footer */}
                <div className="flex flex-col lg:flex-row justify-between pt-9 pb-12 border-b border-primary/[.4]">
                    <div>
                        <div className="md:justify-center w-[400px]">
                            <h6 className="text-lg font-semibold uppercase mb-3">
                                Inscrivez-vous à notre Newsletter
                            </h6>
                            <p className="my-px text-black-primary sm:justify-start w-[95%]">
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit. A
                                proin nisi, neque nisl, in odio vestibulum mattis.
                            </p>
                            <p className="my-px sm:justify-start w-[95%]">
                                <Link className="underline" to="/">
                                    Informations sur le traitement des données à caractère
                                    personnel
                                </Link>
                            </p>
                            <div className="w-full mt-4">
                                <input
                                    type="text"
                                    className="h-10 w-[80%] border border-primary border-r-0 rounded-l-lg outline-none focus:ring-0 focus:border-primary px-5 text-[13px] leading-4"
                                />
                                <button type="button" className="h-10 w-[15%] bg-primary rounded-r-lg text-white hover:bg-primary/[.8] active:scale-95">OK</button>
                            </div>
                        </div>
                    </div>

                    <div>
                        <div className="w-[400px]">
                            <h6 className="text-lg font-semibold uppercase mb-6">
                                Toujours à votre écoute
                            </h6>
                            <p className="text-base">Conseil et commande :</p>
                            <div className="flex">
                                <div className="text-xl font-semibold text-primary-dark">
                                    <span>02 00 00 00 00</span>
                                </div>
                                <div className="mx-2 text-sm text-black-primary font-light">
                                    <span>(appel bien bien surtaxé)</span>
                                </div>
                            </div>
                            <p className="mt-2 text-sm text-black-primary">
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit.
                                Condimentum nibh pharetra id elementum orci convallis
                                massa, amet.
                            </p>
                        </div>
                    </div>

                    <div>
                        <div className="flex flex-col h-48 justify-between">
                            <div className="w-[220px] h-[72px]">
                                <h6 className="text-lg font-semibold uppercase mb-4">
                                    Rejoignez nos réseaux
                                </h6>
                                <div className="flex items-center space-x-5 sm:items-center space-x-12 md:items-center space-x-5">
                                    <IcoButton linkTo="/" imageSrc={facebookIcon} imageAlt="Facebook Icon" />
                                    <IcoButton linkTo="/" imageSrc={linkedInIcon} imageAlt="LinkedIn Icon" />
                                    <IcoButton linkTo="/" imageSrc={youtubeIcon} imageAlt="Youtube Icon" />
                                    <IcoButton linkTo="/" imageSrc={twitterIcon} imageAlt="Twitter Icon" />
                                </div>
                            </div>
                            <div className="w-[220px] h-[72px]">
                                <h6 className="text-lg font-semibold uppercase mb-5">
                                    Moyens de paiement
                                </h6>
                                <div className="flex 
                                items-center space-x-1.5 lg:items-center space-x-12 2xl:items-center space-x-1.5">
                                    <img className="" src={visaIcon} alt="Visa Icon" />
                                    <img
                                        className=""
                                        src={mastercardIcon}
                                        alt="Mastercard Icon"
                                    />
                                    <img className="" src={cbIcon} alt="CB Icon" />
                                    <img
                                        className=""
                                        src={paypalIcon}
                                        alt="Paypal Icon"
                                    />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                {/* Milieu du footer */}
                <div className="flex flex-col lg:flex-row justify-between pt-9 pb-12 border-b border-primary/[.4]">
                    <div>
                        <h6 className="text-lg font-semibold uppercase mb-6">À propos</h6>
                        <div className="text-sm leading-6">
                            <p><Link to="/">Responsabilité sociale</Link></p>
                            <p><Link to="/">Emploi</Link></p>
                            <p><Link to="/">Recyclage</Link></p>
                            <p><Link to="/">Qual-it et l'environnement</Link></p>
                            <p><Link to="/">L'espace fidélité</Link></p>
                            <p><Link to="/">Clients professionnels</Link></p>
                        </div>            
                    </div>
                    <div>
                        <h6 className="text-lg font-semibold uppercase mb-6">Services</h6>
                        <div className="text-sm leading-6">
                            <p><Link to="/">Retours</Link></p>
                            <p><Link to="/">Contact</Link></p>
                            <p><Link to="/">Questions fréquentes</Link></p>
                            <p><Link to="/">Nos conditions de livraison</Link></p>
                            <p><Link to="/">Suivre une livraison</Link></p>
                            <p><Link to="/">L'espace fidélité</Link></p>
                        </div>   
                    </div>
                    <div>
                        <h6 className="text-lg font-semibold uppercase mb-6">Nos offres</h6>
                        <div className="text-sm leading-6">
                            <p><Link to="/">Remises</Link></p>
                            <p><Link to="/">Nouveaux PC</Link></p>
                            <p><Link to="/">Promotions</Link></p>
                            <p><Link to="/">Coupons</Link></p>
                            <p><Link to="/">Inscription à la Newsletter</Link></p>
                            <p><Link to="/">Black Friday 2022</Link></p>
                        </div> 
                    </div>
                    <div >
                        <h6 className="text-lg font-semibold uppercase mb-6">Nos partenaires</h6>
                        <div className="text-sm leading-6">
                            <p><Link to="/">Affiliés</Link></p>
                            <p><Link to="/">Trouver un partenaire</Link></p>
                            <p><Link to="/">Trouver un revendeur</Link></p>
                            <p><Link to="/">Solution OEM</Link></p>
                            <p><Link to="/">Programme de partenariat</Link></p>
                            
                        </div> 
                    </div>
                </div>

                {/* Bas du footer */}
                <div>
                    <div className="flex justify-center my-4 text-sm leading-6">
                        <Link to="/">Politique de confidentialité</Link>
                        <div className="border-l border-deep-blue mx-6"></div>
                        <Link to="/">Conditions générales de vente et d’utilisation</Link>
                        <div className="border-l border-deep-blue mx-6"></div>
                        <Link to="/">Mentions légales</Link>
                    </div>
                </div>
                <div className="mt-20 text-center">
                    <span>© 2022 Qual-it</span>
                    <span>&nbsp; Tous droits reservés</span>
                </div>
            </div>
        </footer>
    );
};

export default Footer;
