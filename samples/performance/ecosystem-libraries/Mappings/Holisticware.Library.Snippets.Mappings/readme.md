# Mappings

readme.md

*   non-reflection-based (compile time)

    *   Maperly

        *   Description:

            A high-performance object mapper that supports both runtime and compile-time mapping.

        *   Website: Maperly

            *   https://github.com/riok/mapperly

            *   https://mapperly.riok.app/docs/getting-started/installation/

            *   https://mapperly.riok.app/

        *   Key Features:

            *   Compile-time mapping for better performance.

    *   Mapster

        *   Description:

            A high-performance object mapper that supports both runtime and compile-time mapping.

        *   Website: Mapster

            *   https://github.com/MapsterMapper/Mapster

        *   Key Features:

            *   Compile-time mapping for better performance.

            *   Flexible configuration.

            *   Supports LINQ projections.

            *   Lightweight and fast.

    *   SmartMapper

        *   Description:

            A lightweight and simple object mapper for .NET.

        *   Website: SmartMapper

            *   https://github.com/JulioGold/SmartMapper

            *   https://github.com/Royal-Code/SmartMapper

        *   Key Features:
            Easy to use.
            Focused on simplicity.

            SmartMapper is not reflection-based. It uses compile-time code generation to create mapping logic, similar
            to Mapperly. This approach avoids the runtime overhead of reflection, making it faster and more efficient
            compared to reflection-based mappers like AutoMapper or ValueInjecter.

        Key Features of SmartMapper:
        Compile-Time Mapping: Generates mapping code at compile time, ensuring high performance.
        No Reflection: Does not rely on runtime reflection, reducing overhead.
        Lightweight: Focused on simplicity and performance.
        Type Safety: Ensures type-safe mappings at compile time.
        If you're looking for a high-performance mapper that avoids reflection, SmartMapper is a good alternative
        alongside Mapperly and Mapster (when using its compile-time mapping feature).

    *   Manual Mapping

        Description: Writing custom mapping code manually without using a library.
        Key Features:
        Full control over the mapping logic.
        No external dependencies.
        Best for simple or highly specific mapping scenarios.

*   reflection-based (runtime)

    *   AutoMapper

        Description: A widely used library for object-to-object mapping. It provides a lot of flexibility and supports
        complex mapping scenarios.

        *   Website: AutoMapper

            *   https://automapper.org/

            *   https://github.com/AutoMapper/AutoMapper

        *   Key Features:

            *   Convention-based mapping.

            *   Custom value resolvers.

            *   Flattening and unflattening of objects.

            *   Support for projection (e.g., LINQ queries).

    *   ExpressMapper

        Description: A lightweight and fast object-to-object mapper with a focus on performance.

        *   Website: ExpressMapper

            *   https://github.com/fluentsprings/ExpressMapper

        *   Key Features:

            *   Simple API.

            *   High performance.

            *   Thread-safe.

    *   TinyMapper

        Description: A lightweight and fast object mapper for .NET.

        *   Website: TinyMapper

            *   https://github.com/TinyMapper/TinyMapper

        *   Key Features:

            Minimal configuration.
            High performance.
            Simple and easy to use.

    *   ValueInjecter

        Description: A flexible object mapper that allows injecting values from one object to another.

        *   Website: ValueInjecter

            *   https://github.com/omuleanu/ValueInjecter

        *   Key Features:
            Supports custom conventions.
            Can handle complex scenarios.
            Extensible with custom injectors.



Comparison
AutoMapper and Mapster are the most feature-rich and widely used.
Mapperly and Mapster are better for compile-time mapping, offering better performance.
Manual Mapping is ideal for small projects or when you need full control over the mapping logic.
Each library has its strengths and weaknesses, so the choice depends on your project's requirements, such as performance, complexity, and ease of use.

Comparison
AutoMapper and Mapster are the most feature-rich and widely used.
Mapperly and Mapster are better for compile-time mapping, offering better performance.
Manual Mapping is ideal for small projects or when you need full control over the mapping logic.
Each library has its strengths and weaknesses, so the choice depends on your project's requirements, such as performance, complexity, and ease of use.

