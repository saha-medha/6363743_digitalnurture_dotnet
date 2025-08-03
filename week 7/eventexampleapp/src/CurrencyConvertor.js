import React,{Component} from "react";

class CurrencyConvertor extends Component{
    constructor(props){
        super(props);
        this.state={
            amount:"",
            currency:"Euro"
        };
    }

    handleChange= (event) =>{
        const {name,value}=event.target;
        this.setState({[name]:value});
    };

    handleSubmit=(event)=>{
        event.preventDefault();
        const rupees=parseFloat(this.state.amount);
        const rate=80;
        const total= rupees * rate;
        alert(`Converting to ${this.state.currency} Amount is ${total}`);
    };

   render() {
    return (
        <div>
            <h1 style={{color:"green"}}>
            Currency Convertor !!!
            </h1>
            <form onSubmit={this.handleSubmit}>
             <label>Amount: </label>
             <input 
             type="number"
             name="amount"
             value={this.state.amount}
             onChange={this.handleChange}
             />
             <br />
             <label>Currency: </label>
             <select
             name="currency"
             value={this.state.currency}
             onChange={this.handleChange}
             >
             <option value="Euro">Euro</option>
             <option value="USD">USD</option>
             </select>
             <br />
             <button type="submit">Submit</button>
            </form>
        </div>
    );
   }
}

export default CurrencyConvertor;