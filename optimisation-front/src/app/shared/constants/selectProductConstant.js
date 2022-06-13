import ComputerForm from "../../components/products/productForms/ComputerForm";
import ScreenForm from "../../components/products/productForms/ScreenForm";
import SoundForm from "../../components/products/productForms/SoundForm";
import OsForm from "../../components/products/productForms/OsForm";
import CpuForm from "../../components/products/productForms/CpuForm";
import GCardForm from "../../components/products/productForms/GCardForm";
import RamForm from "../../components/products/productForms/RamForm";
import HDiskForm from "../../components/products/productForms/HDiskForm";
import MouseForm from "../../components/products/productForms/MouseForm";
import PowerForm from "../../components/products/productForms/PowerForm";
import ConnectForm from "../../components/products/productForms/ConnectForm";

const options = [
    {
        label: "Ordinateur",
        value: "COMPUTER_CREATE"
    },
    {
        label: "Ecran",
        value: "SCREEN_CREATE"
    },
    {
        label: "Enceintes",
        value: "SOUND_CREATE"
    },
    {
        label: "Système d'Exploitation",
        value: "OS_CREATE"
    },
    {
        label: "Processeur",
        value: "CPU_CREATE"
    },
    {
        label: "Carte Graphique",
        value: "GCARD_CREATE"
    },
    {
        label: "Barrette RAM",
        value: "RAM_CREATE"
    },
    {
        label: "Disque Dur",
        value: "HDISK_CREATE"
    },
    {
        label: "Souris",
        value: "MOUSE_CREATE"
    },
    {
        label: "Alimentation",
        value: "POWER_CREATE"
    },
    {
        label: "Connectique",
        value: "CONNECT_CREATE"
    }
]

export const SelectVar = (value, onChange) => {
    switch (value) {
        case "COMPUTER_CREATE" :
            return ComputerForm(onChange);
        case "SCREEN_CREATE" :
            return ScreenForm
        case "SOUND_CREATE" :
            return SoundForm
        case "OS_CREATE" :
            return OsForm
        case "CPU_CREATE" :
            return CpuForm
        case "GCARD_CREATE" :
            return GCardForm
        case "RAM_CREATE" :
            return RamForm
        case "HDISK_CREATE" :
            return HDiskForm
        case "MOUSE_CREATE" :
            return MouseForm
        case "POWER_CREATE" :
            return PowerForm
        case "CONNECT_CREATE" :
            return ConnectForm
        default : return
    }
}

export const Options = options;


