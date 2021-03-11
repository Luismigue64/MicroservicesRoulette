# MicroservicesRoulette
Endpoints para el juego de ruleta.

Se utilizan los siguientes Endpoints:

POST api/roulette/createroullette: Crea una ruleta  devuelve el Id.

PUT api/roulette/openroulette/{IdRuleta}: Abre la ruleta para permitir apuestas, no permite abrir una ruleta ya cerrada. Devuelve un boolean con el resultado del proceso.

POST api/bet/bets: Crea una apuesta sobre la ruleta especificada, sólo si la ruleta está abierta. Valída los posibles números de 0 a 36 y los colores Red y Black 
      Recibe los datos en formato JSON
      
      {
          "IdRoulette": "604aa1042970c5e818839712",
          "Number": "",
          "Color": "Black",
          "Wager": 7500,
          "IdUser": "lmrb",
          "Status": "Standby",
          "Win Amount": 0,
          "WinningNumber": "",
          "WinningColor": ""
      }
      
PUT api/roulette/closeroulette/{IdRuleta}: Cierra las apuestas en la ruleta y deveulve el resultado de ganadores y perdedores. Valida que la ruleta tenga apuestas para poder cerrarla.

GET api/roulette/roulettes: Lista todas las ruletas con su Id y su estado Abierto(Open) o Cerrado(Close).

GET api/bet/bets/{IdRuleta}: Deveulve las apuestas de una ruleta.

