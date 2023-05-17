using System;

class Program
{
    public static void Main (string[] args)
{
        Console.WriteLine("Classe Carro Teste\n");
        
        Carro Carro1= new Carro("Corsa Windi", "Chevrolet", "1999", "1998", "Azul", "1.0", "Gasolina");

        Carro Carro2 = new Carro("Opala Diplomata", "Chevrolet", "1969", "1968", "Verde", "2.8", "Flex");

        Carro Carro3 = new Carro("Evoque", "Land Rover", "2021", "2020", "Vermelho", "2.4", "Disel");

        Console.WriteLine("Marca do Carro:" + Carro1.Marca);
        Console.WriteLine("Modelo do Carro:" + Carro1.Modelo);
        Console.WriteLine("Ano do Modelo:" + Carro1.Ano1);
        Console.WriteLine("Ano de Fabricação:" + Carro1.Ano2);
        Console.WriteLine("Cor Predominante:" + Carro1.Cor);
        Console.WriteLine("Potencia do Motor:" + Carro1.Potencia);
        Console.WriteLine("Tipo de Combustivel:" + Carro1.Combustivel);
        Console.WriteLine("   ");  
        Console.WriteLine("Marca do Carro:" + Carro2.Marca);
        Console.WriteLine("Modelo do Carro:" + Carro2.Modelo);
        Console.WriteLine("Ano do Modelo:" + Carro2.Ano1);
        Console.WriteLine("Ano de Fabricação:" + Carro2.Ano2);
        Console.WriteLine("Cor Predominante:" + Carro2.Cor);
        Console.WriteLine("Potencia do Motor:" + Carro2.Potencia);
        Console.WriteLine("Tipo de Combustivel:" + Carro2.Combustivel);
        Console.WriteLine("   ");
        Console.WriteLine("Marca do Carro:" + Carro3.Marca);
        Console.WriteLine("Modelo do Carro:" + Carro3.Modelo);
        Console.WriteLine("Ano do Modelo:" + Carro3.Ano1);
        Console.WriteLine("Ano de Fabricação:" + Carro3.Ano2);
        Console.WriteLine("Cor Predominante:" + Carro3.Cor);
        Console.WriteLine("Potencia do Motor:" + Carro3.Potencia);
        Console.WriteLine("Tipo de Combustivel:" + Carro3.Combustivel);



    }

}

class Carro
{
    public string Marca;
    public string Modelo;
    public string Ano1;
    public string Ano2;
    public string Cor;
    public string Potencia;
    public string Combustivel;

    public Carro(string marca, string modelo, string ano1, string ano2, string cor, string potencia, string combustivel)
    {
        Marca = marca;
        Modelo = modelo;
        Ano1 = ano1;
        Ano2 = ano2;
        Cor = cor;
        Potencia = potencia;
        Combustivel = combustivel;
    }
}
{

using System;

class Program
{
    static void Main(string[] args)
    {
        //acessando os membros herdando a classe parente
        Carro2 child = new Carro2();
        child.getIdFromCarro();
    }
}

class Carro
{
    public string carro;
    public int Id = 9;

    public void displayCarro2()
    {
        Console.WriteLine($"I am {carro}");
        Console.WriteLine($"ID : {Id}");
    }
}
class Carro2 : Carro
{
    public void getIdFromCarro()
    {
        Console.WriteLine($"Esse é meu carro : {Id}");
    }
}

