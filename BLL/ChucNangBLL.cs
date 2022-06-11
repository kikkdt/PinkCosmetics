using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class ChucNangBLL
    {
        /// <summary>
        /// Get a list of features
        /// </summary>
        /// <returns></returns>
        public static List<tb_ChucNang> GetFeatures()
        {
            return new ChucNangDAL().GetFeatures();
        }

        /// <summary>
        /// Get a feature
        /// </summary>
        /// <param name="name">Feature name</param>
        /// <returns></returns>
        public static tb_ChucNang GetFeature(string name)
        {
            return new ChucNangDAL().GetFeature(name);
        }
    }
}