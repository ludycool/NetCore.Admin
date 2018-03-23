// File:    RMS_Menus.cs
// Author:  Administrator
// Created: 2016��7��22�� ������ 17:53:02
// Purpose: Definition of Class RMS_Menus


using Core.PetaPocoServer;
using System;
namespace Web.Sys.Model.RMS
{
    /// v_rms_menus�˵�
    [TableName("v_rms_menus")]
    [PrimaryKey("id", autoIncrement = true)]
    public class v_rms_menus
    {
        public Int32 id { get; set; }
        /// <summary>
        /// �ϼ�id
        /// </summary>
        public int parentmanuid
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



        /// <summary>
        /// ����
        /// </summary>
        public string manuname
        {
            get;
            set;
        }



        /// <summary>
        /// ��ת��ַ
        /// </summary>
        public string url
        {
            get;
            set;
        }



        /// <summary>
        /// ͼ��
        /// </summary>
        public string icon
        {
            get;
            set;
        }



        /// <summary>
        /// ��ͼ��
        /// </summary>
        public string micon
        {
            get;
            set;
        }



        /// <summary>
        /// ��ע
        /// </summary>
        public string remarks
        {
            get;
            set;
        }



        /// <summary>
        /// ���ʱ��
        /// </summary>
        public DateTime createtime
        {
            get;
            set;
        }



        /// <summary>
        /// ����ʱ��
        /// </summary>
        public DateTime modifytime
        {
            get;
            set;
        }



        /// <summary>
        /// �Ƿ����
        /// </summary>
        public bool isenable
        {
            get;
            set;
        }



        /// <summary>
        /// �Ƿ���ʾ
        /// </summary>
        public bool isshow
        {
            get;
            set;
        }
        /// <summary>
        /// ���� 0���� 1���ϣ����Ӽ� �����ã� 2 ���ӣ�����ַ �ṩ��ת���ܣ�
        /// </summary>
        public Int16 typeid
        {
            get;
            set;

        }
        /// <summary>
        /// ֵ�����
        /// </summary>
        public string valuename
        {
            get;
            set;
        }
        /// <summary>
        /// ��˾
        /// </summary>
        public int companyid
        {
            get;
            set;

        }
        /// <summary>
        /// ��Ŀ
        /// </summary>
        public int projectid
        {
            get;
            set;

        }
        /// <summary>
        /// ��Ŀ��
        /// </summary>
        public string projectname
        {
            get;
            set;

        }

    }
}