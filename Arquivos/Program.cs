using static System.Console;

WriteLine("Digite o nome do arquivo: ");
var nome = ReadLine();
foreach (var @char in Path.GetInvalidFileNameChars())
{
    nome = nome.Replace(@char, '-');
}

var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");
CriarArquivo(path);

static void CriarArquivo(string path)
{
    try
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Esta é a linha 1 do arquivo");
        sw.WriteLine("Esta é a linha 2 do arquivo");
        sw.WriteLine("Esta é a linha 3 do arquivo");
    }
    catch 
    {
        
        WriteLine("O nome do arquivo está inválido");
    }
}