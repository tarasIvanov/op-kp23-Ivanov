using System;
using System.Diagnostics.Metrics;


class Percolation
{
    static public int n = 10;

    static public int counter = 0;
    static public int pTop = 0;
    static public int pBottom = n * n + 1;

    static bool[] blocked = new bool[(n * n) + 2];
    static int[] nodes = new int[(n * n) + 2];

    static int[] sz = new int[(n * n) + 2];

    public static void Main(string[] args)
    {
        init(n);

        //test case

        //n = 10
        //open(7, 3);
        //open(8, 3);
        //open(9, 3);
        //open(10, 3);
        //open(6, 4);
        //open(6, 5);
        //open(7, 5);
        //open(8, 5);
        //open(9, 5);
        //open(10, 5);
        //open(1, 7);
        //open(2, 7);
        //open(3, 7);
        //open(4, 7);
        //open(5, 7);
        //open(6, 7);
        //open(7, 7);
        //open(7, 6);

        //Output:

        //0 0 0 0 0 0 2 0 0 0
        //0 0 0 0 0 0 2 0 0 0
        //0 0 0 0 0 0 2 0 0 0
        //0 0 0 0 0 0 2 0 0 0
        //0 0 0 2 2 0 2 0 0 0
        //0 0 2 0 2 2 2 0 0 0
        //0 0 2 0 2 0 0 0 0 0
        //0 0 2 0 2 0 0 0 0 0
        //0 0 2 0 2 0 0 0 0 0

        //numberOfOpenSites = 18
        //Percolates ? : True

       



        //randOpen();

        print();
        Console.WriteLine("\nnumberOfOpenSites = " + numberOfOpenSites());
        Console.WriteLine("Percolates? : " + percolates());
    }


    static public void init(int n)
    {
        for (int i = 0; i < (n * n + 2); i++)
        {
            blocked[i] = false;
            nodes[i] = i;
            sz[i] = 1;
        }
    }

    static public void randOpen()
    {
        int row, col;

        Random rand = new Random();

        for (int i = 0; i < rand.Next(1, n * n); i++)
        {
            row = rand.Next(1, n + 1);
            col = rand.Next(1, n + 1);

            if (isOpen(row, col))
            {
                i--;
                continue;
            }

            open(row, col);
        }
    }

    static int getIndex(int row, int col)
    {
        return (row - 1) * n + col;
    }

    static void open(int row, int col)
    {
        counter++;

        blocked[getIndex(row, col)] = true;

        if (row == 1)
        {
            union(getIndex(row, col), pTop);
        }

        if (row == n)
        {
            union(getIndex(row, col), pBottom);
        }

        if (row > 1 && isOpen(row - 1, col))
        {
            union(getIndex(row, col), getIndex(row - 1, col));
        }

        if (row < n && isOpen(row + 1, col))
        {
            union(getIndex(row, col), getIndex(row + 1, col));
        }

        if (col > 1 && isOpen(row, col - 1))
        {
            union(getIndex(row, col), getIndex(row, col - 1));
        }

        if (row < n && isOpen(row, col + 1))
        {
            union(getIndex(row, col), getIndex(row, col + 1));
        }
    }


    static bool isOpen(int row, int col)
    {
        return blocked[getIndex(row, col)] == true;
    }


    static bool isFull(int row, int col)
    {
        return connected(pTop, getIndex(row, col));
    }

    static public int numberOfOpenSites()
    {
        return counter;
    }

    static bool percolates()
    {
        return connected(pTop, pBottom);
    }


    static void print()
    {
        for (int i = 1; i < n + 1; i++)
        {
            for (int j = 1; j < n + 1; j++)
            {
                if (isFull(i, j))
                {
                    Console.Write("2 ");
                }
                else if (isOpen(i, j))
                {
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write("0 ");
                }

            }
            Console.WriteLine();

        }

    }

    static int root(int x)
    {
        int res = nodes[x];
        while (res != nodes[res])
        {
            nodes[res] = nodes[nodes[res]];
            res = nodes[res];
        }

        return res;
    }

    static void union(int x, int y)
    {
        int rootX = root(x);
        int rootY = root(y);

        if (rootX == rootY)
        {
            return;
        }

        int szX = sz[rootX];
        int szY = sz[rootY];

        if (szX > szY)
        {
            sz[rootX] += szY;
            nodes[rootY] = nodes[rootX];
        }
        else
        {
            sz[rootY] += szX;
            nodes[rootX] = nodes[rootY];
        }
    }

    static bool connected(int x, int y)
    {
        int rootX = root(x);
        int rootY = root(y);

        return rootX == rootY;
    }

    static bool testOpen()
    {
        open(1, 3);
        open(2, 3);
        open(3, 3);
        open(4, 3);
        open(5, 3);

        bool expected1 = true;
        bool expected2 = true;
        bool expected3 = true;
        bool expected4 = true;
        bool expected5 = true;

        bool actual1 = isOpen(1, 3);
        bool actual2 = isOpen(2, 3);
        bool actual3 = isOpen(3, 3);
        bool actual4 = isOpen(4, 3);
        bool actual5 = isOpen(5, 3);

        if (expected1 != actual1)
        {
            Console.WriteLine("TestOpen: case1 is failed");
            return false;
        }

        if (expected2 != actual2)
        {
            Console.WriteLine("TestOpen: case2 is failed");
            return false;
        }

        if (expected3 != actual3)
        {
            Console.WriteLine("TestOpen: case3 is failed");
            return false;
        }

        if (expected4 != actual4)
        {
            Console.WriteLine("TestOpen: case4 is failed");
            return false;
        }

        if (expected5 != actual5)
        {
            Console.WriteLine("TestOpen: case5 is failed");
            return false;
        }

        Console.WriteLine("TestOpen: all cases passed");
        return true;

    }

    static bool testIsOpen()
    {
        bool expected1 = true;
        bool expected2 = false;

        bool actual1 = isOpen(3, 3);
        bool actual2 = isOpen(1, 1);

        if (expected1 != actual1)
        {
            Console.WriteLine("TestIsOpen: case1 is failed");
            return false;
        }
        if (expected2 != actual2)
        {
            Console.WriteLine("TestIsOpen: case2 is failed");
            return false;
        }
        Console.WriteLine("TestIsOpen: all cases passed");
        return true;
    }

    static bool testIsFull()
    {
        bool expected1 = true;
        bool expected2 = false;

        bool actual1 = isFull(3, 3);
        bool actual2 = isFull(1, 1);

        if (expected1 != actual1)
        {
            Console.WriteLine("TestIsFull: case1 is failed");
            return false;
        }
        if (expected2 != actual2)
        {
            Console.WriteLine("TestIsFull: case2 is failed");
            return false;
        }
        Console.WriteLine("TestIsFull: all cases passed");
        return true;
    }

    static bool testNumberOfOpenSites()
    {
        int expected = 5;

        int actual = numberOfOpenSites();

        if (expected != actual)
        {
            Console.WriteLine("TestNumberOfOpenSites: case is failed");
            return false;
        }
        Console.WriteLine("TestNumberOfOpenSites: case passed");
        return true;
    }

    static bool testPercolates()
    {
        bool expected = true;

        bool actual = percolates();

        if (actual != expected)
        {
            Console.WriteLine("TestPecolates: case is failed");
            return false;
        }
        Console.WriteLine("TestPercolates: case passed");
        return true;
    }

    static bool testRoot()
    {
        int expected1 = 0;
        int expected2 = 25;

        int actual1 = root(3);
        int actual2 = root(25);

        if (expected1 != actual1)
        {
            Console.WriteLine("TestRoot: case1 is failed");
            return false;
        }
        if (expected2 != actual2)
        {
            Console.WriteLine("TestRoot: case2 is failed");
            return false;
        }
        Console.WriteLine("TestRoot: all cases passed");
        return true;

    }

    static bool testUnion()
    {
        bool expected1 = false;
        bool expected2 = true;

        bool actual1 = connected(1, 2);
        bool actual2 = connected(3, 8);

        if (expected1 != actual1)
        {
            Console.WriteLine("TestUnion: case1 is failed");
            return false;
        }
        if (expected2 != actual2)
        {
            Console.WriteLine("TestUnion: case2 is failed");
            return false;
        }
        Console.WriteLine("TestUnion: all cases passed");
        return true;
    }

    static bool testConnected()
    {
        bool expected1 = false;
        bool expected2 = true;
        bool actual1 = connected(1, 2);
        bool actual2 = connected(3, 8);
        if (expected1 != actual1)
        {
            Console.WriteLine("TestConnected: case1 is failed");
            return false;
        }
        if (expected2 != actual2)
        {
            Console.WriteLine("TestConnected: case2 is failed");
            return false;
        }
        Console.WriteLine("TestConnected: all cases passed");
        return true;
    }

    static bool testGetIndex()
    {
        int expected1 = 1;
        int expected2 = 25;
        int expected3 = 8;
        int expected4 = 11;

        int actual1 = getIndex(1, 1);
        int actual2 = getIndex(5, 5);
        int actual3 = getIndex(2, 3);
        int actual4 = getIndex(3, 1);

        if (expected1 != actual1)
        {
            Console.WriteLine("TestGetIndex: case1 is failed");
            return false;
        }
        if (expected2 != actual2)
        {
            Console.WriteLine("TestGetIndex: case2 is failed");
            return false;
        }
        if (expected3 != actual3)
        {
            Console.WriteLine("TestGetIndex: case3 is failed");
            return false;
        }
        if (expected4 != actual4)
        {
            Console.WriteLine("TestGetIndex: case4 is failed");
            return false;
        }
        Console.WriteLine("TestGetIndex: all cases passed");
        return true;
    }


}


