import React from 'react';

function LogoutButton(props) {
  return (
    <button onClick={props.onClick} style={{ marginTop: '20px' }}>
      Logout
    </button>
  );
}

export default LogoutButton;
