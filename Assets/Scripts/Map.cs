using System;

public class Map
{

	public bool[,] MovementMap = new bool[,] { 
		{false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
        
		{false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
        {false, true,  false, false, false, false, true,  true,  false, false, false, false, false, true,  true,  true,  true,  false, false, false, false, false, true,  false, false, false, false, false, false, false, true,  false },
        {false, true,  false, true,  true,  true,  true,  false, false, true,  true,  true,  false, false, true,  true,  true,  true,  false, false, true,  false, true,  false, true,  false, false, true,  true,  false, true,  false },
        {false, true,  false, false, false, false, true,  false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false, true,  false },
        {false, true,  false, true,  true,  true,  true,  false, false, true,  true,  true,  false, false, true,  true,  true,  true,  false, false, true,  true,  true,  true,  true,  false, false, false, false, false, true,  false },

        {false, true,  false, false, false, false, true,  true,  false, false, false, false, false, true,  true,  true,  true,  false, false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false, true,  false },
        {false, true,  false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false, true,  true,  true,  true,  true,  false, true,  false, false, true,  true,  false, true,  false },
        {false, true,  false, false, false, false, true,  false, false, false, true,  false, false, false, true,  true,  true,  false, false, false, false, false, false, false, false, false, false, false, false, false, true,  false },
        {false, true,  true,  true,  true,  true,  true,  false, true,  false, true,  false, true,  false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
        {false, true,  false, true,  false, true,  true,  false, true,  true,  true,  true,  true,  false, true,  true,  true,  false, false, false, true,  false, false, false, true,  false, false, false, false, false, true,  false },

        {false, true,  false, true,  false, false, true,  false, true,  true,  true,  true,  true,  false, true,  true,  true,  false, true,  false, true,  false, true,  false, true,  true,  true,  true,  true,  false, true,  false },
		{false, true,  false, true,  true,  true,  true,  false, true,  true,  true,  true,  true,  false, true,  true,  true,  false, true,  true,  true,  true,  true,  false, true,  false, false, true,  true,  false, true,  false },
        {false, true,  false, true,  false, false, true,  false, false, false, false, false, false, false, true,  true,  true,  false, false, false, true,  false, false, false, true,  true,  false, false, false, false, true,  false },
        {false, true,  false, true,  false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false, false, false, true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
        {false, true,  true,  true,  true,  true,  true,  false, false, false, false, false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false, false, false, false, true,  true,  true,  true,  false },

        {false, true,  false, false, false, true,  true,  false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false, false, false, false, false, true,  true,  false, false, true,  true,  true,  false },
        {false, true,  false, true,  false, true,  true,  false, false, false, false, false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false, true,  false, true,  false },
        {false, true,  false, true,  false, true,  true,  false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false, false, false, false, false, true,  true,  false, false, true,  false, true,  false },
        {false, true,  true,  true,  true,  true,  true,  false, false, false, false, false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false, false, false, false, true,  true,  true,  true,  false },
        {false, true,  false, false, false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false, false, true,  true,  true,  true,  true,  true,  true,  true,  true,  false },

        {false, true,  false, true,  true,  true,  false, false, false, false, false, true,  true,  true,  false, true,  false, true,  true,  true,  false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
        {false, true,  false, false, false, true,  false, true,  true,  true,  false, true,  false, false, false, true,  false, false, false, true,  false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
        {false, true,  true,  true,  true,  true,  false, true,  true,  true,  false, true,  false, true,  true,  true,  true,  true,  false, true,  false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
        {false, true,  false, false, false, false, false, true,  true,  true,  false, true,  false, false, true,  true,  true,  false, false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
        {false, true,  false, true,  true,  true,  true,  true,  true,  true,  false, true,  false, true,  true,  true,  true,  true,  false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },

        {false, true,  false, true,  true,  true,  true,  true,  true,  true,  false, true,  false, false, true,  true,  true,  false, false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
        {false, true,  false, true,  true,  true,  true,  true,  true,  true,  false, true,  false, true,  true,  true,  true,  true,  false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
        {false, true,  false, true,  true,  false, true,  false, true,  true,  false, true,  false, false, false, true,  false, false, false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
        {false, true,  false, false, false, false, true,  false, false, false, false, true,  true,  true,  false, false, false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
        {false, true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  true,  false },
        
		{false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false },
    };

	public int[,] MazeMap = new int[,] { 
		{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
		{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
		{1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1 },
		{1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 0, 1, 0, 1, 0, 1, 1, 0, 0, 1, 0, 1 },
		{1, 0, 1, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 },
		{1, 0, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 1 },
		{1, 0, 1, 1, 1, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 },
		{1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 0, 1 },
		{1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1 },
		{1, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
		{1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 1, 1, 0, 1 },
		{1, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1 },
		{1, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 1, 0, 1 },
		{1, 0, 1, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 1, 1, 1, 1, 0, 1 },
		{1, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
		{1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1 },
		{1, 0, 1, 1, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 0, 0, 1 },
		{1, 0, 1, 0, 1, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1 },
		{1, 0, 1, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 1, 1, 0, 1, 0, 1 },
		{1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1 },
		{1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
		{1, 0, 1, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
		{1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
		{1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
		{1, 0, 1, 1, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
		{1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
		{1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
		{1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
		{1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
		{1, 0, 1, 1, 1, 1, 0, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
		{1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
		{1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
	};
}
