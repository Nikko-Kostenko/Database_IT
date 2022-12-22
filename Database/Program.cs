using EssentialDatabase.Core;
using EssentialDatabase.CLI;
using EssentialDatabase.Management;

const string storeDbPath = @"C:\Users\Kostenko.Mykola\Documents\temp";

PersistenceService persistenceService = new(storeDbPath);
DatabaseManager databaseManager = new(persistenceService);

CLIManager cliManager = new CLIManager(databaseManager);
cliManager.StartConsoleReading();
