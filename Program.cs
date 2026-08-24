//** This is a solution
//** Much like alcohol
//** It hurts the head

int stoneGameVIII(int* stones, int stonesSize)
{
    long long prefix = 0;
    long long* prefixSum = malloc(sizeof(long long) * stonesSize);

    for (int i = 0; i < stonesSize; i++)
    {
        prefix += stones[i];
        prefixSum[i] = prefix;
    }

    long long best = prefixSum[stonesSize - 1];

    for (int i = stonesSize - 2; i >= 1; i--)
    {
        long long current = prefixSum[i] - best;

        if (current > best)
        {
            best = current;
        }
    }

    free(prefixSum);

    return (int)best;
}