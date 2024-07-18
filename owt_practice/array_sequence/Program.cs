int[] sequencearray = [40, 30, 10, 70];

for (int i = 0,j=1; j < sequencearray.Length; i++ , j++)
{
    for (int k = i,l=j; k < sequencearray.Length; k-- , l--)
    {
        if (sequencearray[k] > sequencearray[l])
        {
            int numbertemp = sequencearray[k];
            sequencearray[k] = sequencearray[l];
            sequencearray[l] = numbertemp;          
           
        }
        
    }
}

for (int i = 0; i < sequencearray.Length; i++)
{
    Console.WriteLine(sequencearray[i]);
}