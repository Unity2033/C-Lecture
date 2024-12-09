#include <stdio.h>	
#include <windows.h>

enum Color 
{
    BLACK,
    DARKBLUE,
    DARKGREEN,
    DARKSKYBLUE,
    DARKRED,
    DARKVOILET,
    DAKRYELLOW,
    GRAY,
    DARK_GRAY,
    BLUE,
    GREEN,
    SKYBLUE,
    RED,
    VIOLET,
    YELLOW,
    WHITE,
};

void main() 
{
    for (int i = 0; i < 5; i++)
    {
        SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), DARKBLUE + i);

        if (i == 3)
        {
            system("pause");
        }

        printf("현재의 i 값 : %d\n", i);
    }



}