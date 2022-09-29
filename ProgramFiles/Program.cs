string[] inputArray = Console.ReadLine().Split(", ");

int countArray  = 0;

for (int i = 0; i < inputArray.Count(); i++){
    if (inputArray[i].Length <= 3){
        countArray++;
    }
}

string[] resultArray = new String[countArray];
int indexResultArray = 0;
for (int i = 0; i < inputArray.Count(); i++){
    if (inputArray[i].Length <= 3){
        resultArray[indexResultArray] = inputArray[i];
        indexResultArray++;
    }    
} 

Console.WriteLine(String.Join(", ", resultArray));