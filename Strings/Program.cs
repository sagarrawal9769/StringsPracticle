
using System.Data;



class Program
{
 
    static void Main(string[] args)
    {
        DataTable dt = Program.ReadCsv(@"C:\Users\lenovo\Documents\feat system.csv");
        foreach(DataRow dr in dt.Rows)
        {
            foreach(var item in dr.ItemArray)
            {
                Console.WriteLine(item);
            }
            
        }
        
        Program.stringClone();
        Program.stringCopy();
        Program.stringCompare();
        Program.stringCompareOrdinal();
        Program.stringCompareTo();
        Program.stringConcat();
        Program.stringContains();
        Program.stringCopyTo();
        Program.stringEndsWith();
        Program.stringEquals();
        Program.stringFormat();
        Program.allOthersString();





    }
    public static DataTable ReadCsv(string filePath)
    {
        DataTable dataTable = new DataTable();
        using (StreamReader streamReader = new StreamReader(filePath))
        {
            string[] headres = streamReader.ReadLine().Split(',');
            foreach (string header in headres)
            {
                
                dataTable.Columns.Add(header);
            }
            while (!streamReader.EndOfStream)
            {
                string[] rows = streamReader.ReadLine().Split(',');
                DataRow dr = dataTable.NewRow();
                for (int i = 0; i < headres.Length; i++)
                {
                    dr[i] = rows[i];
                }
                dataTable.Rows.Add(dr);
            }
            
        }
        return dataTable;
    }

    public static void stringClone()
    {
        // String Clone()-----------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " +"String Clone()");
        Console.WriteLine();
        string s1 = "You've entered into the imagination world";
        string s2 = (String)s1.Clone();
        Console.WriteLine(" " +s1);
        Console.WriteLine(" " +s2);
        Console.WriteLine();

        // End of String Clone()----------------------

    }
    public static void stringCopy()
    {
        // String Copy()----------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String Copy()");
        Console.WriteLine();
        string s1 = "Hello Imagination";
        string s2 = "Hello Dream";
        string s3 = string.Copy(s1);
        string s4 = string.Copy(s2);
        Console.WriteLine(" " + s1);
        Console.WriteLine(" " + s2);
        Console.WriteLine(" " + (s3 + " & " + s4));
        Console.WriteLine();

        //End of String Copy()------------------------------------------------
    }
    public static void stringCompare()
    {
        // String Compare()----------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " +"String Compare()");
        Console.WriteLine();
        string s1, s2, s3, s4;
        s1 =  "Entering the world of imagination";
        s2 = "Entering the world of imagination";
        s3 = "So u dont want to enter into imagination, no problem";
        s4 = "Okay by ";
        Console.WriteLine(" " +string.Compare(s1,s2));
        Console.WriteLine(" " +string.Compare(s2,s3));
        Console.WriteLine(" " +string.Compare(s3,s4));
        Console.WriteLine();

        // End of String Compare()------------------


    }
    public static void stringCompareOrdinal()
    {
        // String CompareOrdinal()---------------------------- Doubt---------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " +"String Compareordinal()");
        Console.WriteLine();
        string s1 = "mello";
        string s2 = "csharp";
        string s3 = "mellp";
        string s4 = "mellou";

        Console.WriteLine(" " +string.CompareOrdinal(s1, s2));
        Console.WriteLine(" " +string.CompareOrdinal(s1, s3));
        Console.WriteLine(" " +string.CompareOrdinal(s1, s4));
        Console.WriteLine();
        Console.WriteLine();

        // End of String CompareOrdinal()---------------------  Doubt Solved--------------------

    }
    public static void stringCompareTo()
    {
        // String CompareTo()----------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " +"String CompareTo()");
        Console.WriteLine();
        string s1 = "hello";
        string s2 = "mello";
        string s3 = "csharp";
        string s4 = "cshare";
        string s5 = "mello";
        Console.WriteLine(" " +s1.CompareTo(s2));
        Console.WriteLine(" " +s2.CompareTo(s3));
        Console.WriteLine(" " +s3.CompareTo(s4));
        Console.WriteLine(" " +s2.CompareTo(s5));
        Console.WriteLine();

        // End of String CompareTo()----------------------------------------------------
    }

    public static void stringConcat()
    {
        // String Concat()----------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " +"String Concat()");
        Console.WriteLine();
        string s1 = "Hello ";
        string s2 = "Imagination";
        Console.WriteLine(" " +string.Concat(s1,s2));
        Console.WriteLine();

        // End of Concat()------------------------------------------------------

    }
    public static void stringContains()
    {
        // String Contains()----------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " +"String Contains()");
        Console.WriteLine();
        string s1 = "Hello Dream";
        string s2 = "Hello Dream";
        string s3 = "By";
        Console.WriteLine(" " +s1.Contains(s2));
        Console.WriteLine(" " +s2.Contains(s3));
        Console.WriteLine();

        //End of String Contains()------------------------------------------------
    }
   
    public static void stringCopyTo()
    {
        // String CopyTo()--------------------------------------------Doubt------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String CopyTo()");
        Console.WriteLine();
        string s1 = "GeeksForGeeks";
        char[] ch = new char[] {'H','e','l','l','o',' ','W','o','r','l','d',' '};
        s1.CopyTo(8, ch,6,5);
       
        Console.WriteLine(ch);
        Console.WriteLine();

        //End of String CopyTo()----------------------------------------------Unsolved Doubt------------------
    }
    public static void stringEndsWith()
    {
        // String EndsWith()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String EndsWith()");
        Console.WriteLine();
        string s1, s2, s3;
        s1 = "Sagar";
        s2 = "Riya";
        s3 = "gar";
        Console.WriteLine(" " + s1.EndsWith(s2));
        Console.WriteLine(" " + s2.EndsWith(s3));
        Console.WriteLine(" " + s1.EndsWith(s3));
        Console.WriteLine();

        // End of String EndsWith()-------------------------------------------------------------------------


    }
    public static void stringEquals()
    {
        // String Equals()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String Equals()");
        Console.WriteLine();
        string s1 = "Hello";
        string s2 = "Byyyyyeeeee";
        string s3 = "Hello";
        Console.WriteLine(s1.Equals(s2));
        Console.WriteLine(s1.Equals(s3));
        Console.WriteLine();

        //End of String Equals()-----------------------------------------------------------------------
    }
    public static void stringFormat()
    {
        // String Format()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String Format()");
        Console.WriteLine();
        string s1 = string.Format("{0:D}", DateTime.Now);
        Console.WriteLine(s1);
        Console.WriteLine();
        string s2 = string.Format("{0}", DateTime.Now);
        Console.WriteLine(s2);
        Console.WriteLine();

        //End of String Format()----------------------------------------------------------------------------

    }
    public static void allOthersString()
    {
        // String GetEnumerator()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String GetEnumerator()");
        Console.WriteLine();
        string s2 = "Hello MF";
        CharEnumerator ch = s2.GetEnumerator();
        while (ch.MoveNext())
        {
            Console.WriteLine(ch.Current);
        }
        Console.WriteLine();

        // End of String GetEnumerator()--------------------------------------------------------------

        // String GetHashCode()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String GetHasCode()");
        Console.WriteLine();
        string string1 = "Hello Mf's";
        Console.WriteLine(string1.GetHashCode());
        Console.WriteLine();

        //End of String GetHasCode()--------------------------------------------------------------------------

        // String GetType()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String GetType()");
        Console.WriteLine();
        int i = 15;
        Console.WriteLine(i.GetType());
        Console.WriteLine();
        string string2 = "By Mf's";
        Console.WriteLine(string2.GetType());
        Console.WriteLine();

        // End of String GetType()-----------------------------------------------------------------

        // String GetTypeCode()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String GetTypeCode()");
        Console.WriteLine();
        Console.WriteLine(string1.GetTypeCode());
        Console.WriteLine(i.GetTypeCode());
        Console.WriteLine();

        //End of String GetTypeCode()-------------------------------------------------------

        // String IndexOf()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String IndexOf()");
        Console.WriteLine();
        int index = string2.IndexOf('s');
        Console.WriteLine(index);
        Console.WriteLine();

        //End of IndexOf()----------------------------------------------------------------------------

        // String Insert()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String Insert()");
        Console.WriteLine();
        string string3 = string2.Insert(2, ",");
        Console.WriteLine(string3);
        Console.WriteLine();

        //End of String Insert()---------------------------------------------------------------------------------


        // String Intern()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String Intern()");
        Console.WriteLine();
        string string4 = string.Intern(string1);
        Console.WriteLine(string1);
        Console.WriteLine(string4);
        Console.WriteLine();

        //End of String Intern()----------------------------------------------------------------------

        // String IsInterned()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String IsIntern()");
        Console.WriteLine();
  
        bool b1 = string1.IsNormalized();
        Console.WriteLine(string1);
        Console.WriteLine(b1);
        Console.WriteLine();

        //End of IsInterned()---------------------------------------------------------------------------

        // String Normalize()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String Normalize()");
        Console.WriteLine();
        string b = string1.Normalize();
        Console.WriteLine(b);
        Console.WriteLine();

        //End of Normalize()------------------------------------------------------------------------------

        // String IsNullOrEmpty()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String IsNullOrEmpty()");
        Console.WriteLine();
        string st1 = "Hello Mf's";
        string? st2 = null;
        bool bool1 = string.IsNullOrEmpty(st1);
        bool bool2 = string.IsNullOrEmpty(st2);
        Console.WriteLine(bool1);
        Console.WriteLine(bool2);
        Console.WriteLine();

        //End of IsNullOrEmpty()---------------------------------------------------------------------------

        // String IsNullOrWhiteSpace()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String IsNullOrWhiteSpace()");
        Console.WriteLine();
        string st5 = " ";
        string st6 = "";
        bool bl1 = string.IsNullOrWhiteSpace(st1);
        bool bl2 = string.IsNullOrWhiteSpace(st2);
        bool bl3 = string.IsNullOrWhiteSpace(st5);
        bool bl4 = string.IsNullOrWhiteSpace(st6);
        Console.WriteLine(bl1);
        Console.WriteLine(bl2);
        Console.WriteLine(bl3);
        Console.WriteLine(bl4);
        Console.WriteLine();

        //End of IsNullOrWhiteSpace()-----------------------------------------------------------------------------

        // String Join()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String Join()");
        Console.WriteLine();
        string[] arrayStr = { "Sagar", "Riya", "Tisha", "Raj" };
        string str1 = string.Join(",", arrayStr);
        Console.WriteLine(str1);
        Console.WriteLine();

        //End of Join()-------------------------------------------------------------------------

        // String LastIndexOf()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String LastIndexOf()");
        Console.WriteLine();
        int index1 = st1.LastIndexOf('f');
        Console.WriteLine(index1);
        Console.WriteLine();

        //End of LastIndexOf()-------------------------------------------------------------------------

        // String LastIndexOfAny()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String LastIndexOfAny()");
        Console.WriteLine();
        char[] char1 = { 'M', 's' };
        int index2 = string1.LastIndexOfAny(char1);
        Console.WriteLine(index2);
        Console.WriteLine();

        // End of LastIndexOfAny()-----------------------------------------------------------------------

        // String StartWith()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String StartWith()");
        Console.WriteLine();
        bool bll1 = string1.StartsWith('H');
        bool bll2 = string1.StartsWith('h');
        if(bll1 == true)
        {
            Console.WriteLine("The first letter is capital, " + bll1);
        }
        else if(bll2 == true)
        {
            Console.WriteLine("The first letter is not capital" + bll2);
        }
        else
        {
            Console.WriteLine("Sorry Wrong entry");
        }


        //End of StartWith()--------------------------------------------------------------------------------

        // String PadLeft()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String PadLeft()");
        Console.WriteLine();
        string padLeft = string1.PadLeft(12);
        Console.WriteLine(padLeft);
        padLeft = string1.PadLeft(10);
        Console.WriteLine();

        //End of PadLeft()------------------------------------------------------------------------

        // String PadRight()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String PadRight()");
        Console.WriteLine();
        string padRight = string1.PadRight(1);
        Console.Write(padLeft);
        Console.Write(", Hope you are doing worste.");
        Console.WriteLine();

        //End of PadRight()--------------------------------------------------------------------

        // String Remove()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String Remove()");
        Console.WriteLine();
        string remove = string1.Remove(5);
        Console.WriteLine(remove);
        Console.WriteLine();

        //End of Remove()------------------------------------------------------------------------------------

        // String Replace()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String Replace()");
        Console.WriteLine();
        string replace = string1.Replace('H', 'M');
        Console.WriteLine(replace);
        Console.WriteLine();

        //End of Replace()------------------------------------------------------------------------

        // String Split()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String Split()");
        Console.WriteLine();
        string[] split = string1.Split(' ');
        foreach(string splitForEach in split)
        {
            Console.WriteLine(splitForEach);
        }

        //End of Spit()---------------------------------------------------------------------------------

        // String SubString()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String SubString()");
        Console.WriteLine();
        string subString = string1.Substring(6);
        Console.WriteLine(subString);
        Console.WriteLine();

        //End of SubString()---------------------------------------------------------------------------------

        // String ToCharArray()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String ToCharArray()");
        Console.WriteLine();
        char[] toCharArray = string1.ToCharArray();
        foreach(char item   in toCharArray)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();

        //End of ToCharArray()-------------------------------------------------------------

        // String ToLower() & ToUpper() & ToLowerInvariant()--------------------------------------------------------------------------

        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine(" " + "String ToLower & ToUpper & ToLowerInvariant()");
        Console.WriteLine();
        Console.WriteLine(string1.ToLower());
        Console.WriteLine(string1.ToUpper());
        Console.WriteLine(string1.ToLowerInvariant());
        Console.WriteLine();

        //End of ToLower() & ToUpper() & ToLowerInvariant()------------------------------------------------------------------

       
        




    }

}




   