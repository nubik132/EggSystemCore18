unsafe
{
    int* A = stackalloc int[5];
    int* p = A;
    for (int i = 0; i < 5; i++)
    {
        A[i] = i * i;
    }
    p[3] = 4;
    int a = *(p + 3);
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(A[i]);
    }
}