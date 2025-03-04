using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_SketchVer
{
    internal class GlobalVar
    {
        public static string image_dir = @"C:\Users\iSpan\Documents\Dilemma\WF_DilemmaProject\ItemPicture"; // 教室用
        //public static string image_dir = @"D:\下載\Dilemma\WF_DilemmaProject\ItemPicture"; // 家用

        public static string strDBConnectionString = "";
        public static List<ArrayList> listOrderCollection = new List<ArrayList>();
    }
}
