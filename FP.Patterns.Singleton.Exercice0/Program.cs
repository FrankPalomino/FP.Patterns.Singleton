
using FP.Patterns.Singleton;

var single = Singleton.Instance;

single.mensaje = "Hola mundo desde el singleton";

var single2 = Singleton.Instance;

Console.WriteLine(single2.mensaje);