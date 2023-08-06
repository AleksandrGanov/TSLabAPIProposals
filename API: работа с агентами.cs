// создает агента с указанными именем, инструментами, параметрами
// bool - возвращает True если агент успешно создан (не произошло ошибки создания)
bool Сontext.CreateAgent(string agentName, IEnumerable<(source, sec)>, IEnumerable<(paramName, paramValue)>){}

// удаляет агента с указанными именем
// bool - возвращает True если агент успешно удален (не произошло ошибки создания)
bool Сontext.DeleteAgent(string agentName){}

// запускает агента с указанными именем, инструментами, параметрами
// bool - возвращает True если агент успешно запущен
bool Сontext.StartAgent(string agentName){}

// запускает все агенты
// bool - возвращает True если все агенты успешно запущены
bool Сontext.StartAllAgents(){}

// останавливает агента с указанными именем, инструментами, параметрами
// bool - возвращает True если агент успешно остановлен
bool Сontext.StopAgent(string agentName){}

// останавливает все агенты
// bool - возвращает True если все агенты успешно остановлены
bool Сontext.StopAllAgents(){}

// возвращает коллекцию имен и статусов агентов
IEnumerable<(string, AgentStatus)> GetAllAgentsStatus(){}

// статусы агентов
enum AgentStatus
{
  Runnig,
  Stoped,
  Error
}
