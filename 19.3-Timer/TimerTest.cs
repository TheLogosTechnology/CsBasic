﻿// Timer test

using System;
using System.Threading;
using System.Timers;

public class TimerEvent
{
    public static void Main(String[] args)
    {
        System.Timers.Timer aTimer = new System.Timers.Timer();
        //aTimer.Tick += new EventHandler(OnTimer);
        aTimer.Elapsed += OnTimer;
        aTimer.Interval = 1000;
        aTimer.Enabled = true;
        Console.WriteLine("Press \'q\' to quit the sample");
        while (Console.Read() != 'q') ;
    }

    public static void OnTimer(Object source, EventArgs e)
    {
        Console.WriteLine("Timer event happened!");
    }
}
