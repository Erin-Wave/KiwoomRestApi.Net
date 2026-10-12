using KiwoomRestApi.Net.Enums.DomesticStock.RankingInfo;
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
	/// 순위정보 API 클라이언트
	/// 현재 25개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientDomesticStockRankingInfo(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.RankingInfo;

		/// <summary>
		/// | ka00190 | 대량체결상위
		/// </summary>
		/// <param name="marketType">시장구분</param>
		/// <param name="sortType">정렬기준</param>
		/// <param name="minCaseAmount">건별금액 (1천만원, 2천만원, 3천만원, 4천만원, 5천만원, 1억원, 3억원, 5억원 이상 중 선택)</param>
		/// <param name="minTransactionAmount">거래대금 (0:전체, 3천만원, 5천만원, 1억원, 3억원, 5억원, 10억원 이상 중 선택)</param>
		/// <param name="stockCondition">종목구분</param>
		/// <param name="minVolume">거래량 (0:전체, 1만주, 5만주, 10만주, 15만주, 20만주, 30만주, 50만주, 100만주 이상 중 선택)</param>
		/// <param name="creditCondition">신용구분</param>
		/// <param name="priceCondition">가격구분</param>
		/// <param name="marketCapCondition">시가총액구분</param>
		/// <param name="stockExchangeType">거래소구분</param>
		/// <param name="priceRange">가격조건(사용자) - 단위: 원, 지정하면 가격구분 대신 적용</param>
		/// <param name="marketCapRange">시가총액조건(사용자) - 단위: 원, 지정하면 시가총액구분 대신 적용</param>
		/// <param name="transactionAmountRange">거래대금조건(사용자) - 단위: 원, 지정하면 거래대금 대신 적용</param>
		/// <param name="volumeRange">거래량조건(사용자) - 단위: 주, 지정하면 거래량 대신 적용</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetLargeTradeTops>> GetLargeTradeTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoLargeTradeSortType sortType, decimal minCaseAmount, decimal minTransactionAmount, KiwoomRankingInfoStockCondition stockCondition, decimal minVolume, KiwoomRankingInfoCreditCondition2 creditCondition, KiwoomRankingInfoPriceCondition priceCondition, KiwoomRankingInfoMarketCapCondition marketCapCondition, KiwoomRankingInfoStockExchangeType stockExchangeType, KiwoomRankingInfoRangeCondition? priceRange = null, KiwoomRankingInfoRangeCondition? marketCapRange = null, KiwoomRankingInfoRangeCondition? transactionAmountRange = null, KiwoomRankingInfoRangeCondition? volumeRange = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka00190";
			// 사용자 조건(범위)을 지정한 항목은 구분값을 -1(사용자 조건)로 보냅니다.
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_tp", sortType)
				.AddField("case_pric_tp", minCaseAmount / 10_000_000)
				.AddField("trde_prica_tp", transactionAmountRange is null ? minTransactionAmount / 10_000_000 : -1m)
				.AddField("stk_tp", stockCondition)
				.AddField("trde_qty_tp", volumeRange is null ? minVolume / 1000 : -1m)
				.AddField("crd_tp", creditCondition)
				.AddField("pric_tp", priceRange is null ? (int)priceCondition : -1)
				.AddField("mac_tp", marketCapRange is null ? (int)marketCapCondition : -1)
				.AddField("stex_tp", stockExchangeType);

			AddRangeCondition(body, "price_cnd", priceRange, 1);
			AddRangeCondition(body, "mac_cnd", marketCapRange, 100_000_000);
			// 명세의 필드명이 trde_prica_cnd_min_sgin(오타)이므로 그대로 사용합니다.
			AddRangeCondition(body, "trde_prica_cnd", transactionAmountRange, 100_000_000, "trde_prica_cnd_min_sgin");
			AddRangeCondition(body, "trde_qty_cnd", volumeRange, 1000);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetLargeTradeTops>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 사용자 조건(범위) 파라미터({prefix}_tp, _min, _max, _min_sign, _max_sign)를 추가합니다.
		/// </summary>
		/// <param name="body"></param>
		/// <param name="prefix">파라미터 접두어</param>
		/// <param name="range">범위 조건 (null이면 미설정)</param>
		/// <param name="unit">API 단위로 환산하기 위한 나눗수</param>
		/// <param name="minSignKey">최소 부등호 필드명 (기본값: {prefix}_min_sign)</param>
		private static void AddRangeCondition(HttpParameterMap body, string prefix, KiwoomRankingInfoRangeCondition? range, decimal unit, string? minSignKey = null)
		{
			body.AddField($"{prefix}_tp", range is not null)
				.AddField($"{prefix}_min", range?.Min / unit)
				.AddField($"{prefix}_max", range?.Max / unit)
				.AddField(minSignKey ?? $"{prefix}_min_sign", range?.IsMinInclusive)
				.AddField($"{prefix}_max_sign", range?.IsMaxInclusive);
		}

		/// <summary>
		/// | ka00196 | 체결금액대별매매비중
		/// </summary>
		/// <param name="stockCode">종목코드 (KRX:039490, NXT:039490_NX, SOR:039490_AL)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetTradeAmountRangeTransactionRatios>> GetTradeAmountRangeTransactionRatiosAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka00196";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetTradeAmountRangeTransactionRatios>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka04196 | 수익률상위고객매매상세
		/// </summary>
		/// <param name="queryType">조회구분</param>
		/// <param name="stockExchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드 (미입력시 전체)</param>
		/// <param name="startDate">시작일자</param>
		/// <param name="endDate">종료일자</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetTopProfitCustomerTransactionDetails>> GetTopProfitCustomerTransactionDetailsAsync(KiwoomRankingInfoTopProfitCustomerQueryType queryType, KiwoomRankingInfoStockExchangeType stockExchangeType, string stockCode = "", DateTime? startDate = null, DateTime? endDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka04196";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("st_dt", startDate)
				.AddField("ed_dt", endDate)
				.AddField("qry_tp", queryType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetTopProfitCustomerTransactionDetails>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10020 | 호가잔량상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="sortType"></param>
		/// <param name="minVolume"></param>
		/// <param name="stockCondition"></param>
		/// <param name="creditCondition"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetOrderBookTops>> GetOrderBookTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoSortType sortType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition, KiwoomRankingInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10020";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_tp", sortType)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("stk_cnd", stockCondition)
				.AddField("crd_cnd", creditCondition)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetOrderBookTops>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10021 | 호가잔량급증요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="transactionType"></param>
		/// <param name="sortType"></param>
		/// <param name="minVolume"></param>
		/// <param name="stockCondition"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="timeMinute"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetOrderBookSpikes>> GetOrderBookSpikesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoTransactionType transactionType, KiwoomRankingInfoSpikeSortType sortType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoStockExchangeType stockExchangeType, int timeMinute, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10021";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", transactionType)
				.AddField("sort_tp", sortType)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("stk_cnd", stockCondition)
				.AddField("stex_tp", stockExchangeType)
				.AddField("tm_tp", timeMinute);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetOrderBookSpikes>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10022 | 잔량율급증요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="rateType"></param>
		/// <param name="minVolume"></param>
		/// <param name="stockCondition"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="timeMinute"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetRemainQuantityRateSpikes>> GetRemainQuantityRateSpikesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoRateType rateType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoStockExchangeType stockExchangeType, int timeMinute, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10022";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("rt_tp", rateType)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("stk_cnd", stockCondition)
				.AddField("stex_tp", stockExchangeType)
				.AddField("tm_tp", timeMinute);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetRemainQuantityRateSpikes>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10023 | 거래량급증요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="sortType"></param>
		/// <param name="timeType"></param>
		/// <param name="minVolume"></param>
		/// <param name="stockCondition"></param>
		/// <param name="priceType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="timeMinute"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetVolumeSpikes>> GetVolumeSpikesAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoSpikeSortType sortType, KiwoomRankingInfoTimeType timeType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoPriceType priceType, KiwoomRankingInfoStockExchangeType stockExchangeType, int timeMinute, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10023";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_tp", sortType)
				.AddField("tm_tp", timeType)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_tp", priceType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("tm", timeMinute);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetVolumeSpikes>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10027 | 전일대비등락률상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="sortType"></param>
		/// <param name="minVolume"></param>
		/// <param name="stockCondition"></param>
		/// <param name="creditCondition"></param>
		/// <param name="isIncludeUpDown"></param>
		/// <param name="priceCondition"></param>
		/// <param name="minTransactionAmount"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetChangeRateTops>> GetChangeRateTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoChangeSortType sortType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition,
bool isIncludeUpDown, KiwoomRankingInfoPriceCondition priceCondition, decimal minTransactionAmount, KiwoomRankingInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10027";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_tp", sortType)
				.AddField("trde_qty_cnd", minVolume / 1000)
				.AddField("stk_cnd", stockCondition)
				.AddField("crd_cnd", creditCondition)
				.AddField("updown_incls", isIncludeUpDown)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", minTransactionAmount / 10_000_000)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetChangeRateTops>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10029 | 예상체결등락률상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="sortType"></param>
		/// <param name="minVolume"></param>
		/// <param name="stockCondition"></param>
		/// <param name="creditCondition"></param>
		/// <param name="priceCondition"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetExpectedTradeChangeRateTops>> GetExpectedTradeChangeRateTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoTradeChangeSortType sortType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition,
