using System;

namespace Brickwork
{
	public class Program
	{
		public static void Main(string[] args)
		{
			// The builders must cover a rectangular area of size M × N (M and N are even numbers) with two layers of bricks that are rectangles of size 1 × 2.
			// The first layer of the bricks has been already completed.
			// The second layer (in an effort to make the brickwork really strong) must be done so,
			// that no brick in it rests on a brick from the first layer.
			//Given the layout of the bricks in the first layer, determine the possible layout for the second one, or show that it is impossible to make the second layer.
			
			Brickwork firstBrickwork = new Brickwork(2, 4, "1122 3344");
			Brickwork secondBrickwork = new Brickwork(4, 8, "11223344 55667788 99112233 44556677");

			firstBrickwork.MakeSecondLayer();
			secondBrickwork.MakeSecondLayer();
		}
	}
}
