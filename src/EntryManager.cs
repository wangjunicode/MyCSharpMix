using System.Text;
using System.Linq;
using System.IO;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using CSharpMix.GenericType;
using System.Reflection;
using System.Diagnostics;

public class EntryManager
{
    public static void Init()
    {
        #region note
        // System.Console.WriteLine("Init");

        // Singleton.GetInstance().Print();

        // string typeStr = AppConfigHelper.GetConfigType();
        // IChartable chartable = ChartFactroy.GetChart(typeStr);
        // if (chartable != null)
        // {
        //     chartable.Display();
        // }
        // else
        // {
        //     System.Console.WriteLine("not found type:" + typeStr);
        // }

        //AppConfigHelper.CreateConfig();

        // List<int> list1 = new List<int> { 1, 2, 3 };
        // List<int> list2 = new List<int>();
        // list2 = list1;
        // list2.Clear();
        // foreach (var item in list1)
        // {
        //     System.Console.WriteLine(item);
        // }

        // BoTree<Student> tree1 = new BoTree<Student>();
        // tree1.Data = new Student("小波1", "男", 18);

        // BoTree<Student> tree2 = new BoTree<Student>();
        // tree2.Data = new Student("小波2", "男", 19);

        // BoTree<Student> tree3 = new BoTree<Student>();
        // tree3.Data = new Student("小波3", "男", 20);

        // BoTree<Student> tree4 = new BoTree<Student>();
        // tree4.Data = new Student("小波4", "男", 21);

        // tree1.AddNode(tree2);
        // tree1.AddNode(tree3);
        // tree3.AddNode(tree4);

        // Recursive(tree1);
        // AppConfigHelper.CreateConfig();
        // string str = "spr nameLbLb";
        // var tem = str.Substring(str.IndexOf(' '), 2);
        // System.Console.WriteLine(tem);
        // if (str.EndsWith("Lb"))
        // {
        //     str = str.Remove(str.Length - 2, 2);
        // }
        // System.Console.WriteLine(str);
        // MyGenericArray<int> intArray = new MyGenericArray<int>(5);
        // for (int i = 0; i < 5; i++)
        // {
        //     intArray.SetItem(i *  i*5);
        // }

        // for (int i = 0; i < 5; i++)
        // {
        //     Console.WriteLine(intArray.GetItem(i));
        // }

        // string input = "1851 1999 1950 1905 2003";

        //     List<string> mAllPrefabList = Directory.GetFiles(@"G:\KiHan\Assets\Resources\UILua", "*.prefab", SearchOption.AllDirectories).ToList();
        //     List<string> result = new List<string>();
        //     for (int j = 0; j < mAllPrefabList.Count; j++)
        //     {
        //         string item = mAllPrefabList[j];
        //         string input = File.ReadAllText(item);
        //         string pattern1 =
        //         @"  - ItemName: (?<ItemName>.*?)
        // ItemType: (?<ItemType>.*?)
        // ";
        //         string pattern2 = "m_Script: {fileID: 11500000, guid: 48d58ada50d7a6c47b06cab3ca877077, type: 3}";
        //         Regex regex1 = new Regex(pattern1);
        //         Regex regex2 = new Regex(pattern2);

        //         if (regex2.Matches(input).Count == 0)
        //         {
        //             continue;
        //         }
        //         result.Add(item);

        //         MatchCollection matchCollection1 = regex1.Matches(input);

        //         foreach (Match m in matchCollection1)
        //         {
        //             // System.Console.WriteLine(m.Groups["ItemName"].Value);
        //             // System.Console.WriteLine(m.Groups["ItemType"].Value);
        //             result.Add(m.Groups["ItemName"].Value);
        //             result.Add(m.Groups["ItemType"].Value);
        //             result.Add("\n");
        //         }
        //     }

        //     File.WriteAllLines("data/config.json", result);
        // (?<ItemName>.*?)

        //     string item = "data/TestUIBindingViewLua.prefab";
        //     string input = File.ReadAllText(item);
        //     string pattern =
        //     @"[ ]{2}- ItemName: (?<ItemName>.*?)
        // ItemType: (?<ItemType>.*?)
        // ";
        //     Regex regex = new Regex(pattern);
        //     MatchCollection matchCollection = regex.Matches(input);
        //     foreach (Match m in matchCollection)
        //     {
        //         // System.Console.WriteLine(m.Value);
        //         System.Console.WriteLine(m.Groups["ItemName"].Value);
        //         System.Console.WriteLine(m.Groups["ItemType"].Value);
        //     }

        //     System.Console.WriteLine("jfdk");
        #endregion

        // ExecuteCommand("cd bats & CreateFold");
        // Directory.CreateDirectory("G:/KiHan/Assets/Resources/AtlasNB/Static/Res/ActCenter/Act_2");
        string a = "KH";
        int len = a.Split('.').Length;
        System.Console.WriteLine(len);
        System.Console.WriteLine(a.Split('.')[len - 1]);

    }

    static void ExecuteCommand(string command)
    {
        int exitCode;
        ProcessStartInfo processInfo;
        Process process;

        processInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
        processInfo.CreateNoWindow = true;
        processInfo.UseShellExecute = false;
        // *** Redirect the output ***
        processInfo.RedirectStandardError = true;
        processInfo.RedirectStandardOutput = true;

        process = Process.Start(processInfo);
        process.WaitForExit();

        // *** Read the streams ***
        // Warning: This approach can lead to deadlocks, see Edit #2
        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();

        exitCode = process.ExitCode;

        Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
        Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
        Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");
        process.Close();
    }
}
