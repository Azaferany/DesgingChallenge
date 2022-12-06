var list = new List<int>(){1,5,7,14};
int expectedSum = 8;

var sumExist = FindSum(list, expectedSum);
    
Console.WriteLine(sumExist);

(int x,int y) FindSum(List<int> list, int sum)
{
    list.Sort();
    
    var column = 0;
    var row = list.Count - 1;
    
    while (column < row) {
        
        if (list[column] + list[row] == sum)
            return (list[column],list[row]);
        
        else if (list[column] + list[row] < sum)
            column++;
        
        else
            row--;
    }

    return (-1, -1);
}