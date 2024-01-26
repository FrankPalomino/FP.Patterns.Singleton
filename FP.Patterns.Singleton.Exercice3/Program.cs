using FP.Patterns.Singleton.Exercice3;

Logger logger = Logger.GetInstance();

logger.AddLog(new Log() { Severity = "Warning", Message = "Be carefull" }); 
logger.AddLog(new Log() { Severity = "Alert", Message = "Please Stop" });

foreach(Log log in logger.GetLog())
{
    Console.WriteLine(log.Message);
}

Console.WriteLine("\nNext Logger------------------\n");

Logger logger2 = Logger.GetInstance();

foreach(Log log in logger2.GetLog())
{
    Console.WriteLine(log.Message);
}