using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //internal class Phonebook
    //{
    //    #region Attributes
    //    string[] Names;
    //    int[] Numbers;
    //    public int Size { get; set; }
    //    #endregion
    //    public Phonebook(int size)
    //    {
    //        Names = new string[size];
    //        Numbers = new int[size];
    //        Size = size;
    //    }
    //    public void AddPerson(int Postion, string Name, int Number)
    //    {
    //        if (Names is not null && Numbers is not null)
    //        {
    //            if (Postion < Size)
    //            {
    //                Names[Postion] = Name;
    //                Numbers[Postion] = Number;
    //            }
    //        }
    //    }
    //    public int GetNumber(string Name)
    //    {
    //        for (int i = 0; i < Name.Length; i++)
    //        {
    //            if (Names[i] == Name)
    //            {
    //                return Numbers[i];
    //            }
    //        }
    //        return -1;
    //    }
    //    public void SetNumber(string Name, int Number)
    //    {
    //        for (int i = 0; i < Numbers.Length; i++)
    //        {
    //            Numbers[i] = Number;
    //            break;
    //        }
    //    }
    //    public int this[string Name]
    //    {
    //        get
    //        {
    //            for (int i = 0; i < Name.Length; i++)

    //                if (Names[i] == Name)

    //                    return Numbers[i];


    //            return -1;

    //        }
    //        set
    //        {
    //            for (int i = 0; i < Name.Length; i++)

    //                if (Names[i] == Name)

    //                    Numbers[i] = value;



    //        }
    //    }
    //    public string this[int Index]
    //    {
    //        get
    //        {
    //            return $"{Index}:: {Names[Index]}:: {Numbers[Index]}";
    //        }




    //    }

    //}
}
