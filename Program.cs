double carne, acompanhamentos, cerveja, refrigerante, agua;
 

Console.Write("Digite a quantidade de adultos que consomem bebida alcoólicas: ");
int adultosAlcool = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a quantidade de adultos que não consomem bebidas alcoólicas: ");
int adultos = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite a quantidade de crianças: ");
int crianças= Convert.ToInt32(Console.ReadLine());

Console.Clear();

carne = ((adultos + adultosAlcool) * 0.4) + (crianças * 0.2);
acompanhamentos = ((adultos + adultosAlcool) * 0.2) + (crianças * 0.2);
cerveja = (adultosAlcool * 2);
refrigerante = (adultos * 0.5) + (crianças * 0.5);
agua = ((adultos + adultosAlcool) * 0.4) + (crianças * 0.4);



Console.WriteLine("--- Churrasco ---");

Console.WriteLine($"Adultos (que consomem bebidas alcoólicas).......: {adultosAlcool} ");
Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas)...: {adultos} ");
Console.WriteLine($"Crianças........................................: {crianças}");

Console.WriteLine($"\nCarne.............: {carne:f1}kg");
Console.WriteLine($"Acompanhamentos...: {acompanhamentos:f1}kg");
Console.WriteLine($"Cerveja...........: {cerveja:f1}l");
Console.WriteLine($"Refrigerante......: {refrigerante:f1}l");
Console.WriteLine($"Água..............: {agua:f1}l");

