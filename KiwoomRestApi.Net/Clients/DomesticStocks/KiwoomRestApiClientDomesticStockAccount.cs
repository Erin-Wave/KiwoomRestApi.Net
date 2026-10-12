using KiwoomRestApi.Net.Enums.DomesticStock.Account;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;
using KiwoomRestApi.Net.Objects.Models.DomesticStock;

using System;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	/// <summary>
	/// 계좌 API 클라이언트
	/// 현재 33개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientDomesticStockAccount(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.Account;

		/// <summary>
		/// | ka01690 | 일별잔고수익률
		/// </summary>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetDailyBalanceProfitRates>> GetDailyBalanceProfitRatesAsync(DateTime date, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka01690";
			var body = new HttpParameterMap()
				.AddField("qry_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetDailyBalanceProfitRates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10072 | 일자별종목별실현손익요청_일자
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetDailyStockRealizedProfitLosses>> GetDailyStockRealizedProfitLossesAsync(string stockCode, DateTime date, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10072";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetDailyStockRealizedProfitLosses>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10073 | 일자별종목별실현손익요청_기간
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetDailyStockRealizedProfitLossPeriods>> GetDailyStockRealizedProfitLossPeriodsAsync(string stockCode, DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10073";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetDailyStockRealizedProfitLossPeriods>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10074 | 일자별실현손익요청
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetDailyRealizedProfitLosses>> GetDailyRealizedProfitLossesAsync(DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10074";
			var body = new HttpParameterMap()
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetDailyRealizedProfitLosses>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10075 | 미체결요청
		/// </summary>
		/// <param name="queryType"></param>
		/// <param name="transactionType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetUnfilledOrders>> GetUnfilledOrdersAsync(KiwoomAccountQueryType queryType, KiwoomAccountTransactionType transactionType, KiwoomAccountStockExchangeType stockExchangeType, string stockCode = "", CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10075";
			var body = new HttpParameterMap()
				.AddField("all_stk_tp", queryType)
				.AddField("trde_tp", transactionType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetUnfilledOrders>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10076 | 체결요청
		/// </summary>
		/// <param name="queryType"></param>
		/// <param name="transactionType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="stockCode"></param>
		/// <param name="orderId"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetFilledOrders>> GetFilledOrdersAsync(KiwoomAccountQueryType queryType, KiwoomAccountTransactionType transactionType, KiwoomAccountStockExchangeType stockExchangeType, string stockCode = "", string orderId = "", CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10076";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType)
				.AddField("sell_tp", transactionType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("ord_no", orderId);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetFilledOrders>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10077 | 당일실현손익상세요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetTodayRealizedProfitLoss>> GetTodayRealizedProfitLossAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10077";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetTodayRealizedProfitLoss>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10085 | 계좌수익률요청
		/// </summary>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetProfitRates>> GetProfitRatesAsync(KiwoomAccountStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10085";
			var body = new HttpParameterMap()
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetProfitRates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10088 | 미체결 분할주문 상세
		/// </summary>
		/// <param name="orderId"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetUnfilledSplitOrders>> GetUnfilledSplitOrdersAsync(string orderId, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10088";
			var body = new HttpParameterMap()
				.AddField("ord_no", orderId);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetUnfilledSplitOrders>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10170 | 당일매매일지요청
		/// </summary>
		/// <param name="oddLotType"></param>
		/// <param name="cashCreditType"></param>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetTodayTransactionJournals>> GetTodayTransactionJournalsAsync(KiwoomAccountOddLotType oddLotType, KiwoomAccountCashCreditType cashCreditType, DateTime? date = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10170";
			var body = new HttpParameterMap()
				.AddField("ottks_tp", oddLotType)
				.AddField("ch_crd_tp", cashCreditType)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetTodayTransactionJournals>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt00001 | 예수금상세현황요청
		/// </summary>
		/// <param name="queryType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetDeposits>> GetDepositsAsync(KiwoomAccountDepositQueryType queryType, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt00001";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetDeposits>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt00002 | 일별추정예탁자산현황요청
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetDailyEstimatedDepositAssets>> GetDailyEstimatedDepositAssetsAsync(DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt00002";
			var body = new HttpParameterMap()
				.AddField("start_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetDailyEstimatedDepositAssets>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt00003 | 추정자산조회요청
		/// </summary>
		/// <param name="isExcludeDelisted"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetEstimatedDepositAsset>> GetEstimatedDepositAssetAsync(bool isExcludeDelisted, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt00003";
			var body = new HttpParameterMap()
				.AddField("qry_tp", isExcludeDelisted);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetEstimatedDepositAsset>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt00004 | 계좌평가현황요청
		/// </summary>
		/// <param name="isExcludeDelisted"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetEvaluations>> GetEvaluationsAsync(bool isExcludeDelisted, KiwoomAccountStockExchangeType2 stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt00004";
			var body = new HttpParameterMap()
				.AddField("qry_tp", isExcludeDelisted)
				.AddField("dmst_stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetEvaluations>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt00005 | 체결잔고요청
		/// </summary>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetTradeBalances>> GetTradeBalancesAsync(KiwoomAccountStockExchangeType2 stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt00005";
			var body = new HttpParameterMap()
				.AddField("dmst_stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetTradeBalances>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt00007 | 계좌별주문체결내역상세요청
		/// </summary>
		/// <param name="queryType"></param>
		/// <param name="stockBondType"></param>
		/// <param name="transactionType"></param>
		/// <param name="domesticStockExchangeType"></param>
		/// <param name="date"></param>
		/// <param name="stockCode"></param>
		/// <param name="fromOrderId"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetOrderTradeDetails>> GetOrderTradeDetailsAsync(KiwoomAccountOrderQueryType queryType, KiwoomAccountStockBondType stockBondType, KiwoomAccountTransactionType transactionType, KiwoomAccountDomesticStockExchangeType domesticStockExchangeType, DateTime? date = null, string stockCode = "", string fromOrderId = "", CancellationToken cancellationToken = default)
		{
			const string apiId = "kt00007";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType)
				.AddField("stk_bond_tp", stockBondType)
				.AddField("sell_tp", transactionType)
				.AddField("dmst_stex_tp", domesticStockExchangeType)
				.AddField("ord_dt", date)
				.AddField("stk_cd", stockCode)
				.AddField("fr_ord_no", fromOrderId);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetOrderTradeDetails>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt00008 | 계좌별익일결제예정내역요청
		/// </summary>
		/// <param name="startDealCodeId"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetNextDaySettlements>> GetNextDaySettlementsAsync(string startDealCodeId = "", CancellationToken cancellationToken = default)
		{
			const string apiId = "kt00008";
			var body = new HttpParameterMap()
				.AddField("strt_dcd_seq", startDealCodeId);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetNextDaySettlements>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt00009 | 계좌별주문체결현황요청
		/// </summary>
		/// <param name="queryType"></param>
		/// <param name="stockBondType"></param>
		/// <param name="transactionType"></param>
		/// <param name="domesticStockExchangeType"></param>
		/// <param name="marketType"></param>
		/// <param name="date"></param>
		/// <param name="stockCode"></param>
		/// <param name="fromOrderId"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetOrderTrades>> GetOrderTradesAsync(KiwoomAccountOrderTradeQueryType queryType, KiwoomAccountStockBondType stockBondType, KiwoomAccountTransactionType transactionType, KiwoomAccountDomesticStockExchangeType domesticStockExchangeType, KiwoomAccountMarketType marketType, DateTime? date = null, string stockCode = "", string fromOrderId = "", CancellationToken cancellationToken = default)
		{
			const string apiId = "kt00009";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType)
				.AddField("stk_bond_tp", stockBondType)
				.AddField("sell_tp", transactionType)
				.AddField("dmst_stex_tp", domesticStockExchangeType)
				.AddField("mrkt_tp", marketType)
				.AddField("ord_dt", date)
				.AddField("stk_cd", stockCode)
				.AddField("fr_ord_no", fromOrderId);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetOrderTrades>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt00010 | 주문인출가능금액요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="transactionType"></param>
		/// <param name="buyPrice"></param>
		/// <param name="buyQuantity"></param>
		/// <param name="depositWithdrawalAmount"></param>
		/// <param name="expectedBuyPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetAvailableWithdrawalAmounts>> GetAvailableWithdrawalAmountsAsync(string stockCode, KiwoomAccountTransactionType transactionType, decimal buyPrice, decimal? buyQuantity = null, decimal? depositWithdrawalAmount = null, decimal? expectedBuyPrice = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt00010";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("trde_tp", transactionType)
				.AddField("uv", buyPrice)
				.AddField("trde_qty", buyQuantity)
				.AddField("io_amt", depositWithdrawalAmount)
				.AddField("exp_buy_unp", expectedBuyPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetAvailableWithdrawalAmounts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt00011 | 증거금율별주문가능수량조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="buyPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetMarginOrders>> GetMarginOrdersAsync(string stockCode, decimal? buyPrice = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt00011";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("uv", buyPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetMarginOrders>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt00012 | 신용보증금율별주문가능수량조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="buyPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetCreditDepositOrders>> GetCreditDepositOrdersAsync(string stockCode, decimal? buyPrice = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt00012";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("uv", buyPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetCreditDepositOrders>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt00013 | 증거금세부내역조회요청
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetMarginDetails>> GetMarginDetailsAsync(CancellationToken cancellationToken = default)
		{
			const string apiId = "kt00013";
			var body = new HttpParameterMap();

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetMarginDetails>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt00015 | 위탁종합거래내역요청
		/// </summary>
		/// <param name="transactionType"></param>
		/// <param name="goodsType"></param>
		/// <param name="domesticStockExchangeType"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="stockCode"></param>
		/// <param name="currencyCode"></param>
		/// <param name="foreignStockExchangeCode"></param>
		/// <param name="sortType">조회정렬구분 (미입력시 과거거래순)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetConsignedTransactions>> GetConsignedTransactionsAsync(KiwoomAccountTransactionType2 transactionType, KiwoomAccountGoodsType goodsType, KiwoomAccountDomesticStockExchangeType domesticStockExchangeType, DateTime startDate, DateTime endDate, string stockCode = "", string currencyCode = "", string foreignStockExchangeCode = "", KiwoomAccountQuerySortType? sortType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt00015";
			var body = new HttpParameterMap()
				.AddField("tp", transactionType)
				.AddField("gds_tp", goodsType)
				.AddField("dmst_stex_tp", domesticStockExchangeType)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("stk_cd", stockCode)
				.AddField("crnc_cd", currencyCode)
				.AddField("frgn_stex_code", foreignStockExchangeCode)
				.AddField("qry_sort_tp", sortType);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetConsignedTransactions>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt00016 | 일별계좌수익률상세현황요청
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetDailyProfitRateDetails>> GetDailyProfitRateDetailsAsync(DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt00016";
			var body = new HttpParameterMap()
				.AddField("fr_dt", startDate)
				.AddField("to_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetDailyProfitRateDetails>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt00017 | 계좌별당일현황요청
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetDailyStatus>> GetDailyStatusAsync(CancellationToken cancellationToken = default)
		{
			const string apiId = "kt00017";
			var body = new HttpParameterMap();

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetDailyStatus>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt00018 | 계좌평가잔고내역요청
		/// </summary>
		/// <param name="queryType"></param>
		/// <param name="domesticStockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetEvaluationBalances>> GetEvaluationBalancesAsync(KiwoomAccountEvaluationBalanceQueryType queryType, KiwoomAccountDomesticStockExchangeType2 domesticStockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt00018";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType)
				.AddField("dmst_stex_tp", domesticStockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetEvaluationBalances>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka00001 | 계좌번호조회
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetAccountId>> GetAccountIdAsync(CancellationToken cancellationToken = default)
		{
			const string apiId = "ka00001";
			var body = new HttpParameterMap();

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetAccountId>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt50020 | 금현물 잔고확인
		/// </summary>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetGoldEvaluationBalances>> GetGoldEvaluationBalancesAsync(CancellationToken cancellationToken = default)
		{
			const string apiId = "kt50020";
			var body = new HttpParameterMap();

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetGoldEvaluationBalances>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt50021 | 금현물 예수금
		/// </summary>
		/// <param name="queryType"></param>
		/// <param name="domesticStockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetGoldDeposit>> GetGoldDepositAsync(KiwoomAccountEvaluationBalanceQueryType queryType, KiwoomAccountDomesticStockExchangeType domesticStockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt50021";
			var body = new HttpParameterMap();

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetGoldDeposit>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt50030 | 금현물 주문체결전체조회
		/// </summary>
		/// <param name="date"></param>
		/// <param name="marketDealType">시장구분 (명세상 GoldSpot(5:KRX금현물) 고정)</param>
		/// <param name="stockBondType"></param>
		/// <param name="transactionType"></param>
		/// <param name="queryType"></param>
		/// <param name="stockCode"></param>
		/// <param name="fromOrderId"></param>
		/// <param name="domesticStockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetGoldAllTrades>> GetGoldAllTradesAsync(DateTime date, KiwoomAccountMarketDealType marketDealType, KiwoomAccountStockBondType stockBondType, KiwoomAccountTransactionType transactionType, KiwoomAccountOrderQueryType2 queryType = KiwoomAccountOrderQueryType2.OrderSequence, string? stockCode = null, string? fromOrderId = null, KiwoomAccountDomesticStockExchangeType? domesticStockExchangeType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt50030";
			var body = new HttpParameterMap()
				.AddField("ord_dt", date)
				.AddField("mrkt_deal_tp", marketDealType)
				.AddField("stk_bond_tp", stockBondType)
				.AddField("slby_tp", transactionType)
				.AddField("qry_tp", queryType)
				.AddField("stk_cd", stockCode)
				.AddField("fr_ord_no", fromOrderId)
				.AddField("dmst_stex_tp", domesticStockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetGoldAllTrades>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt50031 | 금현물 주문체결조회
		/// </summary>
		/// <param name="queryType"></param>
		/// <param name="stockBondType"></param>
		/// <param name="transactionType"></param>
		/// <param name="domesticStockExchangeType"></param>
		/// <param name="date"></param>
		/// <param name="stockCode"></param>
		/// <param name="fromOrderId"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetGoldTrades>> GetGoldTradesAsync(KiwoomAccountOrderQueryType queryType, KiwoomAccountStockBondType stockBondType, KiwoomAccountTransactionType transactionType, KiwoomAccountDomesticStockExchangeType domesticStockExchangeType, DateTime? date = null, string? stockCode = null, string? fromOrderId = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt50031";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType)
				.AddField("stk_bond_tp", stockBondType)
				.AddField("sell_tp", transactionType)
				.AddField("dmst_stex_tp", domesticStockExchangeType)
				.AddField("ord_dt", date)
				.AddField("stk_cd", stockCode)
				.AddField("fr_ord_no", fromOrderId);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetGoldTrades>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt50032 | 금현물 거래내역조회
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="transactionType"></param>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetGoldTradeHistories>> GetGoldTradeHistoriesAsync(KiwoomAccountTransactionType3 transactionType, DateTime? startDate = null, DateTime? endDate = null, string? stockCode = null, CancellationToken cancellationToken = default)
		{
			startDate ??= DateTime.MinValue;
			endDate ??= DateTime.MaxValue;

			const string apiId = "kt50032";
			var body = new HttpParameterMap()
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("tp", transactionType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetGoldTradeHistories>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | kt50075 | 금현물 미체결조회
		/// </summary>
		/// <param name="date"></param>
		/// <param name="marketDealType">시장구분 (명세상 GoldSpot(5:KRX금현물) 고정)</param>
		/// <param name="stockBondType"></param>
		/// <param name="transactionType"></param>
		/// <param name="queryType"></param>
		/// <param name="stockCode"></param>
		/// <param name="fromOrderId"></param>
		/// <param name="domesticStockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomAccountGetGoldUnfilledOrders>> GetGoldUnfilledOrdersAsync(DateTime date, KiwoomAccountMarketDealType marketDealType, KiwoomAccountStockBondType stockBondType, KiwoomAccountTransactionType transactionType, KiwoomAccountOrderQueryType2? queryType = null, string? stockCode = null, string? fromOrderId = null, KiwoomAccountDomesticStockExchangeType? domesticStockExchangeType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "kt50075";
			var body = new HttpParameterMap()
				.AddField("ord_dt", date)
				.AddField("mrkt_deal_tp", marketDealType)
				.AddField("stk_bond_tp", stockBondType)
				.AddField("sell_tp", transactionType)
				.AddField("qry_tp", queryType)
				.AddField("stk_cd", stockCode)
				.AddField("fr_ord_no", fromOrderId)
				.AddField("dmst_stex_tp", domesticStockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomAccountGetGoldUnfilledOrders>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
