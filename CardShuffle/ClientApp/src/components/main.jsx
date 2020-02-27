import React, { Component } from "react";
import { Switch, Route } from "react-router-dom";
import Cards from "./cards";

class Main extends Component {
  render() {
    return (
      <main>
        <Switch>
          <Route exact path="/" component={Cards} />
        </Switch>
      </main>
    );
  }
}

export default Main;
