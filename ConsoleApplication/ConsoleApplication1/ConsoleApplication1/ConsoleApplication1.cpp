#include <utility>
#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
#include <Windows.h>
#include <comutil.h>
#include <WinUser.h>
#include "wingdi.h"
#include <vector>
#include <array>
#pragma comment (lib, "comsuppw.lib" )

int __stdcall Add1(int val1, int val2) { // ф-у¤ сложени¤ двух чисел
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
    std::cout << Row << " " << Col << std::endl;

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


HRESULT PointsFromTsvToXml(LPCWSTR FileName, BSTR* Xml) {
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
        content.append("<comment index = '"+ std::to_string(commentIndex) + "'>" + line + "</comment>\n");

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

int main() {
    
    LPCWSTR FileName{ L"E:\\SystemProgramming\\Files\\test.tsv" };
    BSTR test;
    PointsFromTsvToXml(FileName, &test);

    //std::string test{ "test" };
    //test.append("<comment index = '" + test + "'>" + "test");
    //std::cout << test;
}
