import React from "react";

function OfficeItem({item}){
    const rentClass=item.rent <= 75000 ? "textRed":"textGreen";

    return (
        <div className="officeBox">
            <img 
             src={process.env.PUBLIC_URL + "/" + item.image}
             alt="Office"
             width="25%"
             height="25%"
            />
            <h1 className={rentClass}>Name:{item.name}</h1>
            <h3 className={rentClass}>Rent: Rs.{item.rent}</h3>
            <h3>Address: {item.address}</h3>
        </div>
    );
}

export default OfficeItem;

