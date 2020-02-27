import React, { Component } from "react";
import { getAllCards, shuffleCards } from "../services/card-services";
import Card from "./card";

class Cards extends Component {
  state = {
    cardsHolder: [],
    isShuffling: false
  };

  componentDidMount = async () => {
    var cardsHolder = await getAllCards();
    //   console.log(cardsHolder);
    this.setState({ cardsHolder });
  };

  shuffle = async () => {
    this.setState({ isShuffling: true });
    var cardsHolder = await shuffleCards();
    this.setState({ cardsHolder, isShuffling: false });
  };

  render() {
    return (
      <div>
        <button
          className="shuffle"
          disabled={this.state.isShuffling}
          onClick={this.shuffle}
        >
          {this.state.isShuffling ? "Shuffling" : "Shuffle"}
        </button>
        <ul className="cards-holder">
          {this.state.cardsHolder.map((card, i) => (
            <Card key={i} card={card} />
          ))}
        </ul>
      </div>
    );
  }
}

export default Cards;
