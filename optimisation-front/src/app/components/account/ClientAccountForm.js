import React from 'react';
import Inputs from "../components/Inputs";

const ClientAccountForm = ({ onChange, onSubmit }) => {
    return(
        <form method="POST" className="flex flex-col gap-5">
            <div className="flex flex-row justify">
                <Inputs onChange={onChange} className="gap-8" type="radio" labelText="Civilité*" name="civ" config={[
                    { text: 'Mme', id: 'Mme', value: 'Mme' },
                    { text: 'Mr', id: 'Mr', value: 'M' },
                    { text: 'Autre', id: 'Other', value: 'Indéterminer' }
                ]} />
            </div>
            <div className="flex flex-row justify-between">
                <Inputs
                    type="text"
                    placeholder="Saisissez votre prénom"
                    labelText="Prénom*"
                    onChange={onChange}
                    name="firstname"
                    className="w-2/5"
                    id="firstname"
                />
                <Inputs
                    type="text"
                    placeholder="France"
                    labelText="Pays*"
                    onChange={onChange}
                    name="country"
                    className="w-2/5"
                    id="country"
                />
            </div>
            <div className="flex flex-row justify-between">
                <Inputs
                    type="text"
                    placeholder="Saisissez votre nom"
                    labelText="Nom*"
                    name="lastname"
                    onChange={onChange}
                    className="w-2/5"
                    id="lastname"
                />
                <Inputs
                    type="text"
                    placeholder="07 00 00 00 00"
                    labelText="Numéro de téléphone*"
                    onChange={onChange}
                    name="phone"
                    className="w-2/5"
                    id="phone"
                />
            </div>
            <div className="flex flex-row justify-between">
                <Inputs
                    type="email"
                    placeholder="nom@exemple.com"
                    labelText="Email*"
                    name="email"
                    onChange={onChange}
                    className="w-2/5"
                    id="email"
                />
                <Inputs
                    type="password"
                    placeholder="Minimum 8 caractères"
                    labelText="Mot de passe*"
                    name="password"
                    onChange={onChange}
                    className="w-2/5"
                    id="password"
                />
            </div>
            <Inputs
                type="checkbox"
                name="notRobot"
                onChange={onChange}
                config={[{ id: 'notRobot', name: 'notRobot', text: 'Je ne suis pas un robot', inverse: true }]}
            />
            <Inputs
              type="checkbox"
              name="cgvu"
              onChange={onChange}
              config={[{ id: 'cgvu', name: 'cgvu', text: 'J’ai lu et j’accepte les conditions générales de ventes et d’utilisation', inverse: true }]}
            />
            <button className="bg-darkTurquoise text-white uppercase w-2/5 p-4" onClick={onSubmit} type="submit">Créer mon compte</button>
        </form>
    )
}

ClientAccountForm.defaultProps = {
    onChange: () => {},
    onSubmit: () => {}
};

export default ClientAccountForm;