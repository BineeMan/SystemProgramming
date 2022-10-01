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
#include <stdio.h>

#pragma comment (lib, "comsuppw.lib" )

#include <iostream>

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

int __stdcall get_numbers_amount(std::string str) {
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

int __stdcall ReadTextFile(LPCWSTR FileName) {
    std::string line;
    std::ifstream in(FileName);
    getline(in, line);
    int row_count{ 0 }, char_count{ 0 };
    int Count{ 0 };
    if (in.is_open()) {
        while (getline(in, line)) {
            if (get_numbers_amount(line) >= 2)
                Count++;
        }
    }
    else {
        in.close();
        return -1;
    }
    in.close();
    return Count;
}

BSTR __stdcall GetFileContent(LPCWSTR FileName) {
    std::string line;
    std::string content{ "" };
    std::ifstream in(FileName);
    if (in.is_open()) {
        while (getline(in, line)) {
            content.append(line);
        }
    }
    in.close();

    //std::wstring constent_ws{ content.begin(), content.end() };
    std::wstring constent_ws{ L"test" };
    BSTR result = SysAllocString(&constent_ws[0]);
    return result;
}

HRESULT GetFileContentNew(LPCWSTR FileName, BSTR* Text, int& Count) {
    try
    {
        std::string line;
        std::string content{ "" };
        std::ifstream in(FileName);
        int Count3{ 0 };
        if (in.is_open()) {
            while (getline(in, line)) {
                content.append(line);
                if (get_numbers_amount(line) >= 2)
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

HRESULT test(int &a) {
    int* b = &a;
    *b = 22;
    return 0;
}

int main() {

    //int a = 1;
    //int *b = &a;
    //*b = 2;
    //std::cout << *b << std::endl;

    //int a = 1;
    //std::cout << a << std::endl;
    //test(a);
    //std::cout << a << std::endl;

    //BSTR bstr = { SysAllocString(L"test") };
    //_bstr_t test = bstr;
    //std::cout << test << std::endl;

    //BSTR* bstr2 = &bstr;
    //*bstr2 = { SysAllocString(L"test2") };
    //
    //test = bstr;
    //std::cout << test << std::endl;

    LPCWSTR FileName { L"G:\\Системное Программирование\\v0.21\\Files\\test.tsv" };

    BSTR Text{ SysAllocString(L"test" )};
    int Count = 0;
    _bstr_t bstr = Text;
    std::cout << Count << std::endl << bstr << std::endl << std::endl;

    GetFileContentNew(FileName, &Text, Count);
    bstr = Text;
    std::cout << Count << std::endl << bstr;

}