KiwoomRankingInfoPriceCondition priceCondition, KiwoomRankingInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10029";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_tp", sortType)
				.AddField("trde_qty_cnd", minVolume / 1000)
				.AddField("stk_cnd", stockCondition)
				.AddField("crd_cnd", creditCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetExpectedTradeChangeRateTops>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10030 | 당일거래량상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="sortType"></param>
		/// <param name="stockCondition"></param>
		/// <param name="creditCondition"></param>
		/// <param name="minVolume"></param>
		/// <param name="priceCondition"></param>
		/// <param name="minTransactionAmount"></param>
		/// <param name="marketOpenType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetTodayVolumeTops>> GetTodayVolumeTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoVolumeSortType sortType, KiwoomRankingInfoStockCondition stockCondition, KiwoomRankingInfoCreditCondition creditCondition, decimal minVolume,
KiwoomRankingInfoPriceCondition2 priceCondition, decimal minTransactionAmount, KiwoomRankingInfoMarketOpenType marketOpenType, KiwoomRankingInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10030";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_tp", sortType)
				.AddField("mang_stk_incls", stockCondition)
				.AddField("crd_tp", creditCondition)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("pric_tp", priceCondition)
				.AddField("trde_prica_tp", minTransactionAmount / 10_000_000)
				.AddField("mrkt_open_tp", marketOpenType)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetTodayVolumeTops>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10031 | 전일거래량상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="queryType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="startRank"></param>
		/// <param name="endRank"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetPreviousDayVolumeTops>> GetPreviousDayVolumeTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoPreviousDayVolumeQueryType queryType, KiwoomRankingInfoStockExchangeType stockExchangeType, int startRank, int endRank, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10031";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("qry_tp", queryType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("rank_strt", startRank)
				.AddField("rank_end", endRank);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetPreviousDayVolumeTops>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10032 | 거래대금상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="isIncludeManagedStock"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetTransactionAmountTops>> GetTransactionAmountTopsAsync(KiwoomRankingInfoMarketType marketType, bool isIncludeManagedStock, KiwoomRankingInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10032";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("mang_stk_incls", isIncludeManagedStock)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetTransactionAmountTops>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10033 | 신용비율상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="minVolume"></param>
		/// <param name="stockCondition"></param>
		/// <param name="isIncludeUpDown"></param>
		/// <param name="creditCondition"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetCreditRateTops>> GetCreditRateTopsAsync(KiwoomRankingInfoMarketType marketType, decimal minVolume, KiwoomRankingInfoStockCondition stockCondition, bool isIncludeUpDown, KiwoomRankingInfoCreditCondition creditCondition, KiwoomRankingInfoStockExchangeType stockExchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10033";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("stk_cnd", stockCondition)
				.AddField("updown_incls", isIncludeUpDown)
				.AddField("crd_cnd", creditCondition)
				.AddField("stex_tp", stockExchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetCreditRateTops>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10034 | 외인기간별매매상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="transactionType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="period"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetForeignPeriodTransactionTops>> GetForeignPeriodTransactionTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoNetTransactionType transactionType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10034";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", transactionType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("dt", period);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetForeignPeriodTransactionTops>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10035 | 외인연속순매매상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="transactionType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="period"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetForeignContinuousNetTransactionTops>> GetForeignContinuousNetTransactionTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoContinuousNetTransactionType transactionType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10035";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", transactionType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("base_dt_tp", period);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetForeignContinuousNetTransactionTops>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10036 | 외인한도소진율증가상위
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="period"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetForeignLimitUsageRateIncreaseTops>> GetForeignLimitUsageRateIncreaseTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10036";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("dt", period);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetForeignLimitUsageRateIncreaseTops>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10037 | 외국계창구매매상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="transactionType"></param>
		/// <param name="sortType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="period"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetForeignWicketTransactionTops>> GetForeignWicketTransactionTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoForeignWicketTransactionType transactionType, KiwoomRankingInfoAmountQuantityType sortType, KiwoomRankingInfoStockExchangeType stockExchangeType, int period, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10037";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", transactionType)
				.AddField("sort_tp", sortType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("dt", period);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetForeignWicketTransactionTops>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10038 | 종목별증권사순위요청
		/// </summary>
		/// <param name="queryType"></param>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="period"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetStockSecuritiesRanks>> GetStockSecuritiesRanksAsync(KiwoomRankingInfoSecuritiesRankQueryType queryType, string stockCode, DateTime startDate, DateTime endDate, int period, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10038";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType)
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("dt", period - 1);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetStockSecuritiesRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10039 | 증권사별매매상위요청
		/// </summary>
		/// <param name="minVolume"></param>
		/// <param name="transactionType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="memberCompanyCode"></param>
		/// <param name="period"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetSecuritiesTransactionTops>> GetSecuritiesTransactionTopsAsync(decimal minVolume, KiwoomRankingInfoNetTransactionType2 transactionType, KiwoomRankingInfoStockExchangeType stockExchangeType, string memberCompanyCode, int period, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10039";
			var body = new HttpParameterMap()
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("trde_tp", transactionType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("mmcm_cd", memberCompanyCode)
				.AddField("dt", period);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetSecuritiesTransactionTops>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10040 | 당일주요거래원요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetTodayMainBrokers>> GetTodayMainBrokersAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10040";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetTodayMainBrokers>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10042 | 순매수거래원순위요청
		/// </summary>
		/// <param name="queryDateType"></param>
		/// <param name="pointType"></param>
		/// <param name="sortBase"></param>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="period"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetNetBuyBrokerRanks>> GetNetBuyBrokerRanksAsync(KiwoomRankingInfoBrokerRankQueryDateType queryDateType, KiwoomRankingInfoDayType pointType, KiwoomRankingInfoBrokerRankSortType sortBase, string stockCode, DateTime? startDate = null, DateTime? endDate = null, int? period = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10042";
			var body = new HttpParameterMap()
				.AddField("qry_dt_tp", queryDateType)
				.AddField("pot_tp", pointType)
				.AddField("sort_base", sortBase)
				.AddField("stk_cd", stockCode)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate)
				.AddField("dt", period);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetNetBuyBrokerRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10053 | 당일상위이탈원요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetTodayTopExitBrokers>> GetTodayTopExitBrokersAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10053";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetTodayTopExitBrokers>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10062 | 동일순매매순위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="transactionType"></param>
		/// <param name="sortType"></param>
		/// <param name="unitType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetEqualNetTransactionRanks>> GetEqualNetTransactionRanksAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoNetTransactionType2 transactionType, KiwoomRankingInfoEqualNetTransactionRankSortType sortType, KiwoomRankingInfoUnitType unitType, KiwoomRankingInfoStockExchangeType stockExchangeType, DateTime startDate, DateTime? endDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10062";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", transactionType)
				.AddField("sort_cnd", sortType)
				.AddField("unit_tp", unitType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetEqualNetTransactionRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10065 | 장중투자자별매매상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="transactionType"></param>
		/// <param name="institutionType"></param>
		/// <param name="amountQuantityType">금액수량구분 (매도/매수 값의 단위)</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetOpenMarketInvestorTransactionTops>> GetOpenMarketInvestorTransactionTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoNetTransactionType2 transactionType, KiwoomRankingInfoInstitutionType institutionType, KiwoomRankingInfoAmountQuantityType? amountQuantityType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10065";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("trde_tp", transactionType)
				.AddField("orgn_tp", institutionType)
				.AddField("amt_qty_tp", amountQuantityType);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetOpenMarketInvestorTransactionTops>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10098 | 시간외단일가등락율순위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="sortType"></param>
		/// <param name="stockCondition"></param>
		/// <param name="minVolume"></param>
		/// <param name="creditCondition"></param>
		/// <param name="minTransactionAmount"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[Obsolete("KRX 시간외단일가 시장 폐지로 ka10098 TR이 2026-09-12에 삭제되었습니다.")]
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetAfterMarketSinglePriceChangeRateRanks>> GetAfterMarketSinglePriceChangeRateRanksAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoChangeSortType sortType, KiwoomRankingInfoStockCondition stockCondition, decimal minVolume, KiwoomRankingInfoCreditCondition creditCondition, decimal minTransactionAmount, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10098";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("sort_base", sortType)
				.AddField("stk_cnd", stockCondition)
				.AddField("trde_qty_cnd", minVolume / 1000)
				.AddField("crd_cnd", creditCondition)
				.AddField("trde_prica", minTransactionAmount);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetAfterMarketSinglePriceChangeRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka90009 | 외국인기관매매상위요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="isIncludeQueryDate"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomRankingInfoGetForeignInstitutionTransactionTops>> GetForeignInstitutionTransactionTopsAsync(KiwoomRankingInfoMarketType marketType, KiwoomRankingInfoAmountQuantityType amountQuantityType, bool isIncludeQueryDate, KiwoomRankingInfoStockExchangeType stockExchangeType, DateTime? date = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka90009";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("qry_dt_tp", isIncludeQueryDate)
				.AddField("stex_tp", stockExchangeType)
				.AddField("date", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomRankingInfoGetForeignInstitutionTransactionTops>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
