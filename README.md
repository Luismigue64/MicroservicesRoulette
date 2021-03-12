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

Para la persistencia se usa una base de datos MongoDB en la que se creó una colección llamada MasivRoulette. Allí se crearon dos colecciones, Roulette, en la que se guarda el Id de cada ruleta, y su estado (null, Open  Close). La otra es Bet, en donde se guardan las apuestas, 

Estas son las estructuras:

Roulette:

      {
          "id" : "",
          "Status" : "" // null Open Close
      }

 Bet:
 
       {
          "id" : "",
          "IdRoulette" : "",
          "Number" : "", // 0 a 36
          "Color" : "", // Red Black
          "Wager" : 0, // 1 a 10000
          "IdUser" : "",
          "Status" : "", // Standby Win Loses
          "Win Amount" : 0,
          "WinningNumber" : "",
          "WinningColor" : ""
      }



