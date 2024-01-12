/// <summary>
/// <숫자 비교하기>
/// [문제 설명]
/// 정수 num1과 num2가 매개변수로 주어집니다. 두 수가 같으면 1 다르면 -1을 return하도록 solution 함수를 완성해주세요.
/// [제한 사항]
/// 0 ≤ num1 ≤ 10,000
/// 0 ≤ num2 ≤ 10,000
/// </summary>

//#define sol_01
#define sol_02

#if sol_01
using System;

public class Solution {
    public int solution(int num1, int num2) {
        int answer = 0;

        if(num1 >= 0 && num1 <=10000 && num2 >= 0 && num2 <= 10000) {
            if(num1 == num2) {
                answer = 1;
            } else {
               answer = -1; 
            }            
        }

        return answer;
    }
}

#elif sol_02
using System;

public class Solution
{
    public int solution(int num1, int num2)
    {
        int answer = 0;

        if (num1 >= 0 && num1 <= 10000 && num2 >= 0 && num2 <= 10000)
        {
            answer = num1 == num2 ? 1 : -1;
        }

        return answer;
    }
}
#endif