using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class ChucNangDAL
    {
        private readonly PinkCosmetics _dataContext = new PinkCosmetics();

        /// <summary>
        /// Get a list of features
        /// </summary>
        /// <returns></returns>
        public List<tb_ChucNang> GetFeatures()
        {
            return _dataContext.tb_ChucNang.ToList();
        }

        /// <summary>
        /// Get a feature
        /// </summary>
        /// <param name="name">Feature name</param>
        /// <returns></returns>
        public tb_ChucNang GetFeature(string name)
        {
            return _dataContext.tb_ChucNang.FirstOrDefault(x => x.MaChucNang == name);
        }
    }
}