public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue(); // Instantiate PriorityQueue<string>
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Add items with different priorities to the queue, dequeue them, and ensure correct order of removal.
        // Expected Result: Dequeued items should follow priority order.
        Console.WriteLine("Test 1");
        var queue = new PriorityQueue();
        queue.Enqueue("apple", 2);
        queue.Enqueue("banana", 1);
        queue.Enqueue("orange", 3);
        Console.WriteLine("Dequeued: " + queue.Dequeue()); // Expected: orange
        Console.WriteLine("Dequeued: " + queue.Dequeue()); // Expected: apple
        Console.WriteLine("Dequeued: " + queue.Dequeue()); // Expected: banana
        // Defect(s) Found: The dequeue method's loop had an issue with finding the highest priority item and it also would terminate early

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Attempt to dequeue from an empty queue.
        // Expected Result: Error message should be displayed.
        Console.WriteLine("Test 2");
        queue = new PriorityQueue();
        try {
            Console.WriteLine("Dequeued: " + queue.Dequeue());
        } catch (InvalidOperationException ex) {
            Console.WriteLine("Error message: " + ex.Message);
        }
        // Defect(s) Found: None

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}
