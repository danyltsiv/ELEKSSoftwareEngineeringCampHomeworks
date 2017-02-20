#include <iostream>
#include <ctime>
using namespace std;
int main(int argc, char** argv)
{
	srand(time(NULL));
	if (argc >= 2) {
		cout << "Hello ";
		for (int i = 1; i < argc; i++) {
			cout << argv[i] << " ";
		}
		cout <<"!"<< endl;
	}
	else cout << "Hello guest!" << endl;

	cout << "Ya zagadav chyslo vid 0 do 99, sprobuy vidgadaty!" << endl;
	unsigned short x, y;
	x = rand() % 100;
	int raziv = 0;
	bool nevgadav = true;
	while (nevgadav)
	{
		cin >> y;
		if (x>y) cout << "Moye chyslo bilshe" << endl;
		else if (x < y) cout << "Moye chyslo menshe" << endl;
		else { cout << "Vgadav!!" << endl; nevgadav = false; }
		raziv++;
	}
	cout << "Ti vgaduvav " << raziv << " raziv" << endl;
	system("pause");
}

