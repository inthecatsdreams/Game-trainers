#include <Windows.h>
#include <iostream>

using namespace std;

int main() {
	int value_i_want = INT_MAX;
	DWORD converted_val = sizeof(value_i_want);
	LPVOID gmp = (LPVOID)0x142c041c8;

	LPCUWSTR gameWindow = L"METAL GEAR SOLID V: THE PHANTOM PAIN";
	HWND hWnd = FindWindow(0, gameWindow);
	DWORD pId;
	if (hWnd == 0) {
		std::cout << "Cannot find window." << std::endl;
		system("pause");
		exit(-1);
	}
	GetWindowThreadProcessId(hWnd, &pId);
	HANDLE hProc = OpenProcess(PROCESS_ALL_ACCESS, FALSE, pId);
	//values that need to be written only once
	WriteProcessMemory(hProc,  gmp, &value_i_want, converted_val, NULL);

	
}