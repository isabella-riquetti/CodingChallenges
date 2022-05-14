from node import Node
from solution import Solution

class SolutionTest(object):
    def test_nodes(self):
        Solution.connect(Solution(), self.root)
        self.asserts(self.root,self.expectedRoot)

    def asserts(self, node,expectedNode):
        assert node.val == expectedNode.val

        if node.right is not None or expectedNode.right is not None:
            self.asserts(node.right,expectedNode.right)
            assert node.right.val == expectedNode.right.val

        if node.left is not None or expectedNode.left is not None:
            self.asserts(node.left,expectedNode.left)
            assert node.left.val == expectedNode.left.val

        if node.next is not None or expectedNode.next is not None:
            assert node.next.val == expectedNode.next.val

    root = Node(1,Node(2,Node(4),Node(5)),Node(3,Node(6),Node(7)))

    expectedNode7 = Node(7)
    expectedNode6 = Node(6,None,None,expectedNode7)
    expectedNode5 = Node(5,None,None,expectedNode6)
    expectedNode4 = Node(4,None,None,expectedNode5)
    expectedNode3 = Node(3,expectedNode6,expectedNode7)
    expectedNode2 = Node(2,expectedNode4,expectedNode5,expectedNode3)
    expectedRoot = Node(1,expectedNode2,expectedNode3)

    def test(self):
        self.test_nodes()
        print("Everything passed")

SolutionTest().test()