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
#pragma comment (lib, "comsuppw.lib" )

int __stdcall Add1(int val1, int val2) { // ф-у¤ сложени¤ двух чисел
    return val1 + val2;
}

bool __stdcall is_number(std::string str) {
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
        if (is_number(segment))
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
#include "wingdi.h"
#include <vector>


//HRESULT GetGraphic(LPCWSTR FileName, int Width, int Height, HBITMAP* Picture) {}

int main() {
    int Width{ 500 }, Height{ 500 };
    LPCWSTR FileName{ L"E:\\SystemProgramming\\Files\\test.tsv" };
    unsigned short int pixelScale{ 100 }; //solving fractional numbers 
    //Preparation for drawing
    HDC winDC{ GetDC(NULL) };
    HDC hdc{ CreateCompatibleDC(winDC) };
    /*Функция CreateCompatibleDC создает контекст
    устройства памяти (DC), совместимый с указанным
    устройством.*/
    HBITMAP bitmap{ CreateCompatibleBitmap(hdc, Width, Height) };
    /*Функция CreateCompatibleBitmap создает растровое
    изображение, совместимое с устройством, связанным
    с указанным контекстом устройства.*/
    SelectObject(hdc, bitmap);
    /*Функция SelectObject выбирает объект в указанном
    контексте устройства (DC). Новый объект заменяет
    предыдущий объект того же типа.*/
    HPEN pen{ CreatePen(PS_SOLID, 0, RGB(255, 255, 255)) };
    SelectObject(hdc, pen);
    BSTR Text; //table
    int Count{ 0 };
    ReadTextFileCPP(FileName, &Text, Count); //getting a table from .tsv file
    std::wstring ws(Text, SysStringLen(Text)); //getting wstring from BSTR
    std::string str(ws.begin(), ws.end()); //getting string from wstring
    std::stringstream strstream1(str);
    std::string segmentLine;
    int k{ 0 };
    int lineAmountPrev{ -1 };
    int* arrPrev = new int[4];

    int* arr = new int[4];
    for (int i{ 0 }; i < 4; i++) { arrPrev[i] = 0; arr[i] = 0; }
    while (getline(strstream1, segmentLine, '\n')) { //reads line one by one
        std::stringstream strstream2(segmentLine);
        std::string segmentNumber;
        getline(strstream2, segmentNumber, '\t'); //get first number in line
        int lineNumberAmount{ GetNumbersAmount(segmentLine) };
        if (lineAmountPrev == -1) {
            //int* arrPrev = new int[lineNumberAmount];
            for (int i{ 0 }; i < lineNumberAmount; i++) { arrPrev[i] = 0;  std::cout << "-1 " << arr[i] << std::endl; }
            lineAmountPrev = lineNumberAmount;
        }
        else if (lineAmountPrev < lineNumberAmount) {
            //int* arrPrev = new int[lineNumberAmount];
            for (int i{ 0 }; i < lineNumberAmount; i++) { arrPrev[i] = arr[i]; std::cout << "< " << arr[i] << std::endl; }
            lineAmountPrev = lineNumberAmount;
        }
        else if (lineAmountPrev >= lineNumberAmount) {
            for (int i{ 0 }; i < lineNumberAmount; i++) { arrPrev[i] = arr[i]; std::cout << ">= " << arr[i] << std::endl; }
            lineAmountPrev = lineNumberAmount;
        }
        //delete[] arr;
        //int* arr = new int[lineNumberAmount];
        arr[0] = static_cast<int>(std::stod(segmentNumber) * pixelScale);
        int i{ 1 };
        while (getline(strstream2, segmentNumber, '\t')) { //reads remaining numbers from line one by one, use them as y values
            arr[i] = static_cast<int>(std::stod(segmentNumber) * pixelScale);
            std::cout << "X_prev: " << arrPrev[0] << "   Y_prev" << i << ": " << arrPrev[i] << std::endl;
            std::cout << "X_curr: " << arr[0] << "   Y_curr" << i << ": " << arr[i] << std::endl;
            MoveToEx(hdc, arrPrev[0], abs(arrPrev[i] - Height), NULL);
            LineTo(hdc, arr[0], abs(arr[i] - Height));
            i++;
        }
        std::cout << std::endl;
    }

}
