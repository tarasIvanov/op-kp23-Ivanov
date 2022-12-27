using System;
using System.Diagnostics.Metrics;


class Percolation
{
    static public int n = 5;

    static public int counter = 0;
    static public int pTop = 0;
    static public int pBottom = n * n + 1;

    static bool[] blocked = new bool[(n * n) + 2];
    static int[] nodes = new int[(n * n) + 2];

    static int[] sz = new int[(n * n) + 2];

    public static void Main(string[] args)
    {

        init(n);

        //open(1, 3);
        //open(2, 2);
        //open(4, 4);
        //open(3, 1);
        //open(2, 3);
        //open(2, 1);

        randOpen();

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

}


