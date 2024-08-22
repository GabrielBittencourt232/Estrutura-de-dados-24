
using NovoProjetoAula02;

Console.WriteLine("Hello, World!");

// new TipoEnumerador() -> Invoca o método construtor do objeto
// Toda classe tem o seu construtor padrão implicito sem argumentos/params
// É possível sobrescrever este método especificando argumentos 
// Todavia, se o fizermos, perdemos o original implícito e 
// precisaremos defini-lo explicitamente
TipoEnumerador tipoEnum = new TipoEnumerador();

TipoEnumerador.Language enumEnglish = tipoEnum.GetLanguageEnum("inglês");
Console.WriteLine($"O enum de english é {enumEnglish}");