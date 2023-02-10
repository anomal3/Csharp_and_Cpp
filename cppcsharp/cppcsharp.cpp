#include "pch.h"
#include "cppcsharp.h"

#include <stdio.h>
#include <iostream>

using namespace std;
extern "C"
{
    __declspec(dllexport) void DisplayHello()
    {
        setlocale(LC_ALL, "Rus");
        printf("Hello, this is DLL на языке c++\n");
    }

    __declspec(dllexport) void Multyply(float a, float b)
    {
        float c = a * b;
        cout << "Ваш ответ из c++ " << c << endl;
    }
}
