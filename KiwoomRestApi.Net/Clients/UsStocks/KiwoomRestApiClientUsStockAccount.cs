using KiwoomRestApi.Net.Enums.UsStock.Account;
using KiwoomRestApi.Net.Enums.UsStock.StockInfo;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models.UsStock;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.UsStocks
{
	/// <summary>
	/// 미국주식 계좌 API 클라이언트
	/// 현재 28개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientUsStockAccount(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.UsStock.Account;

		/// <summary>
		/// | usa21670 | 미국주식 일별계좌수익률현황
		/// </summary>
		/// <param name="startDate">from 일자</param>
		/// <param name="endDate">to 일자</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetDailyAccountProfitRates>> GetDailyAccountProfitRatesAsync(DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa21670";
			var body = new HttpParameterMap()
				.AddField("from", startDate)
				.AddField("to", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetDailyAccountProfitRates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa21680 | 미국주식 월별계좌수익률현황
		/// </summary>
		/// <param name="startYearMonth">from 년월</param>
		/// <param name="endYearMonth">to 년월</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetMonthlyAccountProfitRates>> GetMonthlyAccountProfitRatesAsync(DateTime startYearMonth, DateTime endYearMonth, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa21680";
			var body = new HttpParameterMap()
				.AddField("from", startYearMonth.ToString("yyyyMM"))
				.AddField("to", endYearMonth.ToString("yyyyMM"));

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetMonthlyAccountProfitRates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa21690 | 미국주식 연도별계좌수익률현황
		/// </summary>
		/// <param name="startYear">from 년도</param>
		/// <param name="endYear">to 년도</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetYearlyAccountProfitRates>> GetYearlyAccountProfitRatesAsync(int startYear, int endYear, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa21690";
			var body = new HttpParameterMap()
				.AddField("from", startYear.ToString())
				.AddField("to", endYear.ToString());

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetYearlyAccountProfitRates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa21730 | 미국주식 일별종목수익률현황
		/// </summary>
		/// <param name="startDate">from 일자</param>
		/// <param name="endDate">to 일자</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetDailyStockProfitRates>> GetDailyStockProfitRatesAsync(DateTime startDate, DateTime endDate, string stockCode, KiwoomUsStockInfoExchangeType? exchangeType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa21730";
			var body = new HttpParameterMap()
				.AddField("from", startDate)
				.AddField("to", endDate)
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetDailyStockProfitRates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa21731 | 미국주식 월별종목수익률현황
		/// </summary>
		/// <param name="startYearMonth">from 년월</param>
		/// <param name="endYearMonth">to 년월</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetDailyStockProfitRates>> GetMonthlyStockProfitRatesAsync(DateTime startYearMonth, DateTime endYearMonth, string stockCode, KiwoomUsStockInfoExchangeType? exchangeType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa21731";
			var body = new HttpParameterMap()
				.AddField("from", startYearMonth.ToString("yyyyMM"))
				.AddField("to", endYearMonth.ToString("yyyyMM"))
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetDailyStockProfitRates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa21732 | 미국주식 연도별종목수익률현황
		/// </summary>
		/// <param name="startYear">from 년도</param>
		/// <param name="endYear">to 년도</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetDailyStockProfitRates>> GetYearlyStockProfitRatesAsync(int startYear, int endYear, string stockCode, KiwoomUsStockInfoExchangeType? exchangeType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa21732";
			var body = new HttpParameterMap()
				.AddField("from", startYear.ToString())
				.AddField("to", endYear.ToString())
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetDailyStockProfitRates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21050 | 미국주식 원장 미체결
		/// </summary>
		/// <param name="orderDate">주문일자 (미입력시 오늘 날짜로 조회)</param>
		/// <param name="sellBuyType">매도매수구분</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetUnfilledOrders>> GetUnfilledOrdersAsync(DateTime? orderDate = null, KiwoomUsStockAccountSellBuyType? sellBuyType = null, KiwoomUsStockInfoExchangeType? exchangeType = null, string? stockCode = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21050";
			var body = new HttpParameterMap()
				.AddField("ord_dt", orderDate)
				.AddField("slby_tp", sellBuyType)
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetUnfilledOrders>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21070 | 미국주식 원장잔고확인
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드 (미입력시 전체)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetBalance>> GetBalanceAsync(KiwoomUsStockInfoExchangeType? exchangeType = null, string? stockCode = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21070";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetBalance>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21100 | 미국주식 거래내역
		/// </summary>
		/// <param name="startDate">시작일자</param>
		/// <param name="endDate">종료일자</param>
		/// <param name="transactionType">구분</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="excludeKrwReplacementDepositWithdrawal">원화대용입출금제외여부 (true:제외, false:비제외)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetTransactionHistory>> GetTransactionHistoryAsync(DateTime startDate, DateTime endDate, KiwoomUsStockAccountTransactionType transactionType = KiwoomUsStockAccountTransactionType.All, KiwoomUsStockInfoExchangeType? exchangeType = null, string? stockCode = null, bool excludeKrwReplacementDepositWithdrawal = false, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21100";
			var body = new HttpParameterMap()
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("tp", transactionType)
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("krw_repl_skip_yn", excludeKrwReplacementDepositWithdrawal ? "Y" : "N");

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetTransactionHistory>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21110 | 해외주식 예수금
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetDeposit>> GetDepositAsync(CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21110";
			var body = new HttpParameterMap();

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetDeposit>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21111 | 원화출금가능 금액 조회(원화대용 포함)
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetKrwWithdrawableAmount>> GetKrwWithdrawableAmountAsync(CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21111";
			var body = new HttpParameterMap();

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetKrwWithdrawableAmount>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21120 | 통화별 예수금 및 증권 평가금현황
		/// </summary>
		/// <param name="commissionInclusionType">수수료포함구분</param>
		/// <param name="exchangeRateType">환율구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetCurrencyDepositEvaluation>> GetCurrencyDepositEvaluationAsync(KiwoomUsStockAccountCommissionInclusionType? commissionInclusionType = null, KiwoomUsStockAccountExchangeRateType? exchangeRateType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21120";
			var body = new HttpParameterMap()
				.AddField("cmsn_incl_tp", commissionInclusionType)
				.AddField("exrt_tp", exchangeRateType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetCurrencyDepositEvaluation>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21121 | 해외증권 원장 평가금액현황
		/// </summary>
		/// <param name="commissionInclusionType">수수료포함구분</param>
		/// <param name="exchangeRateType">환율구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetLedgerEvaluationAmount>> GetLedgerEvaluationAmountAsync(KiwoomUsStockAccountCommissionInclusionType? commissionInclusionType = null, KiwoomUsStockAccountExchangeRateType? exchangeRateType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21121";
			var body = new HttpParameterMap()
				.AddField("cmsn_incl_tp", commissionInclusionType)
				.AddField("exrt_tp", exchangeRateType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetLedgerEvaluationAmount>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21131 | 해외증권 특정일 평가금액
		/// </summary>
		/// <param name="baseDate">기준일자</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetSpecificDateEvaluationAmount>> GetSpecificDateEvaluationAmountAsync(DateTime baseDate, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21131";
			var body = new HttpParameterMap()
				.AddField("base_dt", baseDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetSpecificDateEvaluationAmount>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21132 | 특정일 통화별 예수금 및 증권 평가금
		/// </summary>
		/// <param name="baseDate">기준일자</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetSpecificDateCurrencyDepositEvaluation>> GetSpecificDateCurrencyDepositEvaluationAsync(DateTime baseDate, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21132";
			var body = new HttpParameterMap()
				.AddField("base_dt", baseDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetSpecificDateCurrencyDepositEvaluation>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21150 | 미국주식 일별 주문체결내역
		/// </summary>
		/// <param name="queryType">조회구분</param>
		/// <param name="sellBuyType">매도수구분</param>
		/// <param name="orderDate">주문일자 (미입력시 오늘 날짜로 조회)</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="oppositeTradeType">반대매매구분</param>
		/// <param name="startOrderNumber">시작주문번호</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetDailyOrderExecutions>> GetDailyOrderExecutionsAsync(KiwoomUsStockAccountOrderQueryType queryType, KiwoomUsStockAccountSellBuyType sellBuyType, DateTime? orderDate = null, KiwoomUsStockInfoExchangeType? exchangeType = null, string? stockCode = null, KiwoomUsStockAccountOppositeTradeType? oppositeTradeType = null, string? startOrderNumber = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21150";
			var body = new HttpParameterMap()
				.AddField("ord_dt", orderDate)
				.AddField("query_tp", queryType)
				.AddField("slby_tp", sellBuyType)
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("oppo_trde_tp", oppositeTradeType)
				.AddField("fr_ord_no", startOrderNumber);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetDailyOrderExecutions>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21160 | 미국주식 예수금 상세
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetDepositDetails>> GetDepositDetailsAsync(CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21160";
			var body = new HttpParameterMap();

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetDepositDetails>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21170 | 미국주식 당일 종목별 실현손익
		/// </summary>
		/// <param name="foreignCurrencyKrwType">외화원화구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetTodayStockRealizedProfitLosses>> GetTodayStockRealizedProfitLossesAsync(KiwoomUsStockAccountForeignCurrencyKrwType foreignCurrencyKrwType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21170";
			var body = new HttpParameterMap()
				.AddField("fc_krw_tp", foreignCurrencyKrwType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetTodayStockRealizedProfitLosses>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21180 | 미국주식 기간별 주문내역
		/// </summary>
		/// <param name="startDate">시작주문일자</param>
		/// <param name="endDate">종료주문일자</param>
		/// <param name="sellBuyType">매도수구분</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="oppositeTradeType">반대매매구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetOrderHistory>> GetOrderHistoryAsync(DateTime startDate, DateTime endDate, KiwoomUsStockAccountSellBuyType? sellBuyType = null, KiwoomUsStockInfoExchangeType? exchangeType = null, string? stockCode = null, KiwoomUsStockAccountOppositeTradeType? oppositeTradeType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21180";
			var body = new HttpParameterMap()
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("slby_tp", sellBuyType)
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("oppo_trde_tp", oppositeTradeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetOrderHistory>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21510 | 미국주식 당일 주문체결 확인
		/// </summary>
		/// <param name="sellBuyType">매도매수구분</param>
		/// <param name="exchangeType">거래소구분 (종목코드 입력시)</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetTodayOrderExecutions>> GetTodayOrderExecutionsAsync(KiwoomUsStockAccountSellBuyType? sellBuyType = null, KiwoomUsStockInfoExchangeType? exchangeType = null, string? stockCode = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21510";
			var body = new HttpParameterMap()
				.AddField("slby_tp", sellBuyType)
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetTodayOrderExecutions>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21530 | 미국주식 실현손익
		/// </summary>
		/// <param name="startDate">시작일자</param>
		/// <param name="endDate">종료일자</param>
		/// <param name="foreignCurrencyKrwType">외화원화구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetRealizedProfitLosses>> GetRealizedProfitLossesAsync(DateTime? startDate = null, DateTime? endDate = null, KiwoomUsStockAccountForeignCurrencyKrwType? foreignCurrencyKrwType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21530";
			var body = new HttpParameterMap()
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("fc_krw_tp", foreignCurrencyKrwType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetRealizedProfitLosses>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21610 | 미국주식 당일매매
		/// </summary>
		/// <param name="queryType">조회구분</param>
		/// <param name="foreignCurrencyKrwType">외화원화구분</param>
		/// <param name="baseDate">기준일자</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetTodayTrades>> GetTodayTradesAsync(KiwoomUsStockAccountTodayTradeQueryType queryType, KiwoomUsStockAccountForeignCurrencyKrwType foreignCurrencyKrwType, DateTime? baseDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21610";
			var body = new HttpParameterMap()
				.AddField("base_dt", baseDate)
				.AddField("qry_tp", queryType)
				.AddField("fc_krw_tp", foreignCurrencyKrwType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetTodayTrades>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21620 | 미국주식 당일매매정리
		/// </summary>
		/// <param name="foreignCurrencyKrwType">외화원화구분</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드 (기본값 전체)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetTodayTradeSummary>> GetTodayTradeSummaryAsync(KiwoomUsStockAccountForeignCurrencyKrwType foreignCurrencyKrwType, KiwoomUsStockInfoExchangeType? exchangeType = null, string? stockCode = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21620";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("fc_krw_tp", foreignCurrencyKrwType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetTodayTradeSummary>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21630 | 미국주식 당일 실현손익
		/// </summary>
		/// <param name="foreignCurrencyKrwType">외화원화구분</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetTodayRealizedProfitLosses>> GetTodayRealizedProfitLossesAsync(KiwoomUsStockAccountForeignCurrencyKrwType foreignCurrencyKrwType, KiwoomUsStockInfoExchangeType? exchangeType = null, string? stockCode = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21630";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("fc_krw_tp", foreignCurrencyKrwType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetTodayRealizedProfitLosses>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21640 | 미국주식 일별 종목별 실현손익
		/// </summary>
		/// <param name="tradeDate">체결일자</param>
		/// <param name="foreignCurrencyKrwType">외화원화구분</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetDailyStockRealizedProfitLosses>> GetDailyStockRealizedProfitLossesAsync(DateTime tradeDate, KiwoomUsStockAccountForeignCurrencyKrwType foreignCurrencyKrwType, KiwoomUsStockInfoExchangeType? exchangeType = null, string? stockCode = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21640";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("cntr_dt", tradeDate)
				.AddField("fc_krw_tp", foreignCurrencyKrwType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetDailyStockRealizedProfitLosses>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21650 | 미국주식 기간별 수익률 현황
		/// </summary>
		/// <param name="fromDate">조회시작일자 (조회 기간은 최대 6개월)</param>
		/// <param name="toDate">조회종료일자</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetPeriodProfitRates>> GetPeriodProfitRatesAsync(DateTime fromDate, DateTime toDate, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21650";
			var body = new HttpParameterMap()
				.AddField("fr_dt", fromDate)
				.AddField("to_dt", toDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetPeriodProfitRates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21660 | 미국주식 일별 실현손익
		/// </summary>
		/// <param name="startDate">시작일자</param>
		/// <param name="endDate">종료일자</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetDailyRealizedProfitLosses>> GetDailyRealizedProfitLossesAsync(DateTime? startDate = null, DateTime? endDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21660";
			var body = new HttpParameterMap()
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetDailyRealizedProfitLosses>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ust21661 | 미국주식 월별 실현손익
		/// </summary>
		/// <param name="startYearMonth">시작일자 (YYYYMM)</param>
		/// <param name="endYearMonth">종료일자 (YYYYMM)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockAccountGetMonthlyRealizedProfitLosses>> GetMonthlyRealizedProfitLossesAsync(DateTime? startYearMonth = null, DateTime? endYearMonth = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ust21661";
			var body = new HttpParameterMap()
				.AddField("strt_dt", startYearMonth?.ToString("yyyyMM"))
				.AddField("end_dt", endYearMonth?.ToString("yyyyMM"));

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockAccountGetMonthlyRealizedProfitLosses>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
