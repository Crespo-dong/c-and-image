using System.Collections.Generic;
using System.Data;
using MyNet.DataAccess.Model;

namespace MyNet.Atmcs.Uscmcp.IData
{
    /// <summary>
    /// �豸����ӿ�
    /// </summary>
    public interface IDeviceManager
    {
        #region ��ѯ��ط���

        /// <summary>
        ///
        /// </summary>
        /// <param name="systemId"></param>
        /// <returns></returns>
        DataTable GetConfigDepartment(string systemId);

        /// <summary>
        /// �����豸��ϸ��Ϣ
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int insertDevice(System.Collections.Hashtable hs);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable GetSelectDevice(string id);

        /// <summary>
        /// �����豸��ϸ��Ϣ
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int uptateDevice(System.Collections.Hashtable hs);

        /// <summary>
        /// �����豸��ά��Ϣ
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetOperation(string where);

        /// <summary>
        /// ¼���豸��ά��Ϣ
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int insertOperation(System.Collections.Hashtable hs);

        /// <summary>
        ///�����豸����ά��Ϣ
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int uptateOperation(System.Collections.Hashtable hs);

        /// <summary>
        /// ��ѯѡ���豸����ά��Ϣ
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetSelectOperation(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteOperation(string id);

        /// <summary>
        /// ����豸��άͳ��
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetTongJi(string where);

        /// <summary>
        ///
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetTreeDepartment(string where);

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int insertDevices(System.Collections.Hashtable hs);

        /// <summary>
        /// �޸��豸��Ϣ
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int uptateDevices(System.Collections.Hashtable hs);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteKaKou(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteCCTV(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteLED(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        DataTable GetTypeCout(string type);

        /// <summary>
        ///
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        DataTable GetDevState(string type);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable GetDeviceState_lock_id(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="field"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetTGSSetting(string field, string where);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteDeviceSetting(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int UptateDeviceSetting(System.Collections.Hashtable hs);

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int InsertDeviceSetting(System.Collections.Hashtable hs);

        /// <summary>
        ///��ȡ������Ϣ
        /// </summary>
        /// <param name="field"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetCctvSetting(string field, string where);

        /// <summary>
        ///ɾ��������Ϣ
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteCctvSetting(string id);

        /// <summary>
        ///�޸�������Ϣ
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int UptateCctvSetting(System.Collections.Hashtable hs);

        /// <summary>
        ///���������Ϣ
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int InsertCctvSetting(System.Collections.Hashtable hs);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="field"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetUTCSetting(string field, string where);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteUtcSetting(string id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int UptateUtcSetting(System.Collections.Hashtable hs);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int InsertUtcSetting(System.Collections.Hashtable hs);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="field"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetVMSSetting(string field, string where);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteVmsSetting(string id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int UptateVmsSetting(System.Collections.Hashtable hs);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int InsertVmsSetting(System.Collections.Hashtable hs);

        /// <summary>
        /// ��ü�������������Ϣ
        /// </summary>
        /// <returns></returns>
        DataTable GetStationTypeByDevice();

        /// <summary>
        /// ��ѯ�����豸״̬
        /// </summary>
        /// <param name="field"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetStationDeviceState(string field, string where);

        /// <summary>
        ///
        /// </summary>
        /// <param name="field"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetNoDeviceState(string field, string where);

        /// <summary>
        ///
        /// </summary>
        /// <param name="field"></param>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetServiceState(string field, string where);

        /// <summary>
        ///���·�������Ϣ
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int UptateServerInfo(System.Collections.Hashtable hs);

        /// <summary>
        /// �����豸��Ϣ
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int UptateDeviceInfo(System.Collections.Hashtable hs);

        /// <summary>
        /// ��ѯ�豸��Ϣ
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetDevice(string where);
        DataTable GetHistoryDevice(string where);

        /// <summary>
        /// ɾ���豸��Ϣ
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteDevice(string id);

        /// <summary>
        /// ���������豸����
        /// </summary>
        /// <returns></returns>
        DataTable GetDeviceType();

        /// <summary>
        /// ��������������ѯ�豸����
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetDeviceTypeMode(string where);

        /// <summary>
        ///
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetBussiness(string where);

        /// <summary>
        /// ��ѯ�豸��Ϣ
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetDeviceInfo(string where);

        /// <summary>
        ///  ��ѯ����������
        /// </summary>
        /// <returns></returns>
        DataTable GetServerType();

        /// <summary>
        /// ��������������ѯ����������
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetServerTypeMode(string where);

        /// <summary>
        /// ��ѯ��������Ϣ
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetServerInfo(string where);

        /// <summary>
        /// ɾ����������Ϣ
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteServerInfo(string id);

        /// <summary>
        ///��ѯ��������Ϣ
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetServer(string where);

        /// <summary>
        ///
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetTableSpace(string where);

        # endregion

        #region 2015����

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        DataTable GetBuildAll();

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        DataTable GetMaintainAll();

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        DataTable GetMakeAll();

        /// <summary>
        /// ��������豸����
        /// </summary>
        /// <returns></returns>
        DataTable GetDeviceTypeAll();

        /// <summary>
        /// �����豸���ͻ�ö�Ӧ�豸������Ϣ
        /// </summary>
        /// <param name="deviceType"></param>
        /// <returns></returns>
        DataTable GetDevModeByDeviceType(string deviceType);

        /// <summary>
        /// �����豸���ͻ�ö�Ӧ�豸��Ϣ
        /// </summary>
        /// <param name="devType"></param>
        /// <returns></returns>
        DataTable GetDeviceByDeviceType(string deviceType);

        /// <summary>
        /// ���ݲ�ѯ������ѯ�豸��ϸ��Ϣ
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetDeviceByMore(string where);

        /// <summary>
        ///
        /// </summary>
        /// <param name="listdev"></param>
        /// <returns></returns>
        int InsertListDevice(List<DevcieInfo> listdev);

        /// <summary>
        /// �����豸��Ϣ
        /// </summary>
        /// <param name="devcieInfo"></param>
        /// <returns></returns>
        int InsertDeviceInfo(DevcieInfo devcieInfo);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        DataTable GetServerTypeAll();

        /// <summary>
        ///
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetServerByMore(string where);

        /// <summary>
        ///
        /// </summary>
        /// <param name="deviceType"></param>
        /// <returns></returns>
        DataTable GetServerByTypeID(string deviceType);

        # endregion
    }
}