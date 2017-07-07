/***********************************************************************
 * Module:   Ŀ¼ҵ���߼���
 * Author:   �ƽ
 * Modified: 2008��10��17��
 * Purpose:  ����Ϊҳ���ṩ��Ҫ��ҵ���߼�����
 ***********************************************************************/

using MyNet.Atmcs.Uscmcp.IData;
using MyNet.Common.Log;
using System;
using System.Collections;
using System.Data;

namespace MyNet.Atmcs.Uscmcp.Bll
{
    /// <summary>
    ///
    /// </summary>
    [Serializable]
    public class SystemManager
    {
        /// <summary>
        ///  �û������ӿ�
        /// </summary>
        private static readonly ISystemManager dal = DALFactory.CreateSystemManager();

        /// <summary>
        /// ���ϵͳ����
        /// </summary>
        /// <param name="systemId">ϵͳ���</param>
        /// <returns></returns>
        public string GetSystemName(string systemId)
        {
            try
            {
                return dal.GetSystemInfo(systemId).Rows[0]["systemname"].ToString();
            }
            catch (Exception ex)
            {
                ILog.WriteErrorLog(ex);
                return "";
            }
        }

        /// <summary>
        /// ��õ�ǰϵͳ��Ϣ
        /// </summary>
        /// <param name="systemId">ϵͳ���</param>
        /// <returns></returns>
        public DataTable GetSystemInfo(string systemId)
        {
            try
            {
                DataTable dt = dal.GetSystemInfo(systemId);
                return Bll.Common.ChangColName(dt);
            }
            catch (Exception ex)
            {
                ILog.WriteErrorLog(ex);
                return null;
            }
        }

        /// <summary>
        /// �������ϵͳ��Ϣ
        /// </summary>
        /// <returns></returns>
        public DataTable GetSystemInfo()
        {
            try
            {
                DataTable dt = dal.GetSystemInfo();
                return Bll.Common.ChangColName(dt);
            }
            catch (Exception ex)
            {
                ILog.WriteErrorLog(ex);
                return null;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public DataTable GetCodeTypeData()
        {
            try
            {
                DataTable dt = dal.GetCodeType();
                return Bll.Common.ChangColName(dt);
            }
            catch (Exception ex)
            {
                ILog.WriteErrorLog(ex);
                return null;
            }
        }

        /// <summary>
        /// ��ȡ�ֵ���
        /// </summary>
        /// <param name="codeType"></param>
        /// <returns></returns>
        public DataTable GetCodeData(string codeType)
        {
            try
            {
                DataTable dt = dal.GetCode(codeType);
                return Bll.Common.ChangColName(dt);
            }
            catch (Exception ex)
            {
                ILog.WriteErrorLog(ex);
                return null;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        public int UpdateSysCode(Hashtable hs)
        {
            try
            {
                return dal.UpdateSysCode(hs);
            }
            catch (Exception ex)
            {
                ILog.WriteErrorLog(ex);
                return -1;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        public int DelSysCode(Hashtable hs)
        {
            try
            {
                return dal.DelSysCode(hs);
            }
            catch (Exception ex)
            {
                ILog.WriteErrorLog(ex);
                return -1;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        public int AddSysCode(Hashtable hs)
        {
            try
            {
                return dal.AddSysCode(hs);
            }
            catch (Exception ex)
            {
                ILog.WriteErrorLog(ex);
                return -1;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public DataTable GetSysFunction()
        {
            try
            {
                DataTable dt = dal.GetSysFunction();
                return Bll.Common.ChangColName(dt);
            }
            catch (Exception ex)
            {
                ILog.WriteErrorLog(ex);
                return null;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="funcId"></param>
        /// <returns></returns>
        public DataTable GetSysFunction(string funcId)
        {
            try
            {
                DataTable dt = dal.GetSysFunction(funcId);
                return dt;
            }
            catch (Exception ex)
            {
                ILog.WriteErrorLog(ex);
                return null;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        public int DelSysFunction(Hashtable hs)
        {
            try
            {
                return dal.DelSysFunction(hs);
            }
            catch (Exception ex)
            {
                ILog.WriteErrorLog(ex);
                return -1;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        public int UpdateSysFunction(Hashtable hs)
        {
            try
            {
                return dal.UpdateSysFunction(hs);
            }
            catch (Exception ex)
            {
                ILog.WriteErrorLog(ex);
                return -1;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        public int AddSysFunction(Hashtable hs)
        {
            try
            {
                return dal.AddSysFunction(hs);
            }
            catch (Exception ex)
            {
                ILog.WriteErrorLog(ex);
                return -1;
            }
        }

        /// <summary>
        /// ���ɼ�¼ID
        /// </summary>
        /// <param name="head"></param>
        /// <param name="totalLength"></param>
        /// <returns></returns>
        public string GetRecordID(string head, int totalLength)
        {
            try
            {
                return dal.GetRecordID(head, totalLength);
            }
            catch (Exception ex)
            {
                ILog.WriteErrorLog(ex);
                return "";
            }
        }
    }
}