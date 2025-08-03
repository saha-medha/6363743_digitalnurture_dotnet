import React from "react";
import OfficeItem from "./OfficeItem";
import "./styles.css";

function App(){

  const officeSpaces=[
    {
      id: 1,
      name: "DBS",
      rent: 50000,
      address: "Chennai",
      image: "office.jpg"
    },
    {
      id: 2,
      name: "Cogni",
      rent: 75000,
      address: "Bangalore",
      image: "office.jpg"
    },
    {
      id: 3,
      name: "Walto",
      rent: 55000,
      address: "Hyderabad",
      image: "office.jpg"
    }
  ];

  return(
    <div>
      <h1>Office Space , at Affordable Range</h1>
      {officeSpaces.map((office)=> (
        <OfficeItem key={office.id} item={office} />
      ))}
    </div>
  );
}
export default App;