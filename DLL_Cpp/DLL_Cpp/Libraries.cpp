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
#include <vector>

#pragma comment (lib, "comsuppw.lib" )

HWND AppHwnd;

void __stdcall SetHwnd(HWND hwnd) {
    AppHwnd = hwnd;
    PostMessage(AppHwnd, WM_USER, 55, 55);
}

HWND __stdcall GetHwnd() {
    return AppHwnd;
}



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

int GetValuesAmount(std::string str) {
    std::stringstream strstream(str);
    std::string segment;
    int i{ 0 };
    while (getline(strstream, segment, '\t'))
        i++;
    return i;
}

HRESULT __stdcall ReadTextFileCPP(LPCWSTR FileName, BSTR* Text, int& Count) {  // This function reads text file
    try
    {
        std::string line;
        std::string content{ "" };
        std::ifstream in(FileName);
        int Count3{ 0 };
        //PostMessage(AppHwnd, 50, 0, 0);
        if (in.is_open()) {
            while (getline(in, line)) {
                if (GetNumbersAmount(line) >= 2) {
                    content.append(line + "\n");
                    Count3++;
                }
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

double** GetConvertedArrayFromFile(LPCWSTR FileName, int& Row, int& Col) {
    std::ifstream in(FileName);
    if (!in.is_open()) { return 0; }
    std::string segmentLine;
    std::string content{ "" };
    getline(in, segmentLine);
    Row = GetValuesAmount(segmentLine);
    int Count{ 0 };
    BSTR Text; //table
    ReadTextFileCPP(FileName, &Text, Count);
    Col = Count;

    double** arrFile = new double* [Row];
    for (int i = 0; i < Row; i++)
        arrFile[i] = new double[Col];
    for (int i = 0; i < Row; i++) {
        for (int j = 0; j < Col; j++) {
            arrFile[i][j] = -1;
        }
    }
    int i{ 0 };
    while (getline(in, segmentLine)) {
        if (GetNumbersAmount(segmentLine) >= 2) {
            std::stringstream strstream(segmentLine);
            std::string segmentNumber;
            int j{ 0 };
            while (getline(strstream, segmentNumber, '\t')) {
                arrFile[i][j] = std::stod(segmentNumber);
                j++;
            }
            i++;
        }
    }
    return arrFile;
}
HRESULT __stdcall GetGraphicCPP(LPCWSTR FileName, int Width, int Height, HBITMAP* MyBmb) {
    try
    {
        unsigned short int pixelScale{ 100 }; //solving fractional numbers 
        HDC winDC{ GetDC(NULL) };
        HDC hdc{ CreateCompatibleDC(winDC) };
        HBITMAP bitmap{ CreateCompatibleBitmap(hdc, Width, Height) };
        SelectObject(hdc, bitmap);
        HPEN pen{ CreatePen(PS_SOLID, 0, RGB(255, 255, 255)) };
        SelectObject(hdc, pen);
        int Row{ 0 }, Col{ 0 };
        double** arrTable;
        arrTable = GetConvertedArrayFromFile(FileName, Row, Col);
        for (int i = 1; i < Row; i++) {
            int x{ static_cast<int>(arrTable[i][0] * pixelScale) };
            for (int j = 1; j < Col; j++) {
                if (arrTable[i][j] == -1) { break; }
                int lastValidIndex{ i };
                for (lastValidIndex = i - 1; lastValidIndex >= 0; --lastValidIndex) {
                    if (arrTable[lastValidIndex][j] != (-1)) {
                        break;
                    }
                }
                int xPrev{ static_cast<int>(arrTable[lastValidIndex][0] * pixelScale) };
                int yPrev{ static_cast<int>(arrTable[lastValidIndex][j] * pixelScale) };
                int y{ static_cast<int>(arrTable[i][j] * pixelScale) };
                MoveToEx(hdc, xPrev, Height - yPrev, NULL);
                LineTo(hdc, x, Height - y);
            }
        }
        *MyBmb = bitmap;
        return 0;
    }
    catch (...)
    {
        return -1;
    }
}

HRESULT __stdcall PointsFromTsvToXml(LPCWSTR FileName, BSTR * Xml) {
    try
    {
        std::string line;
        std::string lineXml;
        std::string content{ "" };
        std::ifstream in(FileName);
        int commentIndex{ 1 };
        content.append("<points>\n");

        if (!in.is_open()) { return -1; }
        getline(in, line);
        content.append("<comment index = '" + std::to_string(commentIndex) + "'>" + line + "</comment>\n");

        while (getline(in, line)) {
            if (GetNumbersAmount(line) >= 2) {
                content.append("<point>\n");
                std::stringstream strstream(line);
                std::string segmentNumber;
                getline(strstream, segmentNumber, '\t');
                content.append("\t<x>" + segmentNumber + "</x>\n");
                int i{ 1 };
                while (getline(strstream, segmentNumber, '\t')) {
                    content.append("\t<y index='" + std::to_string(i) + "'>" + segmentNumber + "</y>\n");
                    i++;
                }
                content.append("</point>\n");
            }
            content.append("\n");
        }

        content.append("</points>\n");
        in.close();

        std::wstring constent_ws{ content.begin(), content.end() };
        *Xml = SysAllocString(&constent_ws[0]);
        return 0;
    }
    catch (...)
    {
        return -1;
    }
}

//test
