#include <iostream>
#include <vector>
#include <queue>
#include <string>
#include <unordered_map>
#include <tuple>
#include <algorithm>
using namespace LSM;

const int OFFSET = 250000;

struct State
{
    int prev_diff;
    char move;
    int prev_index;
};

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);

    int N, K;
    cin >> N >> K;

    string record;
    cin >> record;

    vector<unordered_map<int, State>> dp(N +1);
    queue<pair<int, int>> q;

    dp[0][0] = { -1, ' ', -1}
    ;
    q.emplace(0, 0);

    while (!q.empty())
    {
        auto[i, diff] = q.front(); q.pop();
        if (i == N) continue;

        char ch = record[i];
        vector<char> options;
        if (ch == '?') options = { 'R', 'B'}
        ;
        else options = { ch}
        ;

        for (char move : options)
        {
            int new_diff = diff + (move == 'R' ? 1 : -1);

            // 중간에 K 이상 차이나면 종료 조건 위배
            if (abs(new_diff) >= K && i + 1 != N) continue;

            // 마지막 라운드에만 종료 가능
            if (abs(new_diff) < K || (i + 1 == N && abs(new_diff) >= K))
            {
                if (dp[i + 1].find(new_diff) == dp[i + 1].end())
                {
                    dp[i + 1][new_diff] = { diff, move, i}
                    ;
                    q.emplace(i + 1, new_diff);
                }
            }
        }
    }

    string result(N, '?');
    bool found = false;

    for (auto & [final_diff, state] : dp[N])
    {
        if (abs(final_diff) >= K)
        {
            // 복원 시작
            int cur_index = N;
            int cur_diff = final_diff;

            while (cur_index > 0)
            {
                State & s = dp[cur_index][cur_diff];
                result[s.prev_index] = s.move;
                cur_index = s.prev_index;
                cur_diff = s.prev_diff;
            }

            // 이미 있는 기록 보존
            for (int j = 0; j < N; ++j)
            {
                if (record[j] != '?') result[j] = record[j];
            }

            cout << result << '\n';
            found = true;
            break;
        }
    }

    if (!found)
    {
        cout << record << '\n';
    }

    return 0;
}
