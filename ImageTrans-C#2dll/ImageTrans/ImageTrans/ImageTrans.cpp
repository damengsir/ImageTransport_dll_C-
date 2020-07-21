// ImageTrans.cpp : 定义 DLL 应用程序的导出函数。
//

#include "stdafx.h"
#include "ImageTrans.h"

imageTrans::imageTrans()
{
}

imageTrans::~imageTrans()
{
}

Mat WaterMark(Mat img)
{
	IplImage* pBinary = &IplImage(img);//浅拷贝
	IplImage *input = cvCloneImage(pBinary);//深拷贝只要再加一次复制数据

	SYSTEMTIME systemTime;
	GetLocalTime(&systemTime);
	std::stringstream watermark;

	watermark << systemTime.wYear << "-"
		<< std::setw(2) << std::setfill('0') << systemTime.wMonth << "-"
		<< std::setw(2) << std::setfill('0') << systemTime.wDay << " "
		<< std::setw(2) << std::setfill('0') << systemTime.wHour << ":"
		<< std::setw(2) << std::setfill('0') << systemTime.wMinute << ":"
		<< std::setw(2) << std::setfill('0') << systemTime.wSecond;

	CvFont font;
	cvInitFont(&font, CV_FONT_VECTOR0, 4, 4, 0, 6, 8);
	cvPutText(input, watermark.str().c_str(), cvPoint(100, 150), &font, cvScalar(255, 255, 255, NULL));


	Mat dstImage = cvarrToMat(input);
	return dstImage;
}

void ImageProcess(unsigned char * src, int width, int height, int step)
{
	//生成opencv图像类
	Mat img(height, width, CV_8UC3, src, step);

	img = WaterMark(img);
	

	//处理代码段
	memcpy(src, img.data, sizeof(unsigned char)*img.rows*img.cols*img.channels());


	//指针数据复制
	img.release(); //释放内存(其实不用)
}



