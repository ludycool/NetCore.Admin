// File:    RMS_RoleManuButtons.cs
// Author:  Administrator
// Created: 2016��7��22�� ������ 17:53:02
// Purpose: Definition of Class RMS_RoleManuButtons


using Core.PetaPocoServer;
using System;
namespace Web.Sys.Model.RMS
{
    /// RMS_RoleManuButtons��ɫ�˵��İ�ť��
    [TableName("rms_rolemanubuttons")]
    [PrimaryKey("id", autoIncrement = true)]
    public class rms_rolemanubuttons 
    {
        public int id { get; set; }
        /// <summary>
        /// ��ɫ��id
        /// </summary>
        public string roleid
        {
            get;
            set;
        }



        /// <summary>
        /// �˵��İ�ť��id
        /// </summary>
        public string menubuttonsid
        {
            get;
            set;
        }

    }
}