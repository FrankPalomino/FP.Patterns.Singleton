using FP.Patterns.Singleton.Exercice2;

var config = ConfigurationManager.Instance();
config.DataBase = "Base de datos";
config.User = "Frank";

Console.WriteLine(config.User);
Console.WriteLine(config.DataBase);

var config2 = ConfigurationManager.Instance();

Console.WriteLine(config2.User);
Console.WriteLine(config2.DataBase);