using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Adding a number to the end of the queue
    // Expected Result: Numbers shall show in the queue in the order they were added
    // Defect(s) Found: The Enqueue was not working as it should and needed to be fixed
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        //Adds the number with a priority 
        priorityQueue.Enqueue("42", 2);
        priorityQueue.Enqueue("2", 3);
        priorityQueue.Enqueue("65", 1);

        var expectedOutput = "[42 (Pri:2), 2 (Pri:3), 65 (Pri:1)]";
        var actualOutput = priorityQueue.ToString();
        Assert.AreEqual(expectedOutput, actualOutput);

    }

    [TestMethod]
    // Scenario:Dequeue function 
    // Expected Result: Numbers will come out of the queue by priority status starting with 1
    // Defect(s) Found: This was not taking the highest priority out and had to be fixed, Then I had to make sure the number dequeued was removed from the queue
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        //Adds the number with a priority 
        priorityQueue.Enqueue("42", 2);
        priorityQueue.Enqueue("2", 3);
        priorityQueue.Enqueue("65", 1);

        //dequeue items
        var dequeueItems = new List<string>
        {
            priorityQueue.Dequeue(), //65
            priorityQueue.Dequeue(),  //42
            priorityQueue.Dequeue() //2

        };
        var expectedOutput = "[65, 42, 2]";
        var actualOutput = $"[{string.Join(", ", dequeueItems)}]";
        Assert.AreEqual(expectedOutput, actualOutput);

    }

    // Add more test cases as needed below.
    [TestMethod]
    // Scenario:Dequeue function when more than one has the same priority
    // Expected Result: Numbers will come out of the queue by priority status starting with 1. If 2 have the same priority status then it will take FIFO
    // Defect(s) Found: None
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        //Adds the number with a priority 
        priorityQueue.Enqueue("42", 2);
        priorityQueue.Enqueue("2", 4);
        priorityQueue.Enqueue("65", 1);
        priorityQueue.Enqueue("42", 3);

        //dequeue items
        var dequeueItems = new List<string>
        {
            priorityQueue.Dequeue(), //65
            priorityQueue.Dequeue(),  //42
            priorityQueue.Dequeue(),  //42
            priorityQueue.Dequeue() //2

        };
        var expectedOutput = "[65, 42, 42, 2]";
        var actualOutput = $"[{string.Join(", ", dequeueItems)}]";
        Assert.AreEqual(expectedOutput, actualOutput);

    }

    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    // Scenario: queue is empty
    // Expected Result: an error exception shall be thrown
    // Defect(s) Found: None
    public void TestPriorityQueue_4()
    {
        var queue = new PriorityQueue();
        queue.Dequeue(); //Throw an exception because of an empty queue
    }
}
