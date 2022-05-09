#include "pch.h"
#include "serialParams.h"
#include "ecode.h"

#include <string>

win_serial::win_serial()
{

}

win_serial::~win_serial()
{

}

/*
//
// Baud rates at which the communication device operates
//

#define CBR_110             110
#define CBR_300             300
#define CBR_600             600
#define CBR_1200            1200
#define CBR_2400            2400
#define CBR_4800            4800
#define CBR_9600            9600
#define CBR_14400           14400
#define CBR_19200           19200
#define CBR_38400           38400
#define CBR_56000           56000
#define CBR_57600           57600
#define CBR_115200          115200
#define CBR_128000          128000
#define CBR_256000          256000
*/
int win_serial::baudrate(int siCSValue)
{
	int rc = siCSValue;									// ‰¼Œˆ‚ß

	switch (siCSValue) {
	case CBR_110:
	case CBR_300:
	case CBR_600:
	case CBR_1200:
	case CBR_2400:
	case CBR_4800:
	case CBR_9600:
	case CBR_14400:
	case CBR_19200:
	case CBR_38400:
	case CBR_56000:
	case CBR_57600:
	case CBR_115200:
	case CBR_128000:
	case CBR_256000:
		break;
	default:
		rc = RET_FAILED;
		break;
	}
	return rc;
}

int win_serial::databites(int siCSValue)
{
	return siCSValue;
}

/*
#define ONESTOPBIT          0
#define ONE5STOPBITS        1
#define TWOSTOPBITS         2
*/
int win_serial::stopbits(char* pCSValue, size_t szSize)
{
	int rc;
	std::string str_wk;

	str_wk = pCSValue;
	if (str_wk == "1.5") {
		rc = ONE5STOPBITS;
	}
	else if ((str_wk == "1.0") || (str_wk == "1")) {
		rc = ONESTOPBIT;
	}
	else if ((str_wk == "2.0") || (str_wk == "2")) {
		rc = TWOSTOPBITS;
	}
	else {
		rc = RET_FAILED;
	}
	return rc;
}

/*
#define NOPARITY            0
#define ODDPARITY           1
#define EVENPARITY          2
#define MARKPARITY          3
#define SPACEPARITY         4
*/
int win_serial::parity(char* pCSValue, size_t szSize)
{
	int rc;
	std::string str_wk;

	str_wk = pCSValue;
	if (str_wk == "none") {
		rc = NOPARITY;
	}
	else if (str_wk == "odd") {
		rc = ODDPARITY;
	}
	else if (str_wk == "even") {
		rc = EVENPARITY;
	}
	else if (str_wk == "mark") {
		rc = MARKPARITY;
	}
	else if (str_wk == "space") {
		rc = SPACEPARITY;
	}
	else {
		rc = RET_FAILED;
	}
	return rc;
}

/*
//
// DTR Control Flow Values.
//
#define DTR_CONTROL_DISABLE    0x00
#define DTR_CONTROL_ENABLE     0x01
#define DTR_CONTROL_HANDSHAKE  0x02
*/
int win_serial::dtrFlow(int siCSValue)
{
	int rc = siCSValue;									// ‰¼Œˆ‚ß

	switch (siCSValue) {
	case DTR_CONTROL_DISABLE:
	case DTR_CONTROL_ENABLE:
	case DTR_CONTROL_HANDSHAKE:
		break;
	default:
		rc = RET_FAILED;
		break;
	}
	return rc;
}

/*
//
// RTS Control Flow Values
//
#define RTS_CONTROL_DISABLE    0x00
#define RTS_CONTROL_ENABLE     0x01
#define RTS_CONTROL_HANDSHAKE  0x02
#define RTS_CONTROL_TOGGLE     0x03
*/
int win_serial::rtsFlow(int siCSValue)
{
	int rc = siCSValue;									// ‰¼Œˆ‚ß

	switch (siCSValue) {
	case RTS_CONTROL_DISABLE:
	case RTS_CONTROL_ENABLE:
	case RTS_CONTROL_HANDSHAKE:
	case RTS_CONTROL_TOGGLE:
		break;
	default:
		rc = RET_FAILED;
		break;
	}
	return rc;

}
