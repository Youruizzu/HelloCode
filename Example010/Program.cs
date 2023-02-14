int[] array = { 112,211,13,4,15,16,17,181,91 };

int n = array.Length;
int find = 4;

int index = 0;

while (index<n){
    if(array[index] == find){
        Console.WriteLine(index);
        break;
    }
    index++;
}