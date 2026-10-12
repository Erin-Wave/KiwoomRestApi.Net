namespace KiwoomRestApi.Net.Enums.UsStock.Order
{
	/// <summary>
	/// 기준일구분 (예약주문 내역조회)
	/// </summary>
	public enum KiwoomUsStockOrderReservationDateType
	{
		/// <summary>
		/// 주문전송일
		/// </summary>
		OrderSendDate = 0,
		/// <summary>
		/// 예약등록일
		/// </summary>
		ReservationDate = 1
	}
}
