Entendiendo la forma de trabajo de GitHub
=========================================

  - [Introducción](#introducción)
  - [Crear una rama](#crear-una-rama)
  - [Agregar commits](#agregar-commits)
  - [Abrir un Pull Request](#abrir-un-pull-request)
  - [Discutir y revisar tu código](#discutir-y-revisar-tu-código)
  - [Fusionar e implementar](#fusionar-e-implementar)


## Introducción ##

La forma de trabajo de GitHub es ligera, su forma de trabajo basado-en-ramas soporta equipos y proyectos donde las asignaciones se realizan regularmente. Esta guía explica como funciona la forma de trabajo de GitHub.


## Crear una rama ##

Nunca: editar sobre la rama MASTER directamente.

Siempre: Crear una rama (new branch) que duplicá la rama master para trabajar con la copia libremente.


## Agregar _commits_ ##

Cuando agregas, editas o borras un archivo, estás haciendo un _commit_, y agregando eso a tu rama. Este proceso de agregar _commits_ mantiene un registro de tu progreso mientras trabajas en una rama.

Los _commits_ también crean un historial de manera transparente a tu trabajo que otros pueden seguir para entender que has hecho y por qué. Cada _commit_ tiene asociado un mensaje, que es una descripción explicando el por qué de un cambio en particular.

#### Consejo Pro ####

Los mensajes de _commit_ son importantes, especialmente desde los seguimientos de Git de los cambios, ya que después los despliega dentro de los _commits_ una vez que ellos son enviados al servidor. Escribiendo mensajes de _commit_ claros, puedes hacer fácil para otras personas seguirte a lo largo y proveer retroalimentación.



## Abrir un _Pull Request_ ##

“Petición de Validación”. Una Pull Request es la acción de validar un código que se va a mergear de una rama a otra (Ej: mi-rama a master). 


#### Consejo Pro ####

Los _Pull Request_ son útiles para contribuir a proyectos de código abierto y para administrar cambios en los repositorios compartidos. Si estás utilizando un Modelo _Fork & Pull_, los _Pull Requests_ te darán una forma de notificar a los encargados del proyecto acerca de los cambios que desean que se consideren. Si estás utilizando el Modelo Repositorio Compartido, los _Pull Requests_ te ayudan a comenzar revisiones de código y conversaciones acerca de proporciones de cambios antes que ellos lo funcionen dentro de la rama _master_.



## Discutir y revisar tu código ##

Una vez que un _Pull Request_ ha sido abierto, la persona o el equipo que reviso tus cambios quizás tengan preguntas o comentarios. Tal vez el estilo de programación no coincide con las directrices del proyecto, el cambio no acepta los _unit testes_, o quizá todo se ve genial y está en orden. Los _Pull Requests_ están diseñados para alentar y capturar este tipo de conversaciones.

Puedes seguir enviando tus cambios a la rama en plena discusión o mientras comentan acerca de tus _commits_. Si alguien comenta que olvidaste hacer algo o que hay un _bug_ en tu código, puedes arreglarlo en tu rama y enviar el cambio. GitHub mostrará tus nuevos _commits_ y cualquier comentario adicional que quizás recibas en la vista unificada de _Pull Request_.

#### Consejo Pro ####

Los comentarios _Pull Request_ están escritos en Markdown, así que puedes incluir imágenes y _emoji_, utilizar bloques de texto con formato, y formateo ligero.



## Fusionar e implementar ##

Una vez que tu _Pull Request_ ha sido revisado y la rama paso tus pruebas, es tiempo de funcionar tu código con la rama _master_ para su implementación. Si quieres probar cosas antes de fusionarlo en el repositorio de GitHub, puedes realizar la fusión locamente primero. Esto es algo útil si no tienes acceso para enviar los cambios al repositorio.

Una vez funcionado, los _Pull Requests_ mantiene un registro del historial de cambios de tu código. Debido a esto puedes buscar, regresar a cualquier punto atrás en el tiempo para entender por qué y cómo una decisión fue tomada.

#### Consejo Pro ####

Incorporando ciertas claves dentro de tu texto en tus _Pull Request_, puedes asociar _issues_ con tu código. Cuando tu _Pull Request_ es fucionado, el _issue_ relacionado es cerrado. Por ejemplo, ingresando la frase `Closes #32` debería cerrar el _issue_ número 32 en el repositorio. Para más información, da un vistazo a nuestro [articulo de ayuda][ayuda].

[ayuda]: https://help.github.com/articles/closing-issues-via-commit-messages
