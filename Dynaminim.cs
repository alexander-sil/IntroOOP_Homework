using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynaminimNamespace
{
    class Dynaminim
    {
        public Dynaminim()
        {
            ;
        }
        public void ArrayPush<T>(ref T[] table, object value)
        {
            Array.Resize(ref table, table.Length + 1);
            table.SetValue(value, table.Length - 1);
        }
        public object ArrayPop<T>(ref T[] table)
        {
            object y = table[table.Length - 1];
            Array.Resize(ref table, table.Length - 1);
            return y;
        }

        public void ArrayEven(int[] table)
        {

            for (int i = 0; i < table.Length; i++)
            {
                if (i % 2 == 0)
                {
                    table.SetValue(i, i);
                }
                else
                {
                    table.SetValue(0, i);
                }
            }
        }

        
        public object[] UtilCleanOthers(object[] sourceTable)
        {
            object[] buffer = new object[] { };
            int i = 0;
            while (i < sourceTable.Length)
            {
                if (sourceTable[i] == null || Convert.ToUInt32(sourceTable[i]) == 0 || Convert.ToBoolean(sourceTable[i]) == false || Convert.ToInt32(sourceTable[i]) == 0 || Convert.ToInt64(sourceTable[i]) == 0L || Convert.ToDecimal(sourceTable[i]) == 0M || Convert.ToDouble(sourceTable[i]) == 0.0 || Convert.ToSByte(sourceTable[i]) == 0 || Convert.ToByte(sourceTable[i]) == 0)
                {
                    ;
                }
                else
                {
                    ArrayPush(ref buffer, sourceTable[i]);
                }
                i = i + 1;
            }
            return buffer;
        }
        public int[] UtilCleanZeros(int[] sourceTable)
        {
            int[] buffer = new int[] { };
            int i = 0;
            while (i < sourceTable.Length)
            {
                if (sourceTable[i] == 0)
                {
                    ;
                }
                else
                {
                    ArrayPush(ref buffer, sourceTable[i]);
                }
                i = i + 1;
            }
            return buffer;
        }

        public string[] UtilCleanEmStrs(string[] sourceTable)
        {
            string[] buffer = new string[] { };
            int i = 0;
            while (i < sourceTable.Length)
            {
                if (sourceTable[i] == "")
                {
                    ;
                }
                else
                {
                    ArrayPush(ref buffer, sourceTable[i]);
                }
                i = i + 1;
            }
            return buffer;
        }
        public object ArraySliceNulls<T>(ref T[] table)
        {
            if (table is int[])
            {
                int[] arr = table.Cast<int>().ToArray();
                int[] copyint = UtilCleanZeros(arr);
                return copyint;
            }
            else if (table is string[])
            {
                string[] arr = table.Cast<string>().ToArray();
                string[] copystr = UtilCleanEmStrs(arr);
                return copystr;
            }
            else
            {
                object[] arr = table.Cast<object>().ToArray();
                object[] copyobj = UtilCleanOthers(arr);
                return copyobj;
            }

        }
        public object[] UtilSliceSpecific(object[] table, int index)
        {
            object[] buffer = new object[] { };
            int i = 0;
            while (i < table.Length)
            {
                if (table[i] == table[index])
                {
                    ;
                }
                else
                {
                    ArrayPush(ref buffer, table[i]);
                }
                i = i + 1;
            }
            return buffer;
        }
        public void ArrayDelSlice<T>(ref T[] table, int index)
        {
            if (table is int[])
            {
                table.SetValue(0, index);
                table = (T[])ArraySliceNulls(ref table);
            }
            else if (table is string[])
            {
                table.SetValue("", index);
                table = (T[])ArraySliceNulls(ref table);
            }
            else
            {
                table.SetValue(null, index);
                table = (T[])ArraySliceNulls(ref table);
            }

        }
        public object[] ArraySliceSpecific(object[] table, int index)
        {

            object[] array = new object[] { };
            array = UtilSliceSpecific(table, index);
            return array;
        }

        public object[] ArraySlice<T>(ref T[] table, int index)
        {


            object[] arr = table.Cast<object>().ToArray();
            object[] copyobj = UtilSliceSpecific(arr, index);
            return copyobj;

        }

        public void ArrayShiftHeadless<T>(ref T[] table)
        {
            try
            {
                if (table is int[])
                {
                    table.SetValue(0, 0);
                }
                else if (table is string[])
                {
                    table.SetValue("", 0);
                }
                else if (table is byte[])
                {
                    table.SetValue(0, 0);
                }
                else if (table is bool[])
                {
                    table.SetValue(false, 0);
                }
                else if (table is uint[])
                {
                    table.SetValue(0, 0);
                }
                else if (table is double[])
                {
                    table.SetValue(0.0, 0);
                }
                else if (table is decimal[])
                {
                    table.SetValue(0M, 0);
                }
                else if (table is long[])
                {
                    table.SetValue(0L, 0);
                } else if (table is object[])
                {
                    table.SetValue(null, 0);
                }
                table = (T[])ArraySliceNulls(ref table);
            } catch
            {
                Console.WriteLine("Type error: the array of the specified type is not suitable for shifting");
            }
            
        }
        public void ArrayUnshift<T>(ref T[] table, object value)
        {
            T[] buffer = new T[] { };
            for (int i = 0; i < table.Length; i++)
            {
                ArrayPush(ref buffer, table[i]);
            }
            Array.Resize(ref table, table.Length + 1);
            table.SetValue(value, 0);
            Array.Copy(buffer, 0, table, 1, table.Length - 1);
        }
        public void ArrayEraseFRight<T>(ref T[] table, int x)
        {
            int n = table.Length - x;
            Array.Clear(table, n, x);
        }
    }
}
