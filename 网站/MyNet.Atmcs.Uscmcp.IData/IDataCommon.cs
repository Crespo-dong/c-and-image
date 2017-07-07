using System.Data;

namespace MyNet.Atmcs.Uscmcp.IData
{
    /// <summary>
    /// ͨ�����ݲ�����
    /// </summary>
    public interface IDataCommon
    {
        #region ��ѯ��ط���

        /// <summary>
        /// ִ�в�ѯdatatable����
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        DataTable GetDataTable(string strSQL);

        /// <summary>
        /// ִ�л��stringSQL����
        /// </summary>
        /// <param name="mySql"></param>
        /// <returns></returns>
        string GetString(string strSQL);

        /// <summary>
        ///  ִ��UpdateSQL���
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int Update(string strSQL);

        /// <summary>
        /// ִ��Insert����
        /// </summary>
        /// <param name="mySql"></param>
        /// <returns></returns>
        int Insert(string strSQL);

        /// <summary>
        ///ִ��Delete����
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        int Delete(string strSQL);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="url1"></param>
        /// <param name="url2"></param>
        /// <param name="url3"></param>
        /// <returns></returns>
        DataTable ChangeDataTablePoliceIp(DataTable dt, string url1, string url2, string url3);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        string ChangePoliceIp(string url);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ipaddress"></param>
        /// <returns></returns>
        string ChangeIp(string ipaddress);

        # endregion
    }
}