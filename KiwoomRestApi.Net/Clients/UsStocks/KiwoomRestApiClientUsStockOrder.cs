using KiwoomRestApi.Net.Enums.UsStock.Account;
using KiwoomRestApi.Net.Enums.UsStock.Order;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models.UsStock;

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.UsStocks
{
	/// <summary>
	/// 미국주식 주문 API 클라이언트
	/// 현재 10개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientUsStockOrder(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.UsStock.Order;

		/// <summary>
		/// 미국주식 가격 필드는 소수점(센트)을 포함하므로 공용 포매터의 F0 변환을 피하기 위해
		/// 소수점을 보존한 문자열로 직접 변환합니다. null은 그대로 전달합니다.
		/// </summary>
		private static string? FormatPrice(decimal? value) => value?.ToString(CultureInfo.InvariantCulture);

		/// <summary>
		/// | ust20000 | 미국주식 매수주문
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="orderQuantity">주문수량</param>
		/// <param name="transactionType">해외매매구분</param>
		/// <param name="orderPrice">주문단가 (지정가 계열 매매구분 시 필수)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockOrderBuyOrder>> BuyOrderAsync(KiwoomUsStockOrderExchangeType exchangeType, string stockCode, decimal orderQuantity, KiwoomUsStockOrderTransactionType transactionType, decimal? orderPrice = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust20000";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("ord_qty", orderQuantity)
				.AddField("ord_uv", FormatPrice(orderPrice))
				.AddField("trde_tp", transactionType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockOrderBuyOrder>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust20001 | 미국주식 매도주문
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="orderQuantity">주문수량</param>
		/// <param name="transactionType">매매구분</param>
		/// <param name="orderPrice">주문단가 (지정가 계열 매매구분 시 필수)</param>
		/// <param name="stopPrice">STOP가격 (STOP, STOP LIMIT 매매구분 시 필수)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockOrderSellOrder>> SellOrderAsync(KiwoomUsStockOrderExchangeType exchangeType, string stockCode, decimal orderQuantity, KiwoomUsStockOrderTransactionType transactionType, decimal? orderPrice = null, decimal? stopPrice = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust20001";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("stex_tp", exchangeType)
				.AddField("ord_qty", orderQuantity)
				.AddField("ord_uv", FormatPrice(orderPrice))
				.AddField("stop_pric", FormatPrice(stopPrice))
				.AddField("trde_tp", transactionType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockOrderSellOrder>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust20002 | 미국주식 정정주문
		/// </summary>
		/// <param name="originalOrderId">원주문번호</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="modifyPrice">정정단가</param>
		/// <param name="stopPrice">STOP가격</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockOrderModifyOrder>> ModifyOrderAsync(string originalOrderId, KiwoomUsStockOrderExchangeType exchangeType, string stockCode, decimal? modifyPrice = null, decimal? stopPrice = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust20002";
			var body = new HttpParameterMap()
				.AddField("orig_ord_no", originalOrderId)
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("mdfy_uv", FormatPrice(modifyPrice))
				.AddField("stop_pric", FormatPrice(stopPrice));

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockOrderModifyOrder>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust20003 | 미국주식 취소주문
		/// </summary>
		/// <param name="originalOrderId">원주문번호</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockOrderCancelOrder>> CancelOrderAsync(string originalOrderId, KiwoomUsStockOrderExchangeType exchangeType, string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust20003";
			var body = new HttpParameterMap()
				.AddField("orig_ord_no", originalOrderId)
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockOrderCancelOrder>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21200 | 미국주식 예약 매수주문
		/// </summary>
		/// <remarks>
		/// 예약주문 입력 시에는 매수증거금, 잔고, 주문가격 제한폭 등을 체크하지 않으므로 실제 주문 처리 시 거부될 수 있습니다.
		/// 정규장 개시 후 접수한 예약주문은 익일 정규장에 접수됩니다.
		/// </remarks>
		/// <param name="reservationType">예약주문구분</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="orderQuantity">주문수량</param>
		/// <param name="transactionType">매매구분 (지정가, 시장가, LOC, VWAP 시장가, TWAP 시장가, VWAP 지정가, TWAP 지정가)</param>
		/// <param name="orderPrice">주문단가 (지정가 계열 매매구분 시 필수)</param>
		/// <param name="startDate">기간예약시작일자 (기간예약 시)</param>
		/// <param name="endDate">기간예약종료일자 (기간예약 시)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockOrderReserveOrder>> ReserveBuyOrderAsync(KiwoomUsStockOrderReservationType reservationType, KiwoomUsStockOrderExchangeType exchangeType, string stockCode, decimal orderQuantity, KiwoomUsStockOrderTransactionType transactionType, decimal? orderPrice = null, DateTime? startDate = null, DateTime? endDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21200";
			var body = new HttpParameterMap()
				.AddField("rsrv_ord_tp", reservationType)
				.AddField("rsrv_strt_dt", startDate)
				.AddField("rsrv_end_dt", endDate)
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("ord_qty", orderQuantity)
				.AddField("ord_uv", FormatPrice(orderPrice))
				.AddField("trde_tp", transactionType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockOrderReserveOrder>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21201 | 미국주식 예약 매도주문
		/// </summary>
		/// <remarks>
		/// 예약주문 입력 시에는 매수증거금, 잔고, 주문가격 제한폭 등을 체크하지 않으므로 실제 주문 처리 시 거부될 수 있습니다.
		/// 정규장 개시 후 접수한 예약주문은 익일 정규장에 접수됩니다.
		/// </remarks>
		/// <param name="reservationType">예약주문구분</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="orderQuantity">주문수량</param>
		/// <param name="transactionType">매매구분</param>
		/// <param name="orderPrice">주문단가 (지정가 계열 매매구분 시 필수)</param>
		/// <param name="stopPrice">STOP가격 (STOP, STOP LIMIT 매매구분 시 필수)</param>
		/// <param name="startDate">기간예약시작일자 (기간예약 시)</param>
		/// <param name="endDate">기간예약종료일자 (기간예약 시)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockOrderReserveOrder>> ReserveSellOrderAsync(KiwoomUsStockOrderReservationType reservationType, KiwoomUsStockOrderExchangeType exchangeType, string stockCode, decimal orderQuantity, KiwoomUsStockOrderTransactionType transactionType, decimal? orderPrice = null, decimal? stopPrice = null, DateTime? startDate = null, DateTime? endDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21201";
			var body = new HttpParameterMap()
				.AddField("rsrv_ord_tp", reservationType)
				.AddField("rsrv_strt_dt", startDate)
				.AddField("rsrv_end_dt", endDate)
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("ord_qty", orderQuantity)
				.AddField("ord_uv", FormatPrice(orderPrice))
				.AddField("stop_pric", FormatPrice(stopPrice))
				.AddField("trde_tp", transactionType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockOrderReserveOrder>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21203 | 미국주식 예약주문 취소
		/// </summary>
		/// <param name="reservationDate">예약일</param>
		/// <param name="reservationOrderId">예약주문번호</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockOrderCancelReservedOrder>> CancelReservedOrderAsync(DateTime reservationDate, string reservationOrderId, KiwoomUsStockOrderExchangeType exchangeType, string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21203";
			var body = new HttpParameterMap()
				.AddField("rsrv_dt", reservationDate)
				.AddField("rsrv_ord_no", reservationOrderId)
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockOrderCancelReservedOrder>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21204 | 미국주식 일자별 예약내역 조회
		/// </summary>
		/// <param name="reservationType">예약주문구분 (PeriodAll은 사용할 수 없음)</param>
		/// <param name="orderSendDate">주문전송일 (미입력시 당일)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockOrderGetDailyReservedOrders>> GetDailyReservedOrdersAsync(KiwoomUsStockOrderReservationQueryType reservationType, DateTime? orderSendDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21204";
			var body = new HttpParameterMap()
				.AddField("rsrv_ord_tp", reservationType)
				.AddField("ord_send_dt", orderSendDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockOrderGetDailyReservedOrders>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21205 | 미국주식 예약주문 내역조회
		/// </summary>
		/// <param name="fromDate">시작예약일자 (미입력시 당일)</param>
		/// <param name="toDate">종료예약일자 (미입력시 당일)</param>
		/// <param name="fromReservationOrderId">시작예약번호</param>
		/// <param name="reservationType">예약주문구분</param>
		/// <param name="cancelType">예약취소구분</param>
		/// <param name="processType">예약처리구분</param>
		/// <param name="sellBuyType">매도수구분</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드 (미입력시 전체)</param>
		/// <param name="dateType">기준일구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockOrderGetReservedOrders>> GetReservedOrdersAsync(DateTime? fromDate = null, DateTime? toDate = null, string? fromReservationOrderId = null, KiwoomUsStockOrderReservationQueryType? reservationType = null, KiwoomUsStockOrderReservationCancelType? cancelType = null, KiwoomUsStockOrderReservationProcessType? processType = null, KiwoomUsStockAccountSellBuyType? sellBuyType = null, KiwoomUsStockOrderExchangeType? exchangeType = null, string? stockCode = null, KiwoomUsStockOrderReservationDateType? dateType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21205";
			var body = new HttpParameterMap()
				.AddField("fr_rsrv_dt", fromDate)
				.AddField("to_rsrv_dt", toDate)
				.AddField("fr_rsrv_ord_no", fromReservationOrderId)
				.AddField("rsrv_ord_tp", reservationType)
				.AddField("rsrv_cncl_yn", cancelType)
				.AddField("rsrv_proc_tp", processType)
				.AddField("slby_tp", sellBuyType)
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("base_dt_tp", dateType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockOrderGetReservedOrders>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust31490 | 미국주식 증거금율별 주문가능수량 조회
		/// </summary>
		/// <param name="stockCode">종목코드</param>
		/// <param name="buyPrice">매수가격</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockOrderAvailableQuantity>> GetAvailableOrderQuantityAsync(string stockCode, decimal buyPrice, KiwoomUsStockOrderExchangeType? exchangeType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust31490";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("uv", FormatPrice(buyPrice));

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockOrderAvailableQuantity>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
