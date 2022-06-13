import React, {useState} from "react";

import Box from "@mui/material/Box";
import Rating from "@mui/material/Rating";
import Typography from "@mui/material/Typography";

function RankBar()  {
    const [value, setValue] = useState(0);

    return (
        <Box
            sx={{'& > legend' : {mt: 2},}}
        >
            <Typography component="legend"></Typography>
            <Rating name="half-rating" precision={0.5} value={value} readOnly />
        </Box>
    )
}

export default RankBar;