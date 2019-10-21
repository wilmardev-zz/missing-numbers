# missing-numbers
Solution for the callenge publish in hackerrank "Missing Numbers"

La aplicación se encuentra desarrollada en .Net Core como **Console Application**

# Para ejecutar la aplicación
**1**. Tener instalado .Net Core ya sea con Visual Studio o Visual Studio Code. <br />
**2**. Compilar la aplicación, **no tiene dependencia alguna**. <br />
**3**. Ejecutar la aplicación y seguir los pasos en consola.

# Para ejecutar las pruebas
**1**. Visualizar el proyecto **MissingNumbers.Test** en la clase **UnitTest**.
  se presentan los casos que se probaron con el fin de realizar las validaciones que el reto solicita.<br />
**2**. Ejecutar las pruebas una a una o en el **Test Explorer** ejecutarlas todas.

# Manejo de errores en la solución
Para llevar a cabo este control se hicieron validaciones y algunas se orientaron a
excepciones con su mensaje específico, como por ejemplo si en el brrList dentro de la línea agregas números 
y letras... Este lo detecta pero se debe reiniciar la aplicación. La aplicación informa si esto sucede.

# Estructura de la aplicación
**1.** Se tiene la capa inicial donde se encuentra el llamado a la ejecución de la solución. <br />
**2.** Se tiene la capa de BR (Business Rules) donde se encuentran las respectivas validaciones y
la implementación de la solución de acuerdo a las reglas. <br />
**3.** La capa de pruebas donde se realizaron las validaciones a las entradas erróneas que el usuario hace, en este caso
se hizo un control orientado a excepciones, es decir, si algo va mal la aplicación crea una excepción e informa la
situación en consola. <br />
**4.** Para el reto no fue necesario crear una capa de dominio ni de persistencia (BD)

<br />
<br />
<br />

# Link reto en Hackerrank (https://www.hackerrank.com/challenges/missing-numbers/problem)
