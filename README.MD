# Laboratorio de Innovación, Inteligencia y Experiencia Constitucional del  Tribunal Constitucional de la  República Dominicana

![enter image description here](https://res.cloudinary.com/djgjgies2/image/upload/v1698122937/TribunalConstitucional/sakqqbzn0grgdphivj1p.png)


Este repositorio es el resultado de una colaboración estrecha entre **Paola Santana** y el **Tribunal Constitucional de la República Dominicana**, buscando recopilar, documentar y destacar los avances tecnológicos llevados a cabo en el Tribunal. Los avances cubren una amplia gama que incluye desde software y bases de datos hasta sistemas de gestión documental, herramientas de visualización, y medidas de automatización y seguridad.

La filosofía detrás de este repositorio es establecer un enfoque de código abierto, lo que significa que tanto el código fuente como las soluciones tecnológicas desarrolladas están al alcance de la comunidad. Esto permite su estudio, modificación y reutilización, impulsando así la innovación y el desarrollo tecnológico.

Para facilitar este proceso, se ha hecho un énfasis particular en proporcionar una documentación detallada, que incluye desde manuales de usuario y guías de implementación hasta descripciones técnicas profundas. Con esto, se busca que cualquier interesado pueda entender, adoptar y adaptar las tecnologías presentadas.

Una de las características destacadas es la plataforma interactiva diseñada para la exploración y el aprendizaje, donde los usuarios pueden encontrar demos, tutoriales interactivos, videos y espacios de discusión. Además, en línea con la visión de código abierto, los proyectos de software llevados a cabo por Paola Santana para esta iniciativa operan bajo licencias reconocidas, permitiendo su modificación y adaptación.

Otro objetivo clave es fomentar la adopción de estándares abiertos en todas las soluciones tecnológicas. Esto no solo garantiza la calidad y la interoperabilidad, sino que también facilita la colaboración con otras instituciones y sistemas.


# Proyectos

En una era marcada por la rapidez y la innovación tecnológica, el Tribunal Constitucional de la República Dominicana ha tomado la decisiva medida de adaptarse y modernizarse. En una colaboración estratégica con Paola Santana, líder en soluciones tecnológicas, han lanzado un conjunto de proyectos que buscan revolucionar la justicia constitucional, utilizando la tecnología para hacerla más eficiente, transparente y accesible. Estas iniciativas, que abarcan desde la automatización de tareas hasta el uso de inteligencia artificial, reflejan el compromiso del Tribunal Constitucional de estar a la vanguardia y de ofrecer a los ciudadanos un servicio judicial de primer nivel.

A continuación, se presentan los proyectos clave que se llevaron a cabo en esta colaboración:

## Síntesis Autónoma: Agilizando la Redacción de Sentencias mediante IA en el Tribunal Constitucional

Se procedió a automatizar el proceso de redacción de sentencias y la creación de resúmenes automáticos, con el objetivo principal de reducir el tiempo necesario para la redacción y, por consiguiente, incrementar la capacidad de emitir un mayor número de sentencias en un periodo determinado.

En la fase de redacción de sentencias, se abordó el proceso en el cual el departamento de secretaría lleva a cabo la redacción manual de las sentencias. Reconociendo la naturaleza manual, repetitiva y de alto consumo temporal de este procedimiento, se determinó la creación de un programa para la generación automatizada de dichas redacciones.

Este programa toma todas las partes que debían ser ingresadas manualmente y las ingresa automáticamente con la información necesaria. Esta, también tiene la capacidad de inspección para que el usuario de secretaria pueda confirmar que toda la información está correcta. Tiene la posibilidad de que si existe algún cambio que hay que realizarse, este se pueda realizar sin interrumpir el proceso.

![enter image description here](https://res.cloudinary.com/djgjgies2/image/upload/v1698730083/Generar_Sentencia_k84cna.png)

En la parte de la eloboración de un resumen automatico, La inteligencia artificial se encarga de leer el contenido completo de la sentencia y, a partir de su comprensión del texto, genera automáticamente un resumen conciso y coherente. Esta automatización no solo acelera el proceso de documentación, sino que también garantiza la consistencia y calidad en
la elaboración de resúmenes, optimizando la labor de la secretaría y permitiendo un uso más eficiente de los recursos.


## Desarrollo de visualizaciones estadísticas y tableros

Para el desarrollo de los tableros, se decidió utilizar la misma plataforma en la que se desarrolló la generación de sentencias automatizada para almacenar toda la información de los tableros. Esta decisión se basa en una estrategia de centralización y eficiencia. Al adoptar la misma estructura tecnológica, hemos garantizado que todos los datos cruciales estén concentrados en un solo lugar, lo que simplifica en gran medida la gestión y la accesibilidad.
Esta convergencia tecnológica no solo optimiza la utilización de recursos, sino que también mejora significativamente la sincronización de datos, permitiendo una actualización y un análisis más efectivos en tiempo real.

La "Funcionalidad de Transformación de Datos en Tablero Estadístico"representa una herramienta esencial en nuestra plataforma, diseñada para agilizar la creación de tableros estadísticos mediante la introducción manual de datos. Esta característica simplifica el proceso de transformación de datos numéricos y cualitativos en tableros visuales, informativos y de fácil interpretación.

![enter image description here](https://res.cloudinary.com/djgjgies2/image/upload/v1698730082/Dashboard_lkl3jy.png)

Mediante esta funcionalidad, los usuarios pueden cargar y organizar datos directamente desde su interfaz de usuario, lo que elimina la necesidad de complejos procedimientos de importación o integración.


### Requisitos 
1.  **Software:**  - Visual Studio 2019 (o superior) con soporte para .NET Framework 4.8 
- Alternativamente: Visual Studio Code con la extensión C# y .NET Core SDK instalado 
2.  **Azure**: - Cuenta en Azure para la conexión a la base de datos 
3.  **Chat GPT API Key**: - Necesitarás una API key válida de Chat GPT para la generación de tweets 


###  Pasos para ejecutar el proyecto  

**Usando Visual Studio:** 
1.  **Clonar el Repositorio**: `git clone ...`
2.  **Abrir el proyecto**: - Doble clic en el archivo `.sln` para abrirlo en Visual Studio.
3.  **Configurar las cadenas de conexión**: - Dirígete a `Web.config` y busca la sección `<connectionStrings>`. Añade tu cadena de conexión de Azure aquí. 
4.  **Configurar la API Key**: - En `Web.config`, busca la sección `<appSettings>` y añade tu API key de Chat GPT. 
5.   **Ejecutar el Proyecto**: - Presiona `F5` para iniciar el proyecto en modo de depuración.

**Usando Visual Studio Code:** 
1.  **Clonar el Repositorio**: `git clone [URL_DEL_REPOSITORIO]`. 
2.   **Abrir el proyecto**:
- Abre Visual Studio Code y navega al directorio del proyecto usando el menú `File > Open Folder`.

3. **Configurar las cadenas de conexión**:
- Dirígete a `Web.config` usando el explorador de archivos de VS Code y busca la sección `<connectionStrings>`. Añade tu cadena de conexión de Azure aquí.

4. **Configurar la API Key**:
- En `Web.config`, busca la sección `<appSettings>` y añade tu API key de Chat GPT.

5. **Restaurar paquetes**:
- Utiliza la terminal integrada y ejecuta:
  ```
  dotnet restore
  ```

6. **Ejecutar el Proyecto**:
- En la terminal integrada, introduce:
  ```
  dotnet run
  ```

Una vez que el proyecto esté corriendo, podrás acceder a él desde tu navegador preferido.



## Primer Chatbot de la República Dominicana Impulsado por Inteligencia Artificial en materia jurisdiccional para el Tribunal Constitucional

Se implementó una mejora al chatbot del Tribunal Constitucional con la capacidad de responder a preguntas relacionadas con información general del tribunal constitucional, la constitución de la República Dominicana, así como sentencias y comunicados emitidos. Esta solución busca agilizar y facilitar la obtención de información para los usuarios, al tiempo que alivia la carga de trabajo del personal de secretaría al brindar respuestas instantáneas y precisas.

![enter image description here](https://res.cloudinary.com/djgjgies2/image/upload/v1698727365/Screenshot_2023-10-31_at_12.41.59_AM_k7ywk7.png)

El chatbot impulsado por inteligencia artificial es capaz de responder preguntas en lenguaje natural se apoya en complejas técnicas de procesamiento del lenguaje natural y aprendizaje automático. En primer lugar, el texto introducido por el usuario es sometido a un proceso de preprocesamiento para eliminar elementos innecesarios y dividirlo en unidades comprensibles. A continuación, el chatbot analiza la estructura gramatical y el significado semántico de las frases mediante algoritmos especializados, lo que le permite convertir el texto en representaciones numéricas llamadas vectores. Estos vectores son procesados por modelos de aprendizaje automático previamente entrenados en grandes conjuntos de datos de preguntas y respuestas, lo que le permite al chatbot aprender patrones y construir un conocimiento del lenguaje. Cuando los usuarios
hacen preguntas, el chatbot consulta su conocimiento adquirido y generarespuestas coherentes basadas en el contexto de la pregunta.

Este proceso continuo de aprendizaje y optimización del chatbot permite que mejore su capacidad para comprender y responder a las preguntas en lenguaje natural a medida que interactúa con más usuarios. En esencia, la IA en el chatbot le proporciona la capacidad de interpretar y generar respuestas relevantes y contextualmente apropiadas, lo que resulta en una interacción más eficiente y efectiva con los usuarios que buscan información o asistencia.

Luego de realizar un proceso de entrenamiento, El chatbot es capaz de responder cualquier pregunta referente a los siguientes temas:

 - Constitución de la república dominicana.
 - Reglamento Jurisdiccional del Tribunal Constitucional.
 - Informaciones generales sobre el Tribunal Constitucional.
 - Reglamento Administrativo.
 - Ley No. 137-11. 
 - Ley No. 145-11.

![enter image description here](https://res.cloudinary.com/djgjgies2/image/upload/v1698727366/Screenshot_2023-10-31_at_12.42.19_AM_wtxdui.png)

 ### Requisitos 
 1. Una cuenta activa en [Botpress.com](https://botpress.com/). 
 2. Documentos con los que desees entrenar al chatbot.
 3. Conexión a internet estable. 

### ¿Cómo funciona? 
1. **Inicio de Conversación**: Al acceder al chatbot, éste saluda al usuario y se pone a disposición para responder preguntas.
2. **Carga de Documentos**: Los usuarios pueden cargar sus propios documentos para entrenar y personalizar las respuestas del chatbot. 
3.  **Consulta de Documentos**: Cuando el chatbot recibe una pregunta, busca en su base de datos y documentos cargados para encontrar la respuesta más adecuada. 
4. **Respuesta Dinámica**: Basado en los documentos y el entrenamiento recibido, el chatbot proporciona una respuesta pertinente al usuario. 
5. **Feedback y Mejora Continua**: Después de entregar una respuesta, el chatbot solicita feedback. Este feedback es esencial para afinar y mejorar las respuestas futuras.
6.  **Despedida**: Una vez satisfechas las dudas del usuario, el chatbot se despide cordialmente. 

### ¿Por qué Botpress Studio? 
**Botpress** es una de las plataformas líderes en el desarrollo de chatbots, y no es para menos. Diseñada con una filosofía "open-source" y centrada en la flexibilidad, Botpress se ha ganado la confianza de desarrolladores y empresas alrededor del mundo. Aquí te presentamos algunas razones y beneficios para considerar Botpress como tu plataforma principal de desarrollo de chatbots:
1. **Open Source**: Botpress es de código abierto, lo que significa que tienes total libertad para personalizar, modificar y adaptar la plataforma a tus necesidades específicas.
2.  **Flexibilidad**: Con Botpress, no estás limitado a un conjunto específico de funcionalidades. Su diseño modular te permite agregar, modificar o eliminar componentes según lo requieras.
3. **Integraciones**: Botpress se integra sin problemas con las principales plataformas de mensajería como Facebook Messenger, Slack, Telegram, entre otras, facilitando la conexión con tus usuarios.
4. **Entrenamiento Natural**: La plataforma permite el uso de procesamiento de lenguaje natural (NLP) para que tu chatbot comprenda y responda de manera más humana, ofreciendo una experiencia de usuario fluida y natural.
5.  **Desarrollo Rápido**:Gracias a su interfaz intuitiva y herramientas de arrastrar y soltar, puedes diseñar flujos de conversación complejos sin necesidad de ser un experto en programación.
6.  **Comunidad Activa**: Al ser una plataforma open source, Botpress cuenta con una comunidad activa y en crecimiento. Esto significa que siempre tendrás acceso a tutoriales, soluciones a problemas comunes y nuevas ideas proporcionadas por la comunidad.
7.  **Seguridad**: Botpress permite mantener tus datos y los de tus usuarios seguros. Puedes alojar tu chatbot localmente o en tu propio servidor, garantizando que la información no caiga en manos equivocadas.
8.  **Escalabilidad**: La plataforma está diseñada para crecer contigo. Independientemente de si estás comenzando con un pequeño chatbot o si necesitas una solución empresarial, Botpress puede manejarlo.
9. **Multi-idioma**:Botpress soporta múltiples idiomas, lo que te permite alcanzar a una audiencia global sin barreras lingüísticas.
10.  **Costo-Efectividad**: Al ser una solución open source, puedes iniciar sin un gran desembolso inicial. A medida que creces, los costos asociados con Botpress siguen siendo competitivos en comparación con otras soluciones en el mercado.

### Diagrama del Flujo

![enter image description here](https://res.cloudinary.com/djgjgies2/image/upload/v1698729056/Screenshot_2023-10-31_at_1.10.30_AM_hty4po.png)
