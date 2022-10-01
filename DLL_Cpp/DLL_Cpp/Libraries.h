#pragma once
#include <string>

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

extern "C" __declspec(dllexport) int __stdcall Add1(int val1, int val2);

extern "C" __declspec(dllexport) int __stdcall ReadTextFile(LPCWSTR FileName);

extern "C" __declspec(dllexport) BSTR __stdcall GetFileContent(LPCWSTR FileName);

extern "C" __declspec(dllexport) bool __stdcall is_number(std::string str);

extern "C" __declspec(dllexport) int __stdcall get_numbers_amount(std::string str);

extern "C" __declspec(dllexport) HRESULT __stdcall GetFileContentNew(LPCWSTR FileName, BSTR * Text, int& Count);