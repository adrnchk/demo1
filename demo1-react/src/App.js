import "./App.css";
import { useState } from "react";

function App() {
  const [state, setState] = useState(0);
  const [a, setA] = useState(0);
  const [b, setB] = useState(0);

  const func = () => {
    var myHeaders = new Headers();
    myHeaders.append("accept", "text/plain");
    myHeaders.append("Content-Type", "application/json");

    var raw = JSON.stringify({
      a: a,
      b: b,
    });

    var requestOptions = {
      method: "POST",
      headers: myHeaders,
      body: raw,
      redirect: "follow",
    };

    fetch("https://localhost:32768/add", requestOptions)
      .then((response) => response.text())
      .then((result) => setState(result))
      .catch((error) => console.log("error", error));
  };

  return (
    <div className="App">
      <input
        placeholder="A"
        type="text"
        onChange={(e) => {
          setA(e.target.value);
        }}
      ></input>
      <input
        placeholder="B"
        type="text"
        onChange={(e) => {
          setB(e.target.value);
        }}
      ></input>
      <div className="button" onClick={func}></div>
      <p>Result: {state}</p>
    </div>
  );
}

export default App;
