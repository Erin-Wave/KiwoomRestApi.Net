using KiwoomRestApi.Net.Enums;
using KiwoomRestApi.Net.Enums.DomesticStock.MarketCondition;
using KiwoomRestApi.Net.Extensions;
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
	/// 시세 API 클라이언트
	/// 현재 24개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientDomesticStockMarketCondition(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.MarketCondition;

		/// <summary>
		/// | ka10004 | 주식호가요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetOrderBook>> GetOrderBookAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10004";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetOrderBook>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10004 | 주식호가요청 (Array)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetOrderBookList>> GetOrderBookListAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10004";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			var response = await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetOrderBook>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
			return response.MapResponse(r => new KiwoomMarketConditionGetOrderBookList(r));
		}

		/// <summary>
		/// | ka10005 | 주식일주월시분요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetDailyWeeklyMonthly>> GetDailyWeeklyMonthlyAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10005";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetDailyWeeklyMonthly>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10006 | 주식시분요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetHourMinute>> GetHourMinuteAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10006";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetHourMinute>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10007 | 시세표성정보요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetQuote>> GetQuoteAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10007";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetQuote>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10007 | 시세표성정보요청 (Array)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetQuoteList>> GetQuoteListAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10007";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			var response = await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetQuote>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
			return response.MapResponse(r => new KiwoomMarketConditionGetQuoteList(r));
		}

		/// <summary>
		/// | ka10011 | 신주인수권전체시세요청
		/// </summary>
		/// <param name="rightsType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetAllMarketQuoteForRightsOfferings>> GetAllMarketQuoteForRightsOfferingsAsync(KiwoomMarketConditionRightsType rightsType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10011";
			var body = new HttpParameterMap()
				.AddField("newstk_recvrht_tp", rightsType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetAllMarketQuoteForRightsOfferings>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10044 | 일별기관매매종목요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="tradeType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetDailyInstitutionTradingStocks>> GetDailyInstitutionTradingStocksAsync(KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionNetTransactionType tradeType, KiwoomMarketConditionStockExchangeType stockExchangeType, DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10044";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", tradeType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetDailyInstitutionTradingStocks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10045 | 종목별기관매매추이요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="institutionEstimatedUnitPriceType"></param>
		/// <param name="foreignEstimatedUnitPriceType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetStockInstitutionTransactionTrends>> GetStockInstitutionTransactionTrendsAsync(string stockCode, DateTime startDate, DateTime endDate, KiwoomMarketConditionUnitPriceType institutionEstimatedUnitPriceType, KiwoomMarketConditionUnitPriceType foreignEstimatedUnitPriceType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10045";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("orgn_prsm_unp_tp", institutionEstimatedUnitPriceType)
				.AddField("for_prsm_unp_tp", foreignEstimatedUnitPriceType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetStockInstitutionTransactionTrends>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10046 | 체결강도추이시간별요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetHourlyTradeMomentums>> GetHourlyTradeMomentumsAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10046";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetHourlyTradeMomentums>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10047 | 체결강도추이일별요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetDailyTradeMomentums>> GetDailyTradeMomentumsAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10047";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetDailyTradeMomentums>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10063 | 장중투자자별매매요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="investorType"></param>
		/// <param name="isForeignAll"></param>
		/// <param name="isSimultaneousNetBuyType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetIntradayInvestorTradings>> GetIntradayInvestorTradingsAsync(KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionAmountQuantityType amountQuantityType, KiwoomMarketConditionInvestorType investorType, bool isForeignAll, bool isSimultaneousNetBuyType, KiwoomMarketConditionStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10063";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("invsr", investorType)
				.AddField("frgn_all", isForeignAll)
				.AddField("smtm_netprps_tp", isSimultaneousNetBuyType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetIntradayInvestorTradings>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10066 | 장마감후투자자별매매요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="tradeType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetIntradayInvestorTradeCharts>> GetIntradayInvestorTradeChartsAsync(KiwoomMarketConditionMarketType marketType, KiwoomMarketConditionAmountQuantityType amountQuantityType, KiwoomMarketConditionTransactionType tradeType, KiwoomMarketConditionStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10066";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("trde_tp", tradeType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetIntradayInvestorTradeCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10078 | 증권사별종목매매동향요청
		/// </summary>
		/// <param name="memberCompanyCode"></param>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetSecurityFirmStockTradeTrends>> GetSecurityFirmStockTradeTrendsAsync(string memberCompanyCode, string stockCode, DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10078";
			var body = new HttpParameterMap()
				.AddField("mmcm_cd", memberCompanyCode)
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetSecurityFirmStockTradeTrends>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10086 | 일별주가요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetDailyStockPrices>> GetDailyStockPricesAsync(string stockCode, DateTime date, KiwoomMarketConditionAmountQuantityType2 amountQuantityType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10086";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("qry_dt", date)
				.AddField("indc_tp", amountQuantityType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetDailyStockPrices>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10087 | 시간외단일가요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[Obsolete("KRX 시간외단일가 시장 폐지로 ka10087 TR이 2026-09-12에 삭제되었습니다.")]
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetAfterMarketSinglePriceOrderBook>> GetAfterMarketSinglePriceOrderBookAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10087";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetAfterMarketSinglePriceOrderBook>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10087 | 시간외단일가요청 (Array)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[Obsolete("KRX 시간외단일가 시장 폐지로 ka10087 TR이 2026-09-12에 삭제되었습니다.")]
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetAfterMarketSinglePriceOrderBookList>> GetAfterMarketSinglePriceOrderBookListAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10087";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			var response = await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetAfterMarketSinglePriceOrderBook>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
			return response.MapResponse(r => new KiwoomMarketConditionGetAfterMarketSinglePriceOrderBookList(r));
		}

		/// <summary>
		/// | ka50010 | 금현물체결추이
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetGoldTradeTrends>> GetGoldTradeTrendsAsync(KiwoomGoldSpotStockCode stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka50010";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetGoldTradeTrends>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka50012 | 금현물일별추이
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetGoldDailyTrends>> GetGoldDailyTrendsAsync(KiwoomGoldSpotStockCode stockCode, DateTime date, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka50012";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetGoldDailyTrends>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka50087 | 금현물예상체결
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetGoldExpectedTrades>> GetGoldExpectedTradesAsync(KiwoomGoldSpotStockCode stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka50087";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetGoldExpectedTrades>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka50100 | 금현물시세정보
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetGoldInfo>> GetGoldInfoAsync(KiwoomGoldSpotStockCode stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka50100";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetGoldInfo>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka50101 | 금현물 호가
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetGoldQuotes>> GetGoldQuotesAsync(KiwoomGoldSpotStockCode stockCode, int tickCount, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka50101";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("tic_scope", tickCount);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetGoldQuotes>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka90005 | 프로그램매매추이요청 시간대별
		/// </summary>
		/// <param name="date">※ 키움 API에서 삭제 예정인 파라미터이며, 다른 날짜를 지정해도 당일 데이터만 제공됩니다.</param>
		/// <param name="amountQuantityType"></param>
		/// <param name="marketType"></param>
		/// <param name="tickMinuteType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetHourlyProgramTradeTrends>> GetHourlyProgramTradeTrendsAsync(DateTime date, KiwoomMarketConditionAmountQuantityType3 amountQuantityType, KiwoomMarketConditionMarketType3 marketType, KiwoomMarketConditionTickMinuteType tickMinuteType, KiwoomMarketConditionStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka90005";
			string _marketType = (marketType, stockExchangeType) switch
			{
				(KiwoomMarketConditionMarketType3.Kospi, KiwoomMarketConditionStockExchangeType.Krx) => "P00101",
				(KiwoomMarketConditionMarketType3.Kospi, KiwoomMarketConditionStockExchangeType.Nxt) => "P001_NX01",
				(KiwoomMarketConditionMarketType3.Kospi, _) => "P001_AL01",

				(KiwoomMarketConditionMarketType3.Kosdaq, KiwoomMarketConditionStockExchangeType.Krx) => "P10102",
				(KiwoomMarketConditionMarketType3.Kosdaq, KiwoomMarketConditionStockExchangeType.Nxt) => "P101_NX02",
				(KiwoomMarketConditionMarketType3.Kosdaq, _) => "P101_AL02",

				_ => string.Empty
			};
			var body = new HttpParameterMap()
				.AddField("date", date)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("mrkt_tp", _marketType)
				.AddField("min_tic_tp", tickMinuteType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetHourlyProgramTradeTrends>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka90006 | 프로그램매매차익잔고추이요청
		/// </summary>
		/// <param name="date"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetProgramArbitrageBalanceTrends>> GetProgramArbitrageBalanceTrendsAsync(DateTime date, KiwoomMarketConditionStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka90006";
			var body = new HttpParameterMap()
				.AddField("date", date)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetProgramArbitrageBalanceTrends>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka90007 | 프로그램매매누적추이요청
		/// </summary>
		/// <param name="date"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="marketType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetProgramTradeAccumulatedTrends>> GetProgramTradeAccumulatedTrendsAsync(DateTime date, KiwoomMarketConditionAmountQuantityType amountQuantityType, KiwoomMarketConditionMarketType2 marketType, KiwoomMarketConditionStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka90007";
			var body = new HttpParameterMap()
				.AddField("date", date)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("mrkt_tp", marketType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetProgramTradeAccumulatedTrends>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka90008 | 종목시간별프로그램매매추이요청
		/// </summary>
		/// <param name="date">※ 키움 API에서 삭제 예정인 파라미터이며, 다른 날짜를 지정해도 당일 데이터만 제공됩니다.</param>
		/// <param name="stockCode"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetStockTimeProgramTradeTrends>> GetStockTimeProgramTradeTrendsAsync(DateTime date, string stockCode, KiwoomMarketConditionAmountQuantityType amountQuantityType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka90008";
			var body = new HttpParameterMap()
				.AddField("date", date)
				.AddField("stk_cd", stockCode)
				.AddField("amt_qty_tp", amountQuantityType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetStockTimeProgramTradeTrends>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka90010 | 프로그램매매추이요청 일자별
		/// </summary>
		/// <param name="date"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="marketType"></param>
		/// <param name="tickMinuteType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetDailyProgramTradeTrends>> GetDailyProgramTradeTrendsAsync(DateTime date, KiwoomMarketConditionAmountQuantityType3 amountQuantityType, KiwoomMarketConditionMarketType3 marketType, KiwoomMarketConditionTickMinuteType tickMinuteType, KiwoomMarketConditionStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka90010";
			string _marketType = (marketType, stockExchangeType) switch
			{
				(KiwoomMarketConditionMarketType3.Kospi, KiwoomMarketConditionStockExchangeType.Krx) => "P00101",
				(KiwoomMarketConditionMarketType3.Kospi, KiwoomMarketConditionStockExchangeType.Nxt) => "P001_NX01",
				(KiwoomMarketConditionMarketType3.Kospi, _) => "P001_AL01",

				(KiwoomMarketConditionMarketType3.Kosdaq, KiwoomMarketConditionStockExchangeType.Krx) => "P10102",
				(KiwoomMarketConditionMarketType3.Kosdaq, KiwoomMarketConditionStockExchangeType.Nxt) => "P101_NX02",
				(KiwoomMarketConditionMarketType3.Kosdaq, _) => "P101_AL02",

				_ => string.Empty
			};
			var body = new HttpParameterMap()
				.AddField("date", date)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("mrkt_tp", _marketType)
				.AddField("min_tic_tp", tickMinuteType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetDailyProgramTradeTrends>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka90013 | 종목일별프로그램매매추이요청
		/// </summary>
		/// <param name="date"></param>
		/// <param name="stockCode"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomMarketConditionGetStockDailyProgramTradeTrends>> GetStockDailyProgramTradeTrendsAsync(DateTime date, string stockCode, KiwoomMarketConditionAmountQuantityType amountQuantityType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka90013";
			var body = new HttpParameterMap()
				.AddField("date", date)
				.AddField("stk_cd", stockCode)
				.AddField("amt_qty_tp", amountQuantityType);

			return await _client.PostKiwoomRestApiAsync<KiwoomMarketConditionGetStockDailyProgramTradeTrends>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
