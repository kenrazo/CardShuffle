export const getAllCards = () => {
  return new Promise((resolve, reject) => {
    fetch("api/card", {
      method: "GET",
      credentials: "same-origin",
      headers: {
        Accept: "application/json, text/plain, */*",
        "Content-Type": "application/json"
      }
    })
      .then(response => response.json())
      .then(data => {
        resolve(data);
      })
      .catch(err => reject(err));
  });
};

export const shuffleCards = () => {
  return new Promise((resolve, reject) => {
    fetch("api/card/shuffle", {
      method: "GET",
      credentials: "same-origin",
      headers: {
        Accept: "application/json, text/plain, */*",
        "Content-Type": "application/json"
      }
    })
      .then(response => response.json())
      .then(data => {
        resolve(data);
      })
      .catch(err => reject(err));
  });
};
