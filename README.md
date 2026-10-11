# 🎓 Ruta de Aprendizaje de C# (Learning Path)

¡Bienvenido a tu mapa de aprendizaje estructurado para dominar C# y .NET 10 desde cero!

Este repositorio está organizado dentro del directorio `learn/` siguiendo una **curva de aprendizaje progresiva** para principiantes.

---

## 🗺️ Estructura del Learning Path (`learn/`)

```text
learn/
├── 📁 01-fundamentos/
│   ├── 📄 01-hola-mundo/                  -> Primer programa ejecutable y sintaxis básica.
│   └── 📄 02-variables-y-operadores/      -> Tipos primitivos, variables y operaciones matemáticas.
│
├── 📁 02-control-y-colecciones/
│   ├── 📄 01-condicionales-y-bucles/      -> Control de flujo con if/else, for y mientras (while).
│   └── 📄 02-listas-y-diccionarios/      -> Manejo de colecciones dinámicas (List<T> y Dictionary<K,V>).
│
├── 📁 03-orientado-a-objetos/
│   └── 📄 01-clases-y-metodos/            -> Programación Orientada a Objetos (POO): Clases, Objetos y Métodos.
│
└── 📁 04-proyecto-integrador/
    └── 📄 01-consola-interactiva/         -> Aplicación interactiva con menú CLI que integra todos los temas.
```

---

## 🚀 Cómo Ejecutar Cada Módulo

Puedes ingresar a cualquier módulo y ejecutarlo con `dotnet run`:

### 1️⃣ Paso 1: Fundamentos
```bash
# 1.1 Hola Mundo
dotnet run --project learn/01-fundamentos/01-hola-mundo/HolaMundo.csproj

# 1.2 Variables y Operadores
dotnet run --project learn/01-fundamentos/02-variables-y-operadores/VariablesYOperadores.csproj
```

### 2️⃣ Paso 2: Control y Colecciones
```bash
# 2.1 Condicionales y Bucles
dotnet run --project learn/02-control-y-colecciones/01-condicionales-y-bucles/CondicionalesYBucles.csproj

# 2.2 Listas y Diccionarios
dotnet run --project learn/02-control-y-colecciones/02-listas-y-diccionarios/ListasYDiccionarios.csproj
```

### 3️⃣ Paso 3: Programación Orientada a Objetos (POO)
```bash
# 3.1 Clases y Métodos
dotnet run --project learn/03-orientado-a-objetos/01-clases-y-metodos/ClasesYMetodos.csproj
```

### 4️⃣ Paso 4: Proyecto Integrador
```bash
# 4.1 Consola Interactiva Completa
dotnet run --project learn/04-proyecto-integrador/01-consola-interactiva/LearningCSharp.csproj
```

---

## 🏆 Consejos para estudiar

1. **Revisa el código fuente** de cada carpeta en `learn/`.
2. **Experimenta y modifica** los valores o añade nuevas variables.
3. **Ejecuta los comandos `dotnet run`** en la terminal para comprobar los resultados de tus cambios.
