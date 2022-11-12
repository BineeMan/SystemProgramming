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

extern "C" __declspec(dllexport) void __stdcall SetHwnd(HWND hwnd);

extern "C" __declspec(dllexport) int __stdcall AddCPP(int val1, int val2);

extern "C" __declspec(dllexport) HRESULT __stdcall ReadTextFileCPP(LPCWSTR FileName, BSTR * Text, int& Count);

extern "C" __declspec(dllexport) HRESULT GetGraphicCPP(LPCWSTR FileName, int Width, int Height, HBITMAP * MyBmb);

extern "C" __declspec(dllexport) HRESULT PointsFromTsvToXml(LPCWSTR FileName, BSTR * Xml);