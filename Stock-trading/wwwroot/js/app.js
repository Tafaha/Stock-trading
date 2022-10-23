'use strict';

const apikey = 'cd4rhq2ad3i98jhu4ftgcd4rhq2ad3i98jhu4fu0';

const appleEl = document.querySelector('#appleStockPrice');
const amazonEl = document.querySelector('#amazonStockPrice');
const microsoftEl = document.querySelector('#microsoftStockPrice');
const metaEl = document.querySelector('#metaStockPrice');
const netflixEl = document.querySelector('#netflixStockPrice');

//  Displaying the current date for each card
const showDate = document.querySelectorAll('.showDateClass');
const date = new Date();
let currentDate = date.toDateString();

for (let i = 0; i < 5; i++) {
    showDate[i].innerHTML += currentDate;
}

//  Display  daily stock prices
const symbols = ['AAPL', 'AMZN', 'MSFT', 'META', 'NFLX'];

const getStockPrices = async () => {
    for (let i = 0; i < symbols.length; i++) {
        try {
            let res = await axios.get(
                `https://finnhub.io/api/v1/quote?symbol=${symbols[i]}&token=${apikey}`
            );
            let price = res.data.c;
            const str = `${price.toFixed(2)} USD`;

            if (i === 0) appleEl.innerText = str;
            if (i === 1) amazonEl.innerText = str;
            if (i === 2) microsoftEl.innerText = str;
            if (i === 3) metaEl.innerText = str;
            if (i === 4) netflixEl.innerText = str;
        } catch (e) {
            console.log('ERROR', e);
        }
    }
};

getStockPrices();