/*
 * A feladat a github-on olvasható!
 */

using System;
using System.Threading;

namespace WarriorProject
{
    class Position
    {
        public int x;
        public int y;

        public int X { get { return x; } }
        public int Y { get { return y; } }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void ToConsole()
        {
            Console.WriteLine($"({this.x}, {this.y})");
        }
    }

    class Warrior
    {
        public string name;
        public Position position;

        public string Name { get { return name; } }
        public Position Position { get { return position; } }

        public Warrior(string name, Position p)
        {
            this.name = name;
            this.position = p;
        }

        public void MoveHorizontal(int distance)
        {
            this.position.x += distance;
        }

        public void MoveVertical(int distance)
        {
            this.position.y += distance;
        }

        public void ToConsole()
        {
            Console.WriteLine($"{this.name}, position {this.position}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Position position = new Position(2, -1);
            position.ToConsole();
            Warrior warrior = new Warrior("Peter the Iron Man", position);
            warrior.ToConsole();
            warrior.MoveHorizontal(3);
            warrior.MoveVertical(-2);
            warrior.ToConsole();
        }
    }
}
