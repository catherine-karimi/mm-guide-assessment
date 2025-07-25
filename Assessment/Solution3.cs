namespace Assessment;
public static class Solution3
{
    // Assumptions:
    // 1. The puzzle has an ambiguity; in the description, in a [A, B] pair, B is a prerequisite for A; While in the example, A is a prerequisite for B.
    // My assumption is that the example is correct. Because I run tests based on examples.
    public static int SolvePuzzle3(IEnumerable<Dictionary<char, char>> input)
    {
        var result = 0;

        if (input == null || !input.Any())
            return result;

        foreach (var dependencies in input)
            result += HasAnyCycle(dependencies) ? 0 : 1;

        return result;
    }

    private static bool HasAnyCycle(Dictionary<char, char> dependencies)
    {
        var result = false;

        if (dependencies == null || dependencies.Count == 0)
            return result;

        foreach (var dep in dependencies)
        {
            var visitedNodes = new HashSet<char>();

            if (HasCycle(dep.Key, dependencies, ref visitedNodes))
            {
                result = true;
                break; // If we found a cycle, no need to check further.
            }
        }


        return result;
    }

    private static bool HasCycle(char currentNode, Dictionary<char, char> dependencies, ref HashSet<char> visitedNodes)
    {
        char nextNode;
        var route = new HashSet<char>();

        while (dependencies.TryGetValue(currentNode, out nextNode))
        {
            if (!route.Add(currentNode)) // A cycle is detected.
                return true;

            if (!visitedNodes.Add(currentNode)) // The rest of the rout has been checked previousely. (for shared dependencies)
                return false;

            currentNode = nextNode;
        }

        return false;
    }
}
