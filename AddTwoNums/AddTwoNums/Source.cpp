#include <utility>
#include "pch.h"

extern "C"
{
    __declspec(dllexport) int __stdcall Add1(int val1, int val2) //экспорт dll библиотеки
    {
        return val1 + val2;
    }
}
