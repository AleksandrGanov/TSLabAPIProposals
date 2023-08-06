// открывает указанный скрипт 
// scriptName - имя скрипта
// bool - возвращает True если скрипт найден, False - если скрипт найти не удалось
bool Сontext.OpenScript(string scriptName){}

// закрывает указанный скрипт
// scriptName - имя скрипта
// bool - возвращает True если скрипт найден, False - если скрипт найти не удалось
bool Сontext.CloseScript(string scriptName){}

// закрывает все открытые скрипты
bool Сontext.CloseAllScripts(){}

// возвращает коллекцию имен открытых скриптов
IEnumerable<string> GetOpenedScriptsInfo(){}
