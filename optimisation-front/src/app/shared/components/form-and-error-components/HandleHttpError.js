import React from 'react';
import { toast } from 'react-toastify';

const errorToastMessage = (error) => (
    <div className="text-center">
        <strong>
            {error.response.data.message == null ? (
                <>
                    Erreur dans : {error.response.request.responseURL}
                    <br />
                    {error.response.status} : {error.response.statusText})
                </>
            ) : (
                <>{error.response.data.message}</>
            )}
        </strong>
    </div>
);

const handleHttpError = (error) => {
    console.log(error);
    if (!error.response) return;
    else toast.error(errorToastMessage(error));
};

export default handleHttpError;
