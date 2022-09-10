### 4) Investigue y Responda
**-  Investigue hacerca las diferentes formas de lanzar excepciones**

El *throw* es una palabra clave que señala la ocurrencia de una excepcion durante la ejecucion de un programa, da toda la informacion del stack trace y no resetea el stack trace, de esta forma el programador puede obtener la informacion de la excepcion actual.
El *throw ex* es una palabra clave que permite al programador indicar la ocurrencia de una excepcion que resetea el stack trace, no provee toda la informacion del mismo y resetea el stack trace, de esta forma el error aparece en la linea donde throw ex fue escrito.

El *throw new Exception(ex.Message)* crea una nueva instancia de excepcion y pierde el stack trace original de la misma como tambien su tipo. Ademas tambien puede perder informacion addicional de alguna excepciones.

**- ¿Qué función ocasionó el error en Dividir?**

La funcion FuncionLlamadoraB fue la que ocasionó el error en Dividir, por haber pasado un cero en la variable 'b' cuya cual se encuentra en el denominador de la division. *StackTrace* es una lista de llamada de metodos que una aplicaion realiza en el medio de su ejecucion cuando encuentra una excepcion.