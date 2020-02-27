import React, { Component } from "react";
import Heart from "../images/heart.png";
import Spade from "../images/spade.png";
import Diamond from "../images/diamond.png";
import Flower from "../images/flower.png";
import { cardTypeEnum } from "../helpers/card-type-enum";

class Card extends Component {
  getImage() {
    switch (this.props.card.cardTypeEnum) {
      case cardTypeEnum.Diamond:
        return Diamond;
      case cardTypeEnum.Flower:
        return Flower;
      case cardTypeEnum.Heart:
        return Heart;
      case cardTypeEnum.Spade:
        return Spade;
    }
  }

  getCardNumber() {
    if (this.props.card.cardNumber === 1) return "A";
    else if (this.props.card.cardNumber === 11) return "J";
    else if (this.props.card.cardNumber === 12) return "Q";
    else if (this.props.card.cardNumber === 13) return "K";
    return this.props.card.cardNumber;
  }

  render() {
    return (
      <div>
        <li className="card">
          <label className="upper-number">{this.getCardNumber()}</label>
          <img src={this.getImage()} />
          <label className="lower-number">{this.getCardNumber()}</label>
        </li>
      </div>
    );
  }
}

export default Card;
