﻿using MovieRating2000;

internal class Program
{
    private static void Main(string[] args)
    {
        CsvFileReader reader = new CsvFileReader();
        reader.GetData();
    }
}