using Microsoft.VisualStudio.TestTools.UnitTesting;

// Just to clarify, I made the test functions first then after running the tests 
// I found the defects and based on this information I fixed the code in the PriorityQueue.cs file

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: This function test has the objective to test if the Enqueue method adds items to the queue in the order they are added, 
    // regardless of priority.
    // Defect(s) Found: This test was failing because the implementation of the Dequeue() was incomplete, 
    // I fixed this issue by adding the logic described in the assignment
    // Now its working as expected :)
    public void TestPriorityQueue_AddsItemsToQueue()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 2);
        pq.Enqueue("C", 3);

        Assert.AreEqual("[A (Pri:1), B (Pri:2), C (Pri:3)]", pq.ToString());
    }

    [TestMethod]
    // Scenario: This function test has the objective to test if the Dequeue method removes the item with the highest priority 
    // and returns its value. And if the queue is updated accordingly.
    // Defect(s) Found: This test was failing because the implementation of the Dequeue() was incomplete, 
    // I fixed this issue by adding the logic described in the assignment
    // Now its working as expected :)
    public void TestPriorityQueue_RemovesHighestPriorityItem()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 3);
        pq.Enqueue("C", 2);

        var item = pq.Dequeue();

        Assert.AreEqual("B", item);
        Assert.AreEqual("[A (Pri:1), C (Pri:2)]", pq.ToString());
    }

    [TestMethod]
    // Scenario: This function test has the objective to test if the Dequeue method removes the first item added 
    // with the highest priority when there are multiple items with the same highest priority.
    // Defect(s) Found: This test was failing because the implementation of the Dequeue() was incomplete, 
    // I fixed this issue by adding the logic described in the assignment
    // Now its working as expected :)
    public void TestPriorityQueue_RemovesFirstItemWithHighestPriority_WhenTied()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 3);
        pq.Enqueue("B", 3);
        pq.Enqueue("C", 2);

        var item = pq.Dequeue();

        Assert.AreEqual("A", item);
        Assert.AreEqual("[B (Pri:3), C (Pri:2)]", pq.ToString());
    }

    [TestMethod]
    // Scenario: This function test has the objective to test if the Dequeue method 
    // throws an InvalidOperationException when called on an empty queue.
    // Defect(s) Found: This test was failing because the implementation of the Dequeue() was incomplete, 
    // I fixed this issue by adding the logic described in the assignment
    // Now its working as expected :)
    [ExpectedException(typeof(InvalidOperationException))]
    public void TestPriorityQueue_ThrowsException_WhenQueueIsEmpty()
    {
        var pq = new PriorityQueue();
        pq.Dequeue(); 
    }

    [TestMethod]
    // Scenario: This function test has the objective to test if the Enqueue method maintains the order 
    // for items with the same priority, and the Dequeue method returns these items in the order they were added.
    // Defect(s) Found: This test was failing because the implementation of the Dequeue() was incomplete, 
    // I fixed this issue by adding the logic described in the assignment
    // Now its working as expected :)
    public void TestPriorityQueue_MultipleItems_MaintainsFIFOOrderForSamePriority()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("A", 1);
        pq.Enqueue("B", 1);
        pq.Enqueue("C", 1);

        var item1 = pq.Dequeue();
        var item2 = pq.Dequeue();
        var item3 = pq.Dequeue();

        Assert.AreEqual("A", item1);
        Assert.AreEqual("B", item2);
        Assert.AreEqual("C", item3);
    }
}