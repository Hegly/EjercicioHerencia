using EjercicioHerencia;

Vertebrado vertebrado1 = new()
{
    nombre = "Gato",
    color = "Blanco",
    tamano = "Mediano",
    familia = "Felinidae",
    tipo = "Mamífero",
    tienePatas = true,
    esDomestico = true,
    esHerviboro = false,
    esCarnivoro = true
};

Vertebrado vertebrado2 = new()
{
    nombre = "Gallina",
    color = "Negra",
    tamano = "Pequeña",
    familia = "Phasianidae",
    tipo = "Ave",
    tienePatas = true,
    esDomestico = true,
    esHerviboro = true,
    esCarnivoro = true
};

Invertebrado invertebrado1 = new()
{
    nombre = "Araña",
    color = "Blanca",
    tamano = "Pequeña",
    familia = "Arácnidos",
    tipo = "Arácnido",
    tienePatas = true,
    numeroPatas = 8,
    tieneConcha = false
};

Invertebrado invertebrado2 = new()
{
    nombre = "Caracol",
    color = "Marrón y Beige",
    tamano = "Pequeño",
    familia = "Moluscos",
    tipo = "Molusco",
    tienePatas = false,
    numeroPatas = 0,
    tieneConcha = false
};

if (vertebrado1.validar())
{
    vertebrado1.imprimir();
    vertebrado1.imprimirVertebrado();
}
else
{
    Console.WriteLine("Ingrese todos los datos");
}

if (vertebrado2.validar())
{
    vertebrado2.imprimir();
    vertebrado2.imprimirVertebrado();
}
else
{
    Console.WriteLine("Ingrese todos los datos");
}

if (invertebrado1.validar())
{
    invertebrado1.imprimir();
    invertebrado1.imprimirInvertebrado();
}
else
{
    Console.WriteLine("Ingrese todos los datos");
}

if (invertebrado2.validar())
{
    invertebrado2.imprimir();
    invertebrado2.imprimirInvertebrado();
}
else
{
    Console.WriteLine("Ingrese todos los datos");
}
