// File:    RMS_Buttons.cs
// Author:  Administrator
// Created: 2016��7��22�� ������ 17:53:02
// Purpose: Definition of Class RMS_Buttons


using Core.PetaPocoServer;
using System;
namespace Web.Sys.Model.RMS
{
    /// RMS_Buttons��ť
    [TableName("rms_buttons")]
    [PrimaryKey("id", autoIncrement = true)]
    public class rms_buttons 
    {

        public Int32 id { get; set; }
        public string buttonname
        {
            set;
            get;
        }
        /// <summary>
        /// ����
        /// </summary>
        public Int32? orderno
        {
            set;
            get;
        }
        /// <summary>
        /// ͼ��
        /// </summary>
        public string icon
        {
            set;
            get;
        }
        /// <summary>
        /// ��ע
        /// </summary>
        public string remarks
        {
            set;
            get;
        }
        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime? createtime
        {
            set;
            get;
        }
        public DateTime? modifytime
        {
            set;
            get;
        }
        /// <summary>
        /// ֵ
        /// </summary>
        public string valuename
        {
            set;
            get;
        }
        /// <summary>
        /// ����
        /// </summary>
        public string functionname
        {
            set;
            get;
        }

    }
}