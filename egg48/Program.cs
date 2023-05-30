unsafe
{
    int[][] A = new int[3][];
	int*[] pointers = new int*[3];
	for (int i = 0; i < 3; i++)
	{
        A[i] = new int[4];
        fixed (int* temp = A[i])
			pointers[i] = temp;
	}
	fixed(int** p = pointers)
	{
		p[2][1] = 3;
		Console.WriteLine(A[2][1]);
        p[2][1] = 0;
    }
	fixed(int* p = A[2])
	{
		p[1] = 3;
		Console.WriteLine(A[2][1]);
        p[1] = 0;
    }
    fixed (int* p = &A[2][1])
	{
		*p = 3;
		Console.WriteLine(A[2][1]);
	}
}