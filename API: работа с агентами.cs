// создает агента с указанными именем, источником, инструментами
// bool - возвращает True если агент успешно создан (не произошло ошибки создания)
bool Сontext.CreateAgent(string agentName, IEnumerable<(source, sec)>){}

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
IEnumerable<(string scriptName, AgentStatus agentStatus)> Context.GetAgentsInfo(){}

// метод выдает коллекцию имен торговых параметров агента (торговые 
IEnumerable<(string tradeParam, object paramValue)> Context.GetAgentTradeParams(){}

// метод выдает коллекцию имен торговых параметров агента (торговые 
IEnumerable<(string tradeParam, object paramValue)> Context.GetAgentParams(){}

// метод устанавливает торговые параметры агента
// bool - возвращает True только в случае если все параметры удалось установить
// False - возвращется при наличии любых ошибок
bool Context.SetAgentTradeParams(IEnumerable<(string paramName, object paramValue)>)

// метод устанавливает параметры агента
// bool - возвращает True только в случае если все параметры удалось установить
// False - возвращется при наличии любых ошибок
bool Context.SetAgentParams(IEnumerable<(string paramName, object paramValue)>)

// все задачи по определению типов значений параметров ложатся на пользователя, чтобы не усложнять API

// статусы агентов
enum AgentStatus
{
  Running, // агент работает
  Stopped, // агент остановлен
  Error // агент в состоянии ошибки
}
