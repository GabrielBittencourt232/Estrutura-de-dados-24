//criando um vetor multidimensional com 5 linhas e 2 colunas

int[,] numbers = new int [5,2];
// criando um vetor tridimensional

int[,,] trinumbers = new int[5,4,3];
//Podemos inicializar os valores do vetor no momento de sua declaração
int [,] iniNumbers = new int[,]
{
    {9,15,-9},
    {19,25,-90},
    {29,35,-91},
    {39,45,-92},
    {49,55,-93},
};
// Para acessar os valores contidos neste tipo
//tipo de variavel
int valor = iniNumbers[0,1]; //Neste caso = 15

Console.WriteLine( $"iniNumbers[0,1] == {valor}" );