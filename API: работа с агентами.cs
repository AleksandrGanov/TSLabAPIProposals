// создает агента с указанными именем, источником, инструментами
// bool - возвращает True если агент успешно создан, то есть не произошло ошибки создания.
// Под ошибкой создания подразумеваются любые ошибки начиная от неверно заданного имени имени скрипта
// на основании которого создается агент, заканчивая неверно переданными в метод именами источника/бумаги
bool Сontext.CreateAgent(string agentName, string scriptName, IEnumerable<(source, sec)>){}

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

// метод выдает коллекцию имен торговых параметров агента, в случае неверно указанного имени
// агента выдает пустую коллекцию
IEnumerable<(string tradeParam, object paramValue)> Context.GetAgentTradeParams(string agentName){}

// метод выдает коллекцию имен торговых параметров агента, в случае неверно указанного имени
// агента выдает пустую коллекцию
IEnumerable<(string tradeParam, object paramValue)> Context.GetAgentParams(string agentName){}

// метод устанавливает торговые параметры агента
// bool - возвращает True только в случае если все параметры удалось установить
// False - возвращется при наличии любых ошибок от попытка задать параметры агента
// в статусах: Running, Error, заканчивая неверное переданным именем агента, именами/типами параметров
bool Context.SetAgentTradeParams(string agentName, IEnumerable<(string paramName, object paramValue)>)

// метод устанавливает параметры агента
// bool - возвращает True только в случае если все параметры удалось установить
// False - возвращется при наличии любых ошибок от попытка задать параметры агента
// в статусах: Running, Error, заканчивая неверное переданным именем агента, именами/типами параметров
bool Context.SetAgentParams(string agentName, IEnumerable<(string paramName, object paramValue)>)

// все задачи по определению типов значений параметров ложатся на пользователя, чтобы не усложнять API

// статусы агентов
enum AgentStatus
{
  Running, // агент работает
  Stopped, // агент остановлен
  Error // агент в состоянии ошибки
}
