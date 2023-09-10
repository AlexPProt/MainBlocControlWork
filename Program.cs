string[] checkarray = {"Hello","2","world",":-)","++r!"};
  int chekLength=3;
  string[] outarray= new string[checkarray.Length];
  int k=0;
  for (int i=0; i<checkarray.Length; i++)
  if (checkarray[i].Length>=chekLength) {
    outarray[k]=checkarray[i];
    k++;
  }
  if (k==0) Console.WriteLine ("В проверяемом массиве нет элементов удовлетворяющих условиям");
  else
    for (int i=0;i<k;i++){
    Console.WriteLine (outarray[i]);
  }
 
 

