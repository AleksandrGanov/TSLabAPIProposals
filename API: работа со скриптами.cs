// открывает указанный скрипт 
// scriptName - имя скрипта
// bool - возвращает True если скрипт найден, False - если скрипт найти не удалось
bool Gontext.OpenScript(string scriptName)

// закрывает указанный скрипт
// scriptName - имя скрипта
// bool - возвращает True если скрипт найден, False - если скрипт найти не удалось
bool Gontext.CloseScript(string scriptName)

// закрывает все открытые скрипты
bool Gontext.CloseAllScripts

// возвращает коллекцию имен закрытых скриптов
IEnumerable<string> GetAllOpenedScripts()
