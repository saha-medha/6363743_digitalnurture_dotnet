import React from "react";
import ListofPlayers from "./Components/ListofPlayers";
import Scorebelow70 from "./Components/Scorebelow70";
import { OddPlayers } from "./Components/OddPlayer";
import { EvenPlayers } from "./Components/EvenPlayer";
import ListofIndianPlayers from "./Components/ListofIndianPlayers";

function App(){
  const flag=false;

  const players=[
    { name: 'Virat', score: 95 },
    { name: 'Rohit', score: 85 },
    { name: 'Rahul', score: 45 },
    { name: 'Pant', score: 60 },
    { name: 'Hardik', score: 76 },
    { name: 'Jadeja', score: 55 },
    { name: 'Ashwin', score: 67 },
    { name: 'Shami', score: 88 },
    { name: 'Bumrah', score: 72 },
    { name: 'Gill', score: 62 },
    { name: 'Kuldeep', score: 49 }
  ];

  const IndianTeam = ['Virat', 'Rohit', 'Rahul', 'Pant', 'Hardik', 'Jadeja'];

  const T20Players = ['First Player', 'Second Player', 'Third Player'];
  const RanjiTrophyPlayers = ['Fourth Player', 'Fifth Player', 'Sixth Player'];
  const IndianPlayers = [...T20Players, ...RanjiTrophyPlayers];

  return (
    <div>
      {flag === true ? (
        <div>
          <h1>List of Players</h1>
          <ListofPlayers players={players} />
          <hr/>
          <h1>List of Players having Scores Less than 70 </h1>
          <Scorebelow70 players={players}/>
        </div>
      ):(
<div>
          <h1>Indian Team</h1>
          <h2>Odd Players</h2>
          {OddPlayers(IndianTeam)}
          <hr />
          <h2>Even Players</h2>
          {EvenPlayers(IndianTeam)}
          <hr />
          <h1>List of Indian Players Merged</h1>
          <ListofIndianPlayers IndianPlayers={IndianPlayers} />
        </div>

      )}

    </div>
  );

}

export default App;