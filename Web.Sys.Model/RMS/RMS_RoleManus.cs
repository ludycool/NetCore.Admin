// File:    RMS_RoleManus.cs
// Author:  Administrator
// Created: 2016��7��22�� ������ 17:53:02
// Purpose: Definition of Class RMS_RoleManus


using Core.PetaPocoServer;
using System;
namespace Web.Sys.Model.RMS
{
    /// RMS_RoleManus��ɫ�˵�
    [TableName("rms_rolemanus")]
    [PrimaryKey("id", autoIncrement = true)]
    public class rms_rolemanus 
    {

        public Int32 id { get; set; }

        /// <summary>
        /// ��ɫ��id
        /// </summary>
        public string roleid
        {
            get;
            set;
        }



        /// <summary>
        /// �˵���id
        /// </summary>
        public int manuid
        {
            get;
            set;
        }

    }
}