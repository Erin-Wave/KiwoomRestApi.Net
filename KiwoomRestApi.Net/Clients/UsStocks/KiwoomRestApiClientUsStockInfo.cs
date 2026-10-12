using KiwoomRestApi.Net.Enums.UsStock.StockInfo;
using KiwoomRestApi.Net.Extensions;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models.UsStock;

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.UsStocks
{
	/// <summary>
	/// 미국주식 종목정보 API 클라이언트
	/// 현재 34개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientUsStockInfo(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.UsStock.StockInfo;

		/// <summary>
		/// 가격/비율 파라미터는 소수점을 포함하므로 공용 포매터의 F0 변환을 피하기 위해
		/// 소수점을 보존한 문자열로 직접 변환합니다. null은 그대로 전달합니다.
		/// </summary>
		private static string? FormatDecimal(decimal? value) => value?.ToString(CultureInfo.InvariantCulture);

		private static List<KiwoomUsStockInfoWatchlistStock> ToWatchlist(IEnumerable<(KiwoomUsStockInfoExchangeType ExchangeType, string StockCode)> watchlist)
		{
			return watchlist.Select(w => new KiwoomUsStockInfoWatchlistStock
			{
				StockExchangeType = w.ExchangeType.ToEnumString(),
				StockCode = w.StockCode
			}).ToList();
		}

		/// <summary>
		/// | usa10098 | 미국주식 거래소구분 조회
		/// </summary>
		/// <param name="stockCode">종목코드</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetExchangeTypes>> GetExchangeTypesAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa10098";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetExchangeTypes>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa10099 | 미국주식 종목리스트
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetStocks>> GetStocksAsync(KiwoomUsStockInfoExchangeType exchangeType, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa10099";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetStocks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa10100 | 미국주식 종목 조회
		/// </summary>
		/// <param name="stockCode">종목코드</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetStock>> GetStockAsync(string stockCode, KiwoomUsStockInfoExchangeType? exchangeType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa10100";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetStock>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa10103 | 미국주식 종목메모 조회
		/// </summary>
		/// <param name="stocks">조회할 종목 (거래소구분, 종목코드) - 최대 100개, 거래소구분은 All(%)을 사용할 수 없음</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetStockMemos>> GetStockMemosAsync(IEnumerable<(KiwoomUsStockInfoExchangeType ExchangeType, string StockCode)> stocks, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa10103";
			var body = new HttpParameterMap()
				.AddRawField("input_list", ToWatchlist(stocks));

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetStockMemos>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa10101 | 미국주식 업종리스트
		/// </summary>
		/// <param name="queryType">구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetIndustries>> GetIndustriesAsync(KiwoomUsStockInfoIndustryQueryType? queryType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa10101";
			var body = new HttpParameterMap()
				.AddField("gubun", queryType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetIndustries>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa10102 | 미국지수 리스트
		/// </summary>
		/// <param name="queryType">업종지수구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetIndices>> GetIndicesAsync(KiwoomUsStockInfoIndexQueryType? queryType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa10102";
			var body = new HttpParameterMap()
				.AddField("index_qry_tp", queryType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetIndices>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa10104 | 미국 ETF,ETN 리스트
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetEtfEtns>> GetEtfEtnsAsync(KiwoomUsStockInfoExchangeType? exchangeType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa10104";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetEtfEtns>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa10105 | 미국 ETF 카테고리 리스트
		/// </summary>
		/// <param name="queryType">구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetEtfCategories>> GetEtfCategoriesAsync(KiwoomUsStockInfoEtfCategoryQueryType? queryType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa10105";
			var body = new HttpParameterMap()
				.AddField("gubun", queryType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetEtfCategories>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20520 | 미국주식 거래량급등락(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="averageComparisonDays">x일평균대비 (5,10,20,30)</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetVolumeSurges>> GetVolumeSurgesAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? industryCode = null, int? averageComparisonDays = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20520";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("tm", averageComparisonDays)
				.AddField("stk_tp", stockType)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetVolumeSurges>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20521 | 미국주식 거래량급등락(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="averageComparisonDays">x일평균대비 (5,10,20,30)</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetVolumeSurges>> GetEtfVolumeSurgesAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, int? averageComparisonDays = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20521";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("tm", averageComparisonDays)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetVolumeSurges>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20570 | 미국주식 가격대별주가(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="priceStart">가격조건1 (시작가)</param>
		/// <param name="priceEnd">가격조건2 (종료가)</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetPriceRanges>> GetPriceRangesAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, string? industryCode = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, decimal? priceStart = null, decimal? priceEnd = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20570";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_tp", stockType)
				.AddField("stk_cnd", stockCondition)
				.AddField("inds_cd", industryCode)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("pric_cnd1", FormatDecimal(priceStart))
				.AddField("pric_cnd2", FormatDecimal(priceEnd))
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetPriceRanges>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20571 | 미국주식 가격대별주가(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="priceStart">가격조건1 (시작가)</param>
		/// <param name="priceEnd">가격조건2 (종료가)</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetPriceRanges>> GetEtfPriceRangesAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, decimal? priceStart = null, decimal? priceEnd = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20571";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cnd", stockCondition)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("pric_cnd1", FormatDecimal(priceStart))
				.AddField("pric_cnd2", FormatDecimal(priceEnd))
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetPriceRanges>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20930 | 미국주식 가격급등락(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="changeType">급등.급락 구분</param>
		/// <param name="timeBasisType">분전, 전일 구분</param>
		/// <param name="timeValue">분,일자 설정</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetPriceVolatilities>> GetPriceVolatilitiesAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, KiwoomUsStockInfoStockType? stockType = null, string? industryCode = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoChangeType? changeType = null, KiwoomUsStockInfoTimeBasisType? timeBasisType = null, int? timeValue = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20930";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_tp", stockType)
				.AddField("inds_cd", industryCode)
				.AddField("stk_cnd", stockCondition)
				.AddField("flu_tp", changeType)
				.AddField("tm_tp", timeBasisType)
				.AddField("tm", timeValue)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetPriceVolatilities>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20931 | 미국주식 가격급등락(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="changeType">급등.급락 구분</param>
		/// <param name="timeBasisType">분전, 전일 구분</param>
		/// <param name="timeValue">분,일자 설정</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetPriceVolatilities>> GetEtfPriceVolatilitiesAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoChangeType? changeType = null, KiwoomUsStockInfoTimeBasisType? timeBasisType = null, int? timeValue = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20931";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("stk_cnd", stockCondition)
				.AddField("flu_tp", changeType)
				.AddField("tm_tp", timeBasisType)
				.AddField("tm", timeValue)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetPriceVolatilities>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20932 | 미국주식 가격급등락(관심종목)
		/// </summary>
		/// <param name="watchlist">관심종목 (거래소구분, 종목코드)</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="changeType">정렬 구분</param>
		/// <param name="timeBasisType">기준 구분</param>
		/// <param name="timeValue">분전 값</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetPriceVolatilities>> GetWatchlistPriceVolatilitiesAsync(IEnumerable<(KiwoomUsStockInfoExchangeType ExchangeType, string StockCode)> watchlist, KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, KiwoomUsStockInfoChangeType? changeType = null, KiwoomUsStockInfoTimeBasisType? timeBasisType = null, int? timeValue = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20932";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddRawField("stk_cd", ToWatchlist(watchlist))
				.AddField("flu_tp", changeType)
				.AddField("tm_tp", timeBasisType)
				.AddField("tm", timeValue)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetPriceVolatilities>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20970 | 미국주식 고가/저가 접근(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="highLowType">고가,저가구분</param>
		/// <param name="approachRate">근접률 (0.5, 1.0, 1.5, 2.0, 2.5, 3.5)</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceStart">가격조건 시작</param>
		/// <param name="priceEnd">가격조건 끝</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetHighLowApproaches>> GetHighLowApproachesAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, string? industryCode = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockInfoHighLowType? highLowType = null, decimal? approachRate = null, KiwoomUsStockInfoStockCondition? stockCondition = null, decimal? priceStart = null, decimal? priceEnd = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20970";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("stk_tp", stockType)
				.AddField("high_low_tp", highLowType)
				.AddField("alacc_rt", FormatDecimal(approachRate))
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd_st", FormatDecimal(priceStart))
				.AddField("pric_cnd_ed", FormatDecimal(priceEnd))
				.AddField("trde_pric_cnd_st", tradeAmountCondition)
				.AddField("trde_qty_cnd_fr", tradeVolumeCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetHighLowApproaches>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20971 | 미국주식 고가/저가 접근(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="highLowType">고가,저가구분</param>
		/// <param name="approachRate">근접률 (0.5, 1.0, 1.5, 2.0, 2.5, 3.5)</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceStart">가격조건 시작</param>
		/// <param name="priceEnd">가격조건 끝</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetHighLowApproaches>> GetEtfHighLowApproachesAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockInfoHighLowType? highLowType = null, decimal? approachRate = null, KiwoomUsStockInfoStockCondition? stockCondition = null, decimal? priceStart = null, decimal? priceEnd = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20971";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("high_low_tp", highLowType)
				.AddField("alacc_rt", FormatDecimal(approachRate))
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd_st", FormatDecimal(priceStart))
				.AddField("pric_cnd_ed", FormatDecimal(priceEnd))
				.AddField("trde_pric_cnd_st", tradeAmountCondition)
				.AddField("trde_qty_cnd_fr", tradeVolumeCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetHighLowApproaches>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa20972 | 미국주식 고가/저가 접근(관심종목)
		/// </summary>
		/// <param name="watchlist">관심종목 (거래소구분, 종목코드)</param>
		/// <param name="exchangeType">거래소 구분</param>
		/// <param name="highLowType">고가,저가구분</param>
		/// <param name="approachRate">근접률 (0.5, 1.0, 1.5, 2.0, 2.5, 3.5)</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceStart">가격조건 시작</param>
		/// <param name="priceEnd">가격조건 끝</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetWatchlistHighLowApproaches>> GetWatchlistHighLowApproachesAsync(IEnumerable<(KiwoomUsStockInfoExchangeType ExchangeType, string StockCode)> watchlist, KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, KiwoomUsStockInfoHighLowType? highLowType = null, decimal? approachRate = null, KiwoomUsStockInfoStockCondition? stockCondition = null, decimal? priceStart = null, decimal? priceEnd = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa20972";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddRawField("stk_cd", ToWatchlist(watchlist))
				.AddField("high_low_tp", highLowType)
				.AddField("alacc_rt", FormatDecimal(approachRate))
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd_st", FormatDecimal(priceStart))
				.AddField("pric_cnd_ed", FormatDecimal(priceEnd))
				.AddField("trde_pric_cnd_st", tradeAmountCondition)
				.AddField("trde_qty_cnd_fr", tradeVolumeCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetWatchlistHighLowApproaches>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa23400 | 미국주식 거래량갱신(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종검색</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="dayCountType">일자구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetVolumeRenewals>> GetVolumeRenewalsAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, string? industryCode = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockInfoDayCountType? dayCountType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa23400";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", industryCode)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("stk_tp", stockType)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("dt_tp", dayCountType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetVolumeRenewals>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa23401 | 미국주식 거래량갱신(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="dayCountType">일자구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetVolumeRenewals>> GetEtfVolumeRenewalsAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockInfoDayCountType? dayCountType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa23401";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("dt_tp", dayCountType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetVolumeRenewals>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa23402 | 미국주식 거래량갱신(관심종목)
		/// </summary>
		/// <param name="watchlist">관심종목 (거래소구분, 종목코드)</param>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="dayCountType">일자구분</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetVolumeRenewals>> GetWatchlistVolumeRenewalsAsync(IEnumerable<(KiwoomUsStockInfoExchangeType ExchangeType, string StockCode)> watchlist, KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockInfoDayCountType? dayCountType = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa23402";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddRawField("stk_cd", ToWatchlist(watchlist))
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("dt_tp", dayCountType);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetVolumeRenewals>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24100 | 미국주식 신고가/신저가(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="newPriceType">신고가신저가구분</param>
		/// <param name="highLowBasisType">고저기준</param>
		/// <param name="periodDays">기간입력 (n일, 최대250)</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetNewPrices>> GetNewPricesAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, KiwoomUsStockInfoStockType? stockType = null, string? industryCode = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoNewPriceType? newPriceType = null, KiwoomUsStockInfoHighLowBasisType? highLowBasisType = null, int? periodDays = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24100";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_tp", stockType)
				.AddField("inds_cd", industryCode)
				.AddField("stk_cnd", stockCondition)
				.AddField("ntl_tp", newPriceType)
				.AddField("high_low_tp", highLowBasisType)
				.AddField("dt", periodDays)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetNewPrices>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24101 | 미국주식 신고가/신저가(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="newPriceType">신고가신저가구분</param>
		/// <param name="highLowBasisType">고저기준</param>
		/// <param name="periodDays">기간입력 (n일, 최대250)</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetNewPrices>> GetEtfNewPricesAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoNewPriceType? newPriceType = null, KiwoomUsStockInfoHighLowBasisType? highLowBasisType = null, int? periodDays = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24101";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("stk_cnd", stockCondition)
				.AddField("ntl_tp", newPriceType)
				.AddField("high_low_tp", highLowBasisType)
				.AddField("dt", periodDays)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetNewPrices>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24140 | 미국주식 갭상승/갭하락(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="sortType">정렬기준</param>
		/// <param name="upDownType">등락구분</param>
		/// <param name="gapRate">비율1(근접율), 갭비율 값(3,5,10,50,100,150,200)</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetGaps>> GetGapsAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? industryCode = null, KiwoomUsStockInfoStockType? stockType = null, KiwoomUsStockInfoSortType? sortType = null, KiwoomUsStockInfoUpDownType? upDownType = null, decimal? gapRate = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24140";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("stk_tp", stockType)
				.AddField("sort_tp", sortType)
				.AddField("updown_tp", upDownType)
				.AddField("alacc_rt", FormatDecimal(gapRate))
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetGaps>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24141 | 미국주식 갭상승/갭하락(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="sortType">정렬기준</param>
		/// <param name="upDownType">등락구분</param>
		/// <param name="gapRate">비율1(근접율), 갭비율 값(3,5,10,50,100,150,200)</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetGaps>> GetEtfGapsAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, KiwoomUsStockInfoSortType? sortType = null, KiwoomUsStockInfoUpDownType? upDownType = null, decimal? gapRate = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24141";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("sort_tp", sortType)
				.AddField("updown_tp", upDownType)
				.AddField("alacc_rt", FormatDecimal(gapRate))
				.AddField("stk_cnd", stockCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetGaps>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24210 | 미국주식 잔량률급증(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소 구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="ratioType">비율 구분</param>
		/// <param name="stockType">종목 구분</param>
		/// <param name="minutesAgo">xxx분전 설정 (0~30분전, 최대 30분)</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetRemainRatioSurges>> GetRemainRatioSurgesAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, string? industryCode = null, KiwoomUsStockInfoRatioType? ratioType = null, KiwoomUsStockInfoStockType? stockType = null, int? minutesAgo = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24210";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("rt_tp", ratioType)
				.AddField("stk_tp", stockType)
				.AddField("tm", minutesAgo)
				.AddField("stk_cnd", stockCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetRemainRatioSurges>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24211 | 미국주식 잔량률급증(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소 구분</param>
		/// <param name="ratioType">비율 구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="minutesAgo">xxx분전 설정 (0~30분전, 최대 30분)</param>
		/// <param name="stockCondition">종목조건</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetRemainRatioSurges>> GetEtfRemainRatioSurgesAsync(KiwoomUsStockInfoRankingExchangeType2? exchangeType = null, KiwoomUsStockInfoRatioType? ratioType = null, string? etfCategory1 = null, string? etfCategory2 = null, int? minutesAgo = null, KiwoomUsStockInfoStockCondition? stockCondition = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24211";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("rt_tp", ratioType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("tm", minutesAgo)
				.AddField("stk_cnd", stockCondition)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetRemainRatioSurges>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24220 | 미국주식 매물대집중(주식/업종)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="industryCode">업종코드</param>
		/// <param name="stockType">종목구분</param>
		/// <param name="periodDays">기간 (n일, 최대 300일)</param>
		/// <param name="concentrationRate">매물대 집중비율 (n%, 최대 100%)</param>
		/// <param name="zoneCondition">조건</param>
		/// <param name="zoneCount">매물대수 (n, 최대 99)</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetVolumeZones>> GetVolumeZonesAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? industryCode = null, KiwoomUsStockInfoStockType? stockType = null, int? periodDays = null, int? concentrationRate = null, KiwoomUsStockInfoZoneCondition? zoneCondition = null, int? zoneCount = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24220";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("inds_cd", industryCode)
				.AddField("stk_tp", stockType)
				.AddField("dt", periodDays)
				.AddField("prps_cnctr_rt", concentrationRate)
				.AddField("cond", zoneCondition)
				.AddField("prpscnt", zoneCount)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetVolumeZones>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa24221 | 미국주식 매물대집중(ETF)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="periodDays">기간 (n일, 최대 300일)</param>
		/// <param name="concentrationRate">매물대 집중비율 (n%, 최대 100%)</param>
		/// <param name="zoneCondition">조건</param>
		/// <param name="zoneCount">매물대수 (n, 최대 99)</param>
		/// <param name="tradeVolumeCondition">거래량조건</param>
		/// <param name="priceCondition">가격조건</param>
		/// <param name="tradeAmountCondition">거래대금조건</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetVolumeZones>> GetEtfVolumeZonesAsync(KiwoomUsStockInfoRankingExchangeType? exchangeType = null, string? etfCategory1 = null, string? etfCategory2 = null, int? periodDays = null, int? concentrationRate = null, KiwoomUsStockInfoZoneCondition? zoneCondition = null, int? zoneCount = null, KiwoomUsStockInfoTradeVolumeCondition? tradeVolumeCondition = null, KiwoomUsStockInfoPriceCondition? priceCondition = null, KiwoomUsStockInfoTradeAmountCondition? tradeAmountCondition = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa24221";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("dt", periodDays)
				.AddField("prps_cnctr_rt", concentrationRate)
				.AddField("cond", zoneCondition)
				.AddField("prpscnt", zoneCount)
				.AddField("trde_qty_tp", tradeVolumeCondition)
				.AddField("pric_cnd", priceCondition)
				.AddField("trde_prica_cnd", tradeAmountCondition);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetVolumeZones>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa26410 | 미국주식 연도별 등락률(종목)
		/// </summary>
		/// <param name="exchangeType">거래소구분</param>
		/// <param name="stockCode">종목코드</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetYearlyChangeRates>> GetYearlyChangeRateAsync(KiwoomUsStockInfoExchangeType exchangeType, string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa26410";
			var body = new HttpParameterMap()
				.AddField("stex_tp", exchangeType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetYearlyChangeRates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa26411 | 미국주식 연도별 업종별 종목등락률
		/// </summary>
		/// <param name="industryCode">업종코드</param>
		/// <param name="year">조회연도</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetStockYearlyChangeRates>> GetIndustryStockYearlyChangeRatesAsync(string? industryCode = null, int? year = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa26411";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("srch_yr", year);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetStockYearlyChangeRates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa26412 | 미국주식 연도별 ETF 카테고리별 종목등락률
		/// </summary>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="year">조회연도</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetStockYearlyChangeRates>> GetEtfCategoryStockYearlyChangeRatesAsync(string? etfCategory1 = null, string? etfCategory2 = null, int? year = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa26412";
			var body = new HttpParameterMap()
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2)
				.AddField("srch_yr", year);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetStockYearlyChangeRates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa26413 | 미국주식 연도별 등락률(업종)
		/// </summary>
		/// <param name="industryCode">업종코드</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetYearlyChangeRates>> GetIndustryYearlyChangeRateAsync(string? industryCode = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa26413";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetYearlyChangeRates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | usa26414 | 미국주식 연도별 등락률(ETF)
		/// </summary>
		/// <param name="etfCategory1">ETF카테고리코드1</param>
		/// <param name="etfCategory2">ETF카테고리코드2</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomUsStockInfoGetYearlyChangeRates>> GetEtfCategoryYearlyChangeRateAsync(string? etfCategory1 = null, string? etfCategory2 = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "usa26414";
			var body = new HttpParameterMap()
				.AddField("etf_cat1", etfCategory1)
				.AddField("etf_cat2", etfCategory2);

			return await _client.PostKiwoomRestApiAsync<KiwoomUsStockInfoGetYearlyChangeRates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
