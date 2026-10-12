using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.Order
{
	/// <summary>
	/// 예약취소구분
	/// </summary>
	public enum KiwoomUsStockOrderReservationCancelType
	{
		/// <summary>
		/// 전체
		/// </summary>
		[EnumMember(Value = "0")]
		All,
		/// <summary>
		/// 취소
		/// </summary>
		[EnumMember(Value = "Y")]
		Canceled,
		/// <summary>
		/// 미취소
		/// </summary>
		[EnumMember(Value = "N")]
		NotCanceled
	}
}
