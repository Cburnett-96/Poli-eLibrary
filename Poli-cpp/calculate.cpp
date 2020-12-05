// dllmain.cpp : Defines the entry point for the DLL application.
#include "pch.h"
#include <stdio.h>

extern "C"
{
	int rate = 2;

	__declspec(dllexport) int date(int days, int l)
	{
		
		return days = rate * days + l;
	}
}