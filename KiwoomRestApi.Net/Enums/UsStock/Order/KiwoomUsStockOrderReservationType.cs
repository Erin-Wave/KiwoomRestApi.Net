namespace KiwoomRestApi.Net.Enums.UsStock.Order
{
	/// <summary>
	/// 예약주문구분
	/// </summary>
	public enum KiwoomUsStockOrderReservationType
	{
		/// <summary>
		/// 일반예약
		/// </summary>
		Normal = 1,
		/// <summary>
		/// 기간예약(잔량주문)
		/// </summary>
		PeriodRemaining = 2,
		/// <summary>
		/// 기간예약(지정수량주문)
		/// </summary>
		PeriodFixedQuantity = 3
	}

	/// <summary>
	/// 예약주문구분 (조회용)
	/// </summary>
	public enum KiwoomUsStockOrderReservationQueryType
	{
		/// <summary>
		/// 전체
		/// </summary>
		All = 0,
		/// <summary>
		/// 일반예약
		/// </summary>
		Normal = 1,
		/// <summary>
		/// 기간예약(잔량주문)
		/// </summary>
		PeriodRemaining = 2,
		/// <summary>
		/// 기간예약(지정수량주문)
		/// </summary>
		PeriodFixedQuantity = 3,
		/// <summary>
		/// 기간예약(전체) - 예약주문 내역조회(ust21205)에서만 사용
		/// </summary>
		PeriodAll = 4
	}
}
