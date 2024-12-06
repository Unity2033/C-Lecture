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
#pragma region ���� �Լ�

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
	//		printf("list[%d]�� �� : %d\n", i, list[i]);
	//	}

#pragma endregion

#pragma region rand �Լ�
// 0 ~ 32767 ������ ���� ���� ��ȯ�ϴ� �Լ��Դϴ�.

// UTC �������� 1970�� 1�� 1�� 0�� 0�� 0�ʺ��� �����
// �ð��� ��(sec)�� ��ȯ�ϴ� �Լ��Դϴ�.
// srand(time(NULL));
// 
// int random = rand() % 10 + 1;
// 
// printf("random ������ �� : %d\n", random);

#pragma endregion

#pragma region clock �Լ�

	clock_t start = clock(); // ���� �ð� ����

	for (int i = 0; i < 1000; ++i) 
	{
		for (int j = 0; j < 1000; ++j)
		{
			
		}
	}

	clock_t end = clock(); // �ڵ尡 ���� �ð� ����

	// �ɸ� �ð� ���
	// ����: ��(second)
	// CLOCKS_PER_SEC�� ������� �ʴ����� ���ɴϴ�.
	printf("Time: %lf\n", (double)(end - start) / CLOCKS_PER_SEC);
#pragma endregion


#pragma region UP - DOWN ����

	srand(time(NULL));

	int computer = rand() % 50 + 1;

	int answer = 0;

	int life = 5;

	while (life > 0)
	{
		printf("Life : %d\n", life);
		printf("Computer�� ������ �ִ� �� : ");
		scanf_s("%d", &answer);

		printf("\n");

		if (answer == computer)
		{
			printf("��ǻ�Ͱ� ������ �ִ� ���� ���߾����ϴ�.\n");
			break;
		}
		else if (answer > computer)
		{
			life--;
			printf("Computer�� ������ �ִ� ������ Ů�ϴ�.\n");
		}
		else if (answer < computer)
		{
			life--;
			printf("Computer�� ������ �ִ� ������ �۽��ϴ�.\n");
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