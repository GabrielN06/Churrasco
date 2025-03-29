double carne, acompanhamentos, cerveja, refrigerante, agua;
 

Console.Write("Digite a quantidade de adultos que bebem cerveja: ");
int adultosAlcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a quantidade de adultos que não consomem bebidas alcoólicas: ");
int adultos = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a quantidade de crianças: ");
int crianças= Convert.ToInt32(Console.ReadLine());

Console.Clear();

carne = (adultos + adultosAlcool * 0.4) + (crianças * 0.2);
acompanhamentos = (adultos * 0.2) + (crianças * 0.2);
cerveja = (adultosAlcool * 2);
refrigerante = (adultos * 0.5) + (crianças * 0.5);
agua = (adultos * 0.4) + (crianças * 0.4);



Console.WriteLine("--- Churrasco ---");

Console.WriteLine($"Adultos (que consomem bebidas alcoólicas).......: {adultosAlcool} ");
Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas)...: {adultos} ");
Console.WriteLine($"Crianças........................................: {crianças}");

Console.WriteLine($"Carne.............: {carne}");
Console.WriteLine($"Acompanhamentos...: {acompanhamentos:f2}");
Console.WriteLine($"Cerveja...........: {cerveja}");
Console.WriteLine($"Refrigerante......: {refrigerante}");
Console.WriteLine($"agua..............: {agua:f2}");

