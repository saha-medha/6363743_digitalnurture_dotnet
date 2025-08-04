import React, { useState } from 'react';
import Greeting from './Greeting';
import LoginButton from './Components/LoginButton';
import LogoutButton from './Components/LogoutButton';

function App() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);

  const handleLoginClick = () => {
    setIsLoggedIn(true);
  };

  const handleLogoutClick = () => {
    setIsLoggedIn(false);
  };

  return (
    <div style={{ padding: '20px', fontFamily: 'Arial' }}>
      <h1> Welcome to Flight Booking Portal</h1>
      <Greeting isLoggedIn={isLoggedIn} />

      <h2>Flight Details:</h2>
      <ul>
        <li>Flight: Indigo</li>
        <li>From: Delhi</li>
        <li>To: Mumbai</li>
        <li>Time: 10:00 AM</li>
      </ul>

      {isLoggedIn ? (
        <LogoutButton onClick={handleLogoutClick} />
      ) : (
        <LoginButton onClick={handleLoginClick} />
      )}
    </div>
  );
}

export default App;
