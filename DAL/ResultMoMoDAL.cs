using DTO;
using System.Linq;

namespace DAL
{
    public class ResultMoMoDAL
    {
        private readonly PinkCosmetics _dataContext = new PinkCosmetics();

        /// <summary>
        /// Get transaction result by MoMo
        /// </summary>
        /// <param name="orderId">Request ID</param>
        /// <returns></returns>
        public tb_ResultMoMo GetResultMoMo(string orderId)
        {
            return _dataContext.tb_ResultMoMo.FirstOrDefault(x => x.OrderID == orderId);
        }

        /// <summary>
        /// Insert transaction reference to the database
        /// </summary>
        /// <param name="resultMoMo"></param>
        /// <returns></returns>
        public int Insert(tb_ResultMoMo resultMoMo)
        {
            try
            {
                _dataContext.tb_ResultMoMo.Add(resultMoMo);
                return _dataContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
    }
}