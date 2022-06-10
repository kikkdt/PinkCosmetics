using DAL;
using DTO;

namespace BLL
{
    public class ResultMoMoBLL
    {
        /// <summary>
        /// Get transaction result by MoMo
        /// </summary>
        /// <param name="orderId">Request ID</param>
        /// <returns></returns>
        public static tb_ResultMoMo GetResultMoMo(string orderId)
        {
            return new ResultMoMoDAL().GetResultMoMo(orderId);
        }

        /// <summary>
        /// Insert transaction reference to the database
        /// </summary>
        /// <param name="resultMoMo"></param>
        /// <returns></returns>
        public static int Insert(tb_ResultMoMo resultMoMo)
        {
            return new ResultMoMoDAL().Insert(resultMoMo);
        }
    }
}