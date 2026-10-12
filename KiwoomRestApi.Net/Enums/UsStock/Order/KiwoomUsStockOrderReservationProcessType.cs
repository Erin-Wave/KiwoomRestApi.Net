using System.Runtime.Serialization;

namespace KiwoomRestApi.Net.Enums.UsStock.Order
{
	/// <summary>
	/// 예약처리구분
	/// </summary>
	public enum KiwoomUsStockOrderReservationProcessType
	{
		/// <summary>
		/// 전체
		/// </summary>
		[EnumMember(Value = "%")]
		All,
		/// <summary>
		/// 미처리
		/// </summary>
		[EnumMember(Value = "0")]
		Unprocessed,
		/// <summary>
		/// 처리 및 오류
		/// </summary>
		[EnumMember(Value = "1")]
		ProcessedOrError
	}
}
