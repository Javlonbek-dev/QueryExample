class LinqQueryExample
{
    static void Main()
    {
        //QuerySentax 
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var querySentax= from obj in list
                         where obj>3
                         select obj;
        foreach (var item in querySentax)
        {
            Console.WriteLine(item);
        }

        //MethodSentax
        var methodSentax= list.Where(obj => obj > 3);
        foreach (var item in methodSentax)
        {
            Console.WriteLine(item);
        }

        //MixedSentax
        var mixedSenatx= (from obj in list
                          select obj).Max();

        Console.WriteLine("Max value: "+methodSentax );
    }
}