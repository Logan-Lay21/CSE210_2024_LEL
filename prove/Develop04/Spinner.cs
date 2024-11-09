using System;
using System.Runtime.Versioning;



public class Spinner {

    public Spinner(int iterations, int sleep){
        SetCount(iterations);
        SetSleep(sleep);
    }
    public Spinner(){}
    private int _count = 0;
    private int _iterations = 8;
    private int _sleep = 500;
    private static string[] loading = {"|","/","-","\\"};
        // @"
        //        O
        //       |l|   
        //        ll
        //     --------",
        // @"
                    
        //       _O_     
        //        ll     
        //     --------",
        // @"
        //        O
        //       |l|   
        //        ll
                        
        //     --------"
    public void StartLoading() 
    {
        while (_count < _iterations)
        {
            foreach (string frame in loading)
            {
                Console.Write($"\r {frame}");
                Thread.Sleep(_sleep);
                _count ++;
            }
        }
        Console.WriteLine("\r    ");
        _count = 0;
    }

    public void SetCount(int iterations) {
        _iterations = iterations;
    }

    public void SetSleep(int sleep) {
        _sleep = sleep;
    }
}