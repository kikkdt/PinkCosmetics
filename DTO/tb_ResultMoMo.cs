namespace DTO
{
    using System.ComponentModel.DataAnnotations;

    public partial class tb_ResultMoMo
    {
        public int ID { get; set; }

        [StringLength(120)]
        public string OrderID { get; set; }

        public int? ResultCode { get; set; }
    }
}