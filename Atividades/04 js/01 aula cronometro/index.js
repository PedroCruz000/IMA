const timeOutTick = 1000;
const timeOutClock = 10000;

let momento = {
    minuto: 0,
    segundo: 0,

    preosseguir() {
        this.segundo++;

        if (this.segundo === 60) {
            this.segundo = 0;
            this.minuto++;
        }

        if (this.minuto === 60) {
            throw {
                msg: "limite de tempo excedido!",
            };
        }
    },
};

const marcadorRelogio = (momento) => {
    console.log(`tick...(${momento.minuto}:${momento.segundo})`);
    momento.preosseguir();
};

let interval = setInterval(marcadorRelogio, timeOutTick, momento);

setInterval(() => clearInterval(interval), timeOutClock);

