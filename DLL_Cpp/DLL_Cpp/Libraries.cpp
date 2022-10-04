#include <utility>
#include "pch.h"
#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
#include "Libraries.h"
#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
#include <Windows.h>
#include <comutil.h>
#include <stdio.h>

#pragma comment (lib, "comsuppw.lib" )

int __stdcall AddCPP(int val1, int val2) { // ф-у¤ сложени¤ двух чисел
	return val1 + val2;
}

bool __stdcall IsNumber(std::string str) {
    for (char c : str)
    {
        if (!isdigit(c) && c != '.') {
            return false;
        }
    }
    return true;
}

int __stdcall GetNumbersAmount(std::string str) {
    std::stringstream strstream(str);
    std::string segment;
    int i{ 0 };
    while (getline(strstream, segment, '\t')) {
        if (IsNumber(segment))
            i++;
        else
            return 0;
    }
    return i;
}


HRESULT __stdcall ReadTextFileCPP(LPCWSTR FileName, BSTR* Text, int& Count) {
    try
    {
        std::string line;
        std::string content{ "" };
        std::ifstream in(FileName);
        int Count3{ 0 };
        if (in.is_open()) {
            while (getline(in, line)) {
                content.append(line);
                if (GetNumbersAmount(line) >= 2)
                    Count3++;
            }
        }
        int* Count2 = &Count;
        *Count2 = Count3;
        in.close();
        std::wstring constent_ws{ content.begin(), content.end() };
        *Text = SysAllocString(&constent_ws[0]);
        return 0;
    }
    catch (...)
    {
        return -1;
    }
}