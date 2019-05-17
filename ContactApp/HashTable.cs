using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    public class HashTable
    {
        private List<HashTableItem> vecItems;

        public HashTable()
        {
            this.vecItems = new List<HashTableItem>();
        }

        public HashTableItem this[int index]
        {
            get
            {
                return this.vecItems[index];
            }
        }
        private static bool hasFilter(string strString, string strFilter)
        {
            string strStringL = strString.ToLower();
            string strFilterL = strFilter.ToLower();
            int iStrlen = strFilterL.Length;
            if (strStringL.Length < iStrlen)
                return false;
            for (int i = 0; i < iStrlen; i++)
            {
                if (strFilterL[i] != strStringL[i])
                    return false;
            }
            return true;
        }
        public void Get(string strFilter, ref CBook lpCBook)
        {
            for (int i = 0; i < lpCBook.Count(); i++)
            {
                if (HashTable.hasFilter(lpCBook[i].SName, strFilter) || HashTable.hasFilter(lpCBook[i].Name, strFilter))
                    this.vecItems.Add(new HashTableItem(i, lpCBook[i].SName));
            }

            UInt64 iMin;
            int iMinPos;
            int iCount = this.vecItems.Count();
            for (int i = 0; i < iCount - 1; i++)
            {
                iMin = this.vecItems[i].iCashedString;
                iMinPos = i;
                for (int j = i + 1; j < iCount; j++)
                {
                    if (this.vecItems[j].iCashedString <= iMin)
                    {
                        iMin = this.vecItems[j].iCashedString;
                        iMinPos = j;
                    }
                }
                HashTableItem temp = this.vecItems[i];
                this.vecItems[i] = this.vecItems[iMinPos];
                this.vecItems[iMinPos] = temp;
            }
        }
        public void Clear()
        {
            this.vecItems.Clear();
        }

        public int Count()
        {
            return this.vecItems.Count();
        }

        public Contact GetContact(int iIndex, ref CBook lpCBook)
        {
            return lpCBook[this.vecItems[iIndex].iIndex];
        }
    }
    public class HashTableItem
    {
        public int iIndex;
        public UInt64 iCashedString;

        private static UInt64 pow(UInt64 iNum, UInt64 iPower)
        {
            UInt64 iRet = 1;
            for (UInt64 i = 0; i < iPower; i++)
            {
                iRet = iRet * iNum;
            }
            return iRet;
        }

        public HashTableItem(int iIndex, string strString)
        {
            this.iIndex = iIndex;
            this.iCashedString = 0;
            int iStrlen = strString.Length;
            int iNum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i < iStrlen)
                {
                    if (strString[i] >= 'а' && strString[i] <= 'я')
                        iNum = (int)(strString[i] - 'а' + 1);
                    else if (strString[i] >= 'А' && strString[i] <= 'Я')
                        iNum = (int)(strString[i] - 'А' + 1);
                    else
                        iNum = 0;
                }
                else
                    iNum = 0;
                this.iCashedString += (UInt64)iNum * HashTableItem.pow((UInt64)(33), (UInt64)(9 - i));
            }
        }

        
    }
}
