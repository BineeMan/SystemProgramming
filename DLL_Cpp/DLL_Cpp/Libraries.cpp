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
#include "wingdi.h"
#pragma comment (lib, "comsuppw.lib" )

int __stdcall AddCPP(int val1, int val2) {  // This function adds two numbers
	return val1 + val2;
}

bool __stdcall IsNumber(std::string str) { // This function detects if given string is number
    for (char c : str)
    {
        if (!isdigit(c) && c != '.') {
            return false;
        }
    }
    return true;
} 

int __stdcall GetNumbersAmount(std::string str) { //This function returns the amount of numbers on one line, delimited by tabulation
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

HRESULT __stdcall ReadTextFileCPP(LPCWSTR FileName, BSTR* Text, int& Count) {  // This function reads text file
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
#if 1
HRESULT __stdcall GetBmp(HBITMAP* MyBmb, int Width, int Height, int WidthBytes) {
    try
    {
        BYTE bBytes[] =
        {
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff,
            0xff, 0x00, 0x00, 0xff, 0xff, 0x00, 0x00, 0xff,
            0xff, 0x00, 0x00, 0xff, 0xff, 0x00, 0x00, 0xff,
            0x00, 0xff, 0xff, 0x00, 0x00, 0xff, 0xff, 0x00,
            0x00, 0xff, 0xff, 0x00, 0x00, 0xff, 0xff, 0x00,
            0x00, 0xff, 0xff, 0x00, 0x00, 0xff, 0xff, 0x00,
            0xff, 0x00, 0x00, 0xff, 0xff, 0x00, 0x00, 0xff,
            0xff, 0x00, 0x00, 0xff, 0xff, 0x00, 0x00, 0xff,
            0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff, 0xff
        };
        BITMAP bmp =
        {
            0, Width, Height, WidthBytes, 1, 1, NULL
        };
        bmp.bmBits = (LPSTR)bBytes;
        HBITMAP TempHbmp = CreateBitmapIndirect(&bmp);
        *MyBmb = TempHbmp;
    }
    catch (...)
    {
        return -1;
    }
}
#endif 

#if 0
HRESULT __stdcall GetBmp(HBITMAP* MyBmb, int Width, int Height, int WidthBytes) {
    try
    {
        DWORD type;
        HPEN hpen;
        HBRUSH hbrush;
        HPALETTE hpal;
        HFONT hfont;
        HBITMAP hbmp;
        HRGN hrgn;
        HDC hdc;
        HCOLORSPACE hcs;
        HGDIOBJ hobj;
        LOGBRUSH lb;
        LOGCOLORSPACEA lcs;

        hdc = CreateCompatibleDC(0);
        assert(hdc != 0);

    }
    catch (...)
    {
        return -1;
    }
}

#endif 