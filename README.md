Descripción del Proyecto: Módulo de Retiro de Dinero para Cajero Automático
Este proyecto, se centra en el desarrollo del módulo de retiro de dinero para un cajero automático, utilizando controladores y vistas.
A continuación se detalla la funcionalidad principal y características del proyecto:

Funcionalidad Principal
El sistema permite configurar el modo de dispensación del cajero automático y realizar retiros de dinero. Se implementan tres modos de dispensación diferentes:

Modo 1: Solo devuelve billetes de 200 y 1000.
Modo 2: Solo devuelve billetes de 100 y 500.
Modo Eficiente: Devuelve la menor cantidad de billetes posible, utilizando denominaciones de 100, 200, 500 y 1000. Por ejemplo, para un retiro de 500 se entrega un billete de 500;
para un retiro de 700 se entrega un billete de 500 y uno de 200.

Menú y Configuración
Modo de Dispensación: El usuario puede seleccionar el modo de dispensación deseado a través de un menú. Al hacer clic en la opción,
se muestra un formulario con un selector para elegir el modo. El modo eficiente se establece por defecto.
La configuración seleccionada se guarda y se recupera al volver a ingresar a la pantalla de selección.

Pantalla Principal
Retiro de Dinero: El usuario puede ingresar la cantidad que desea retirar en un formulario.
Validación de Monto:
Solo se aceptan números enteros (no puede ser texto ni fracciones).
Debe validar el monto según el modo de dispensación configurado. Por ejemplo, si solo se dispensan billetes de 200 y 1000, y el usuario ingresa 100 o 300,
se mostrará un mensaje de error indicando que debe ingresar un monto adecuado.
Resultado del Retiro: Una vez ingresado un monto adecuado, se muestra cuántos billetes de cada denominación fueron dispensados según el modo configurado. Por ejemplo:
Modo 1 (200 y 1000): Si se retiran 800, se entregan 4 billetes de 200.
Modo 2 (100 y 500): Si se retiran 800, se entregan 1 billete de 500 y 3 de 100.
Modo Eficiente: Si se retiran 800, se entregan 1 billete de 500, 1 de 200 y 1 de 100.
Ejercicio de Prácticas Opcionales
Adicionalmente, se propone un ejercicio de práctica opcional que no tiene valor en la asignación pero sirve para mejorar habilidades:

Aplicación Web en .NET Core MVC: Crear una aplicación que solicite al usuario su día y mes de nacimiento y determine su signo zodiacal. (1 punto)
Tecnologías Utilizadas
.NET Core MVC: Para la creación de controladores y vistas.
HTML/CSS: Para la interfaz de usuario.
C#: Para la lógica de negocio.
Este proyecto proporciona una sólida base para comprender cómo implementar un módulo de retiro de dinero en un cajero automático,
con diferentes modos de dispensación y validaciones adecuadas para mejorar la experiencia del usuario.


PARA EL USO DE ESTE PROYECCTO SOLO TIENES QUE DESCARGARLO Y CORRERLO EN TU IDE DE VISUAL STUDIO O EN TU MAQUINA Y LISTO. 
