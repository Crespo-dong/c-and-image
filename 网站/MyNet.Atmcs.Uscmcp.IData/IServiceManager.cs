using System.Data;

namespace MyNet.Atmcs.Uscmcp.IData
{
    public interface IServiceManager
    {
        #region ��ѯ��ط���

        /// <summary>
        ///�����ԱΨһ���usercode
        /// </summary>
        /// <param name="head"></param>
        /// <param name="totalLength"></param>
        /// <returns></returns>
        string GetRecordID(string head, int totalLength);

        /// <summary>
        ///��ѯ��Ա��Ϣ
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetSevice(string where);

        /// <summary>
        ///��ѯ��Ա��Ϣ
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetSeviceby(string where);

        /// <summary>
        ///�����Ա
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int insertSevice(System.Collections.Hashtable hs);

        /// <summary>
        ///������Ա��Ϣ
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int updateSevice(System.Collections.Hashtable hs);

        /// <summary>
        /// ɾ����Ա��Ϣ
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteSevice(string id);

        /// <summary>
        ///��ȡ�ص㳵����Ϣ
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetVehicles(string where);

        /// <summary>
        ///��ȡ�ص㳵����Ϣ
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetVehiclese(string where);
        
        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int insertVehicles(System.Collections.Hashtable hs);

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int updateVehicles(System.Collections.Hashtable hs);

        /// <summary>
        ///ɾ���ص㳵����Ϣ
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteVehicles(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int insertarea(System.Collections.Hashtable hs);

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int insertarea_person(System.Collections.Hashtable hs);

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int insertarea_person_beixuan(System.Collections.Hashtable hs);

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int insertarea_class(System.Collections.Hashtable hs);

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int insertarea_time(System.Collections.Hashtable hs);

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int UpdateSevPerson(System.Collections.Hashtable hs);

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int UpdatePostandTime(System.Collections.Hashtable hs);

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        DataTable GetArea();

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        DataTable GetClass();

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        DataTable AreaCount();

        /// <summary>
        ///
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable SlectArea(string where);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable SlectAreaid(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable SlectPersonid(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable SlectPersonbakid(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable CountPerson(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable CountPersonbak(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable CountClass(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable Classtype(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable CountTime(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable SlectTimeid(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable SlectCLASSid(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable SlectPersontype(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable GetSevPerson(string where);

        /// <summary>
        /// ��ò�����Ա����
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable PersonbyDepartid(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable Postadtime(string where);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteArea(string id);

        /// <summary>
        /// ɾ����Ա��Ϣ
        /// </summary>
        /// <param name="dutypost"></param>
        /// <param name="departid"></param>
        /// <returns></returns>
        int DeletePerson(string dutypost, string departid);

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int insertTrafficControl(System.Collections.Hashtable hs);

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int updateTrafficControl(System.Collections.Hashtable hs);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteTrafficControl(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable SeleteTrafficControl(string where);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable SeleteTrafficControlid(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int insertJeeves(System.Collections.Hashtable hs);

        /// <summary>
        ///
        /// </summary>
        /// <param name="hs"></param>
        /// <returns></returns>
        int updateJeeves(System.Collections.Hashtable hs);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteJeeves(string id);

        /// <summary>
        ///
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        DataTable SeleteJeeves(string where);

        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        DataTable SeleteJeevesid(string id);

        # endregion
    }
}