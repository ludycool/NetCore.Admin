// File:    RMS_MenuButtons.cs
// Author:  Administrator
// Created: 2016��7��22�� ������ 17:53:02
// Purpose: Definition of Class RMS_MenuButtons


using Core.PetaPocoServer;
using System;
namespace Web.Sys.Model.RMS
{
    /// RMS_MenuButtons�˵��İ�ť
    [TableName("rms_menubuttons")]
    [PrimaryKey("id", autoIncrement = true)]
    public class rms_menubuttons 
    {

        public int id { get; set; }
        /// <summary>
        /// ��ť��id
        /// </summary>
        public int buttonid
        {
            get;
            set;
        }



        /// <summary>
        /// �˵�id
        /// </summary>
        public int manuid
        {
            get;
            set;
        }



        /// <summary>
        /// ����
        /// </summary>
        public int orderno
        {
            get;
            set;
        }

    }
}