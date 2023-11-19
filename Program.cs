int[] numeros = new int[]{5,7,33,50,2,1,10};

int[] novoNumeros = processaVetor(x => x > 5, numeros);

Console.WriteLine("Vetor");
Console.WriteLine(String.Join(",",numeros));
Console.WriteLine("Novo Vetor");
Console.WriteLine(String.Join(",",novoNumeros));

int[] processaVetor(
    Func<int,bool> maiorQue, 
    int[] vet)
{
    
    int encontrados = 0;
    for(int i = 0; i < vet.Length; i++){
        if(maiorQue(vet[i])){
            encontrados++;
        }
    }
    
    int nArrayCount = 0;
    int[] nArr = new int[encontrados];
    for(int i = 0; i < vet.Length; i++){
        if(maiorQue(vet[i])){
            nArr[nArrayCount] = vet[i];
            nArrayCount++;
        }
    }
    return nArr;
};