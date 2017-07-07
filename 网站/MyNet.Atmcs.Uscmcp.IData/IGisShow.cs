using System.Data;

namespace MyNet.Atmcs.Uscmcp.IData
{
    public interface IGisShow
    {
        #region ��ѯ��ط���

        /// <summary>
        /// ��ñ�ע����Ϣ
        /// </summary>
        /// <param name="where">����</param>
        /// <returns></returns>
        DataTable GetMapLable(string where);

        /// <summary>
        /// ����豸״̬�ĵ�ͼ�����Ϣ
        /// </summary>
        /// <returns></returns>
        DataTable GetDeviceStateMap();

        /// <summary>
        /// ���¼������Ϣ
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int UpdatePointInfo(System.Collections.Hashtable hs);

        /// <summary>
        /// ɾ���������Ϣ
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int DeletePointInfo(System.Collections.Hashtable hs);

        /// <summary>
        ///
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetStationInfo(string xh);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetCCTV(string where);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetFlow(string tableName, string kkid,string strdate,string xs);

        /// <summary>
        ///
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetTgsStation(string where);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetComStation(string where);

        /// <summary>
        ///
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetTgsStationFlowInfo(string where);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="directionId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        DataTable PassCarHourFlow(string directionId, string date);
        string GetSysCodedesc(string codetype, string code);
        /// <summary>
        /// �������м�������
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetStationType(string where);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int UpdateStationType(System.Collections.Hashtable hs);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetTesEvent(string where);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int DeleteKmlInfo(System.Collections.Hashtable hs);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int InsertKmlInfo(System.Collections.Hashtable hs);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetGisRoad(string where);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetGisRoadKml(string where);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetTfmFlowState(string where);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetTgsAreaFlowState(string where);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int UpdateGisMark(System.Collections.Hashtable hs);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetStationPoint(string where);
        /// <summary>
        /// ��ü��� ��ע״̬��Ϣ
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetGisDeviceList(string where);

        /// <summary>
        /// �������Ͳ�ѯ
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        DataTable GetMarkArray(string type);

        /// <summary>
        /// �޸�MarkArrays
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int UpdataMarkArray(string id, string markarray);

        # endregion
        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetGPSDeviceList(string where);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        DataTable GetFlowState(string tableName);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        DataTable GetPgis(string type);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="led_id"></param>
        /// <returns></returns>
        string GetLastProjectId(string led_id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ProjectId"></param>
        /// <returns></returns>
        DataTable GetProgramListByProject(string ProjectId);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="programid"></param>
        /// <returns></returns>
        DataTable GetProgramInfo(string programid);
        /// <summary>
        /// ��ȡ��ͨ������Ϣ
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetTraffInfo(string where);
        /// <summary>
        /// ����ʩ��ռ����Ϣ
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetConstructionInfo(string where);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int UpdataTraffInfo(System.Collections.Hashtable hs);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int UpdataConstructionInfo(System.Collections.Hashtable hs);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetRoadSegInfo(string where);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetRoadVDInfo(string where);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetRoadSegPointInfo(string where);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int UpdataRoadState(System.Collections.Hashtable hs);
    }
}