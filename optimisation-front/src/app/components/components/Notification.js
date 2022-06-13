import {notification} from "antd";

const Notification = ({ key, msg, type}) => {
    return (
        <div>
            {notification[type]({
                key,
                description: msg,
            })}
        </div>
    );
};

export default Notification