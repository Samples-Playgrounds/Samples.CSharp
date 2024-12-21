using System.Diagnostics;
using System.Text.RegularExpressions;
using AppConsole.PerformanceImprovements.Toub;

/*
    Performance Improvements in .NET 9
        
        https://www.youtube.com/watch?v=aLQpnpSxosg 

    
 */


Console.WriteLine(new string('=', 120));
Console.WriteLine("GetAlternateLookup.CollectData_Naive");
GetAlternateLookup.CollectData_Naive();
Console.WriteLine(new string('=', 120));
Console.WriteLine("GetAlternateLookup.CollectData_net70_EnumerateMatches");
GetAlternateLookup.CollectData_net70_EnumerateMatches();
Console.WriteLine(new string('=', 120));
Console.WriteLine("GetAlternateLookup.CollectData_net90_EnumerateMatches_GetAlternateLookup");
GetAlternateLookup.CollectData_net90_EnumerateMatches_GetAlternateLookup();


Console.WriteLine(new string('=', 120));
Console.WriteLine("Split_EnumerateSplits.CollectData_Naive");
Split_EnumerateSplits.CollectData_Naive();
Console.WriteLine(new string('=', 120));
Console.WriteLine("Split_EnumerateSplits.CollectData_net90_String_AsSpan_Split");
Split_EnumerateSplits.CollectData_net90_String_AsSpan_Split();
Console.WriteLine(new string('=', 120));
Console.WriteLine("Split_EnumerateSplits.CollectData_net90_EnumerateSplits_GetAlternateLookup");
Split_EnumerateSplits.CollectData_net90_EnumerateSplits_GetAlternateLookup();
Console.WriteLine(new string('=', 120));
Console.WriteLine("Split_EnumerateSplits.CollectData_net90_String_AsSpan_Split");
Split_EnumerateSplits.CollectData_net90_String_AsSpan_Split();

return;

