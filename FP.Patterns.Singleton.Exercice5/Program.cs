using FP.Patterns.Singleton.Exercice5;

Logger log = Logger.GetInstance();

log.Log("Firt Message");

Logger log2 = Logger.GetInstance();

log2.Log("Another message");