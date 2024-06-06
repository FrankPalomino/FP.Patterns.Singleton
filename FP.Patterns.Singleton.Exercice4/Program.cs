using FP.Patterns.Singleton.Exercice4;

Logger log = Logger.GetLogger();
log.Log("First log");
log.ShowLogs();

Console.WriteLine("--------------------------");

Logger log2 = Logger.GetLogger();
log2.Log("Second log");

log2.ShowLogs();