#include "leap.h"
// si %100 == 0 && %400 == 0 || %4 == 0

bool leap_year(int year){
    return (year % 100 == 0) ? year % 400 == 0 : year % 4 == 0 ;
}