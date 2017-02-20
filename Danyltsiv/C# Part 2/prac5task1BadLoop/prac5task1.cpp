// Should print 20 "*"
//first
void BadLoop()
{
	int i, N = 20; for (i = 0; i < N; N--) { printf("*"); }
}

//second
void BadLoop()
{
	int i, N = 20; for (i = 0; -i < N;i--) { printf("*"); }
}