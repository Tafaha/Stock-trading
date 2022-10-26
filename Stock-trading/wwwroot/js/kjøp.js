const apikey = 'cd4rhq2ad3i98jhu4ftgcd4rhq2ad3i98jhu4fu0';

const dropdownMenu = document.querySelector('#stockSelect');
const priceInput = document.querySelector('#stockPrice');

const symbols = ['','AAPL', 'AMZN', 'MSFT', 'META', 'NFLX'];

dropdownMenu.onchange = async () => {
    let selecetedIndex = `${dropdownMenu.selectedIndex}`;
    let selectedOption = dropdownMenu.options[selecetedIndex];
    if (
        selectedOption.innerText === 'Apple' ||
        selectedOption.innerText === 'Amazon' ||
        selectedOption.innerText === 'Microsoft' ||
        selectedOption.innerText === 'Meta' ||
        selectedOption.innerText === 'Netflix'
    ) {
        try {
            let res = await axios.get(
                `https://finnhub.io/api/v1/quote?symbol=${symbols[selecetedIndex]}&token=${apikey}`
            );
            let price = res.data.c;
            priceInput.value = Math.floor(price);
        } catch (e) {
            console.log('ERROR', e);
            priceInput.value = `ERROR! Cannot fetch the data API`;
        }
    }
};