# EJERCICIO 4 - STRING

## ¿String es un tipo por valor o un tipo por referencia?

  En C#, el tipo de dato **string** es un tipo de referencia debido al diseño del lenguaje y a los requisitos para una gestión eficiente de la memoria. 
Esto significa que, al crear una variable de tipo **string** y asignarle un valor, se crea una referencia a un objeto en la memoria dinámica que 
contiene dicho valor.
  Cuando una variable se declara como un tipo de referencia, como por ejemplo **string**, significa que la variable no contiene directamente el valor real, 
sino una referencia (o una dirección de memoria) a la ubicación donde se almacena dicho valor. Esto permite un uso más eficiente de la memoria, 
especialmente al trabajar con cadenas largas o cuando es necesario copiarlas o transferirlas con frecuencia dentro de una aplicación.

## ¿Qué secuencias de escape tiene el tipo string?

En C#, las secuencias de escape se representan con una barra invertida seguida de un carácter específico. Se utilizan para insertar caracteres 
reservados o invisibles dentro de un literal de tipo string. 

  *   \'    Comilla Simple
  *   \"    Comilla Doble
  *   \\    Barra Invertida
  *   \0    Caracter Nulo
  *   \a    Alerta (emite un sonido de sistema)
  *   \b    Retroceso
  *   \f    Salto de Pagina
  *   \n    Salto de Linea
  *   \r    Retorno de Carro
  *   \t    Tabulacion Horizontal
  *   \v    Tabulacion Vertical

## ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?

  En C#, colocar los caracteres @ y $ (en cualquier orden, como $@ o @$) antes de una cadena activa dos funciones simultáneamente: interpolación de cadenas 
y literales textuales.

  1. **El símbolo $ (Interpolación)**<br/>
     Permite inyectar variables, expresiones o llamadas a métodos directamente dentro del texto envolviéndolos en llaves {}.
     
     * Ejemplo: $"Hola, {nombre}"
    
  3. **El símbolo @ (Literal Textual)**<br/>
     Le indica al compilador que ignore las secuencias de escape (como \n o \t) y que tome el texto exactamente como fue escrito, incluyendo los saltos de línea.
     
     * Ejemplo: @$"Línea 1\nLínea 2" (El texto se mostrará en dos líneas distintas y la \n no se interpretará como un salto de línea).
