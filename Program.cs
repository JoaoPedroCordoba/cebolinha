// string onde vc classifica uma variavel
string frase;

Console.WriteLine("Por favor, escreva uma frase");
frase = Console.ReadLine()!;


string novafrase = frase
.Replace("r", "l"!)
.Replace("R", "L"!);

Console.WriteLine(novafrase);



