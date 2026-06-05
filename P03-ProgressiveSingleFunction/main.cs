string[] solution(string[][] queries) {
    var container = new HashSet<int>();
    var results = new List<string>();

    foreach (var query in queries) {
        string op = query[0];
        int value = int.Parse(query[1]);

        if (op == "ADD") {
            container.Add(value);
            results.Add("");
        } else if (op == "EXISTS") {
            results.Add(container.Contains(value) ? "true" : "false");
        }
    }

    return results.ToArray();
}
