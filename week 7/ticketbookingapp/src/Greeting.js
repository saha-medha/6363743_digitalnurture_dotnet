import React from 'react';
import UserGreeting from "./Components/UserGreeting";
import GuestGreeting from "./Components/GuestGreeting";

function Greeting(props) {
  const isLoggedIn = props.isLoggedIn;
  return isLoggedIn ? <UserGreeting /> : <GuestGreeting />;
}

export default Greeting;
