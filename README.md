# ProyectoSO - Aplicación Cliente-Servidor para Juego

Este proyecto es parte del curso de Sistemas Operativos 2024-25 y consiste en desarrollar una aplicación cliente-servidor que gestiona la interacción entre jugadores y la base de datos del juego. El desarrollo se realiza en varias versiones incrementales que van añadiendo funcionalidades y mejorando la arquitectura.

---

## Versiones del Proyecto

### Versión 1
- Aplicación cliente-servidor en la que el cliente puede:
  - Registrarse.
  - Autenticarse.
  - Realizar al menos tres consultas diferentes en la base de datos del juego.
- El servidor está organizado de forma secuencial.

### Versión 2
- Igual que la versión 1, pero ahora el servidor es concurrente.
- El servidor mantiene una lista de jugadores conectados y la envía al cliente cuando se le solicita.
- Se implementan operaciones para garantizar acceso exclusivo a estructuras de datos compartidas cuando sea necesario.

### Versión 3
- La lista de jugadores conectados se envía automáticamente a todos los clientes cuando hay una modificación en su contenido.

### Versión 4
- Incorpora el protocolo de invitación al juego.
- Cada jugador conectado puede invitar a otros a jugar una partida.
- El servidor gestiona aceptaciones y rechazos de invitaciones.

### Versión 5
- Se incorporan las operaciones necesarias para evitar la excepción *cross-threading* en el cliente.

---

## Versión Final
Una vez completadas todas las versiones preliminares, cada grupo implementará el juego completo según su elección de nivel (básico, medio o avanzado).

---

## Tecnologías usadas

- Lenguaje de programación: C#
- Frameworks / Librerías: .NET
- Base de datos: SQL

---

## Cómo usar el proyecto

1. Clonar el repositorio.
2. Configurar la base de datos según la versión.
3. Ejecutar el servidor.
4. Ejecutar uno o más clientes.
5. Seguir las instrucciones específicas de cada versión para probar las funcionalidades.

---

## Licencia

[Especificar licencia del proyecto]

---

## Vídeos de cada versión

versión 1: https://youtu.be/hNBozB-SRcQ

versión 2: https://www.youtube.com/watch?v=viDg6YxOjs4

versión 3: https://www.youtube.com/watch?v=mCpoR4QUM8w

versión 4: https://youtu.be/7fexIMi69Uc

versión 5: https://www.youtube.com/watch?v=Qz7Xw9_plZ2

versión final: https://youtu.be/RR94u8rZi5s



Si necesitas ayuda o tienes dudas, no dudes en contactar con los responsables del proyecto o consultar la documentación adicional.

