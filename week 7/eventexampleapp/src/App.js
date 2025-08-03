import React,{Component} from "react";
import CurrencyConvertor from "./CurrencyConvertor";

class App extends Component{

  constructor(props){
    super(props);
    this.state={
      count:1
    };
  }

  incrementValue= () => {
    this.setState({count:this.state.count+1},()=>{
      this.sayHello();
    });
  };

  sayHello=() =>{
    alert("Hello! You clicked increment");
  };

  decrementValue=()=>{
    this.setState({count:this.state.count-1});
  };

  sayMessage=(msg)=>{
    alert(msg);
  }

  handleClick=(event)=>{
    alert("I was clicked");
  };

  render(){
    return (
      <div style={{ padding: "20px" }}>
        <h3>{this.state.count}</h3>
        <button onClick={this.incrementValue}>Increment</button>
        <br />
        <button onClick={this.decrementValue}>Decrement</button>
        <br />
        <button onClick={() => this.sayMessage("Welcome")}>Say welcome</button>
        <br />
        <button onClick={this.handleClick}>Click on me</button>

        <CurrencyConvertor />
      </div>
    );
  }
}

export default App;