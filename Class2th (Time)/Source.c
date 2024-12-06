#include <stdio.h>
#include <stdlib.h>
#include <time.h>

#define SIZE 10

void Shuffle(int array[], int size)
{
	for (int i = 0; i < size; i++)
	{
		int seed = rand() % size;

		int temporary = array[seed];

		array[seed] = array[i];

		array[i] = temporary;
	}
}

int main()
{
#pragma region 셔플 함수

	//	srand(time(NULL));
	//	
	//	int list[10] = { 1, 2, 3, 4, 5, 6, 7, 8 ,9 ,10 };
	//	
	//	int size = sizeof(list) / sizeof(int);
	//	
	//	Shuffle(list, size);
	//	
	//	for (int i = 0; i < size; i++)
	//	{
	//		printf("list[%d]의 값 : %d\n", i, list[i]);
	//	}

#pragma endregion

#pragma region rand 함수
// 0 ~ 32767 사이의 난수 값을 반환하는 함수입니다.

// UTC 기준으로 1970년 1월 1일 0시 0분 0초부터 경과된
// 시간을 초(sec)로 반환하는 함수입니다.
// srand(time(NULL));
// 
// int random = rand() % 10 + 1;
// 
// printf("random 변수의 값 : %d\n", random);

#pragma endregion

#pragma region clock 함수

	clock_t start = clock(); // 시작 시간 저장

	for (int i = 0; i < 1000; ++i) 
	{
		for (int j = 0; j < 1000; ++j)
		{
			
		}
	}

	clock_t end = clock(); // 코드가 끝난 시간 저장

	// 걸린 시간 출력
	// 단위: 초(second)
	// CLOCKS_PER_SEC로 나눠줘야 초단위로 나옵니다.
	printf("Time: %lf\n", (double)(end - start) / CLOCKS_PER_SEC);
#pragma endregion


#pragma region UP - DOWN 게임

	srand(time(NULL));

	int computer = rand() % 50 + 1;

	int answer = 0;

	int life = 5;

	while (life > 0)
	{
		printf("Life : %d\n", life);
		printf("Computer가 가지고 있는 값 : ");
		scanf_s("%d", &answer);

		printf("\n");

		if (answer == computer)
		{
			printf("컴퓨터가 가지고 있는 값을 맞추었습니다.\n");
			break;
		}
		else if (answer > computer)
		{
			life--;
			printf("Computer가 가지고 있는 값보다 큽니다.\n");
		}
		else if (answer < computer)
		{
			life--;
			printf("Computer가 가지고 있는 값보다 작습니다.\n");
		}

		printf("\n");
	}

	if (life <= 0)
	{
		printf("Defeat\n");
	}
	else
	{
		printf("Victory\n");
	}


#pragma endregion

	return 0;
}