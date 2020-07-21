#ifndef _IMAGETRANS_
#define _IMAGETRANS_
#pragma once
#include "opencv2/opencv.hpp"
using namespace std;
using namespace cv;

extern "C"
{
	__declspec(dllexport) void _stdcall ImageProcess(unsigned char * src, int width, int height, int step);
}


class imageTrans
{
public:
	imageTrans();
	~imageTrans();
};
#endif
