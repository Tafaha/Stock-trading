'use strict';

const apikey = 'cd4rhq2ad3i98jhu4ftgcd4rhq2ad3i98jhu4fu0';

const appleStockPrice = document.querySelector('#appleStockPrice');
const amazonStockPrice = document.querySelector('#amazonStockPrice');
const microsoftStockPrice = document.querySelector('#microsoftStockPrice');
const metaStockPrice = document.querySelector('#metaStockPrice');
const netflixStockPrice = document.querySelector('#netflixStockPrice');

//  Displaying the current date for each card
const showDate = document.querySelectorAll('.showDateClass');
const date = new Date();
let currentDate = date.toDateString();

for (let i = 0; i < 5; i++) {
  showDate[i].innerHTML += currentDate;
}

const getStockPriceApple = async () => {
  try {
    const res = await axios.get(
      `https://finnhub.io/api/v1/quote?symbol=AAPL&token=${apikey}`
    );
    const price = res.data.c;
    // appleStockPrice.innerText = parseFloat(price) + ' USD';
    appleStockPrice.innerText = price.toFixed(2) + ' USD';
  } catch (e) {
    console.log('ERROR', e);
  }
};
getStockPriceApple();

const getStockPriceAmazon = async () => {
  try {
    const res = await axios.get(
      `https://finnhub.io/api/v1/quote?symbol=AMZN&token=${apikey}`
    );
    const price = res.data.c;
    amazonStockPrice.innerText = price.toFixed(2) + ' USD';
  } catch (e) {
    console.log('ERROR', e);
  }
};
getStockPriceAmazon();

const getStockPriceMicrosoft = async () => {
  try {
    const res = await axios.get(
      `https://finnhub.io/api/v1/quote?symbol=MSFT&token=${apikey}`
    );
    const price = res.data.c;
    microsoftStockPrice.innerText = price.toFixed(2) + ' USD';
  } catch (e) {
    console.log('ERROR', e);
  }
};
getStockPriceMicrosoft();

const getStockPriceMeta = async () => {
  try {
    const res = await axios.get(
      `https://finnhub.io/api/v1/quote?symbol=META&token=${apikey}`
    );
    const price = res.data.c;
    metaStockPrice.innerText = price.toFixed(2) + ' USD';
  } catch (e) {
    console.log('ERROR', e);
  }
};
getStockPriceMeta();

const getStockPriceNetflix = async () => {
  try {
    const res = await axios.get(
      `https://finnhub.io/api/v1/quote?symbol=NFLX&token=${apikey}`
    );
    const price = res.data.c;
    netflixStockPrice.innerText = price.toFixed(2) + ' USD';
  } catch (e) {
    console.log('ERROR', e);
  }
};
getStockPriceNetflix();
