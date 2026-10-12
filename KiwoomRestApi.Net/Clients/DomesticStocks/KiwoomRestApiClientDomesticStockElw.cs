using KiwoomRestApi.Net.Enums.DomesticStock.Elw;
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
	/// ELW API 클라이언트
	/// 현재 11개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientDomesticStockElw(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.Elw;

		/// <summary>
		/// | ka10048 | ELW일별민감도지표요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomElwGetDailySensitivityIndices>> GetDailySensitivityIndicesAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10048";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomElwGetDailySensitivityIndices>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10050 | ELW민감도지표요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomElwGetSensitivityIndeices>> GetSensitivityIndeicesAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10050";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomElwGetSensitivityIndeices>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka30001 | ELW가격급등락요청
		/// </summary>
		/// <param name="ChangeType"></param>
		/// <param name="timeType"></param>
		/// <param name="timeValue"></param>
		/// <param name="minVolume"></param>
		/// <param name="issuerCompanyCode"></param>
		/// <param name="baseAssetCode"></param>
		/// <param name="rightsType"></param>
		/// <param name="lpCode"></param>
		/// <param name="isExcludeEndedElw"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomElwGetPriceVolatilities>> GetPriceVolatilitiesAsync(KiwoomElwChangeType ChangeType, KiwoomElwTimeType timeType, int timeValue, decimal minVolume, KiwoomElwCompanyCode issuerCompanyCode, string baseAssetCode, KiwoomElwRightsType rightsType, KiwoomElwCompanyCode lpCode, bool isExcludeEndedElw, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka30001";
			var body = new HttpParameterMap()
				.AddField("flu_tp", ChangeType)
				.AddField("tm_tp", timeType)
				.AddField("tm", timeValue)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("isscomp_cd", issuerCompanyCode)
				.AddField("bsis_aset_cd", baseAssetCode)
				.AddField("rght_tp", rightsType)
				.AddField("lpcd", lpCode)
				.AddField("trde_end_elwskip", isExcludeEndedElw);

			return await _client.PostKiwoomRestApiAsync<KiwoomElwGetPriceVolatilities>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka30002 | 거래원별ELW순매매상위요청
		/// </summary>
		/// <param name="issuerCompanyCode"></param>
		/// <param name="minVolume"></param>
		/// <param name="transactionType"></param>
		/// <param name="period"></param>
		/// <param name="isExcludeEndedElw"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomElwGetBrokerNetTransactionTops>> GetBrokerNetTransactionTopsAsync(string issuerCompanyCode, decimal minVolume, KiwoomElwNetTransactionType transactionType, int period, bool isExcludeEndedElw, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka30002";
			var body = new HttpParameterMap()
				.AddField("isscomp_cd", issuerCompanyCode)
				.AddField("trde_qty_tp", minVolume / 1000)
				.AddField("trde_tp", transactionType)
				.AddField("dt", period)
				.AddField("trde_end_elwskip", isExcludeEndedElw);

			return await _client.PostKiwoomRestApiAsync<KiwoomElwGetBrokerNetTransactionTops>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka30003 | ELWLP보유일별추이요청
		/// </summary>
		/// <param name="baseAssetCode"></param>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomElwGetLpHoldingDailyTrends>> GetLpHoldingDailyTrendsAsync(string baseAssetCode, DateTime date, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka30003";
			var body = new HttpParameterMap()
				.AddField("bsis_aset_cd", baseAssetCode)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomElwGetLpHoldingDailyTrends>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka30004 | ELW괴리율요청
		/// </summary>
		/// <param name="issuerCompanyCode"></param>
		/// <param name="baseAssetCode"></param>
		/// <param name="rightsType"></param>
		/// <param name="lpCode"></param>
		/// <param name="isExcludeEndedElw"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomElwGetDisparityRates>> GetDisparityRatesAsync(KiwoomElwCompanyCode issuerCompanyCode, string baseAssetCode, KiwoomElwRightsType rightsType, KiwoomElwCompanyCode lpCode, bool isExcludeEndedElw, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka30004";
			var body = new HttpParameterMap()
				.AddField("isscomp_cd", issuerCompanyCode)
				.AddField("bsis_aset_cd", baseAssetCode)
				.AddField("rght_tp", rightsType)
				.AddField("lpcd", lpCode)
				.AddField("trde_end_elwskip", isExcludeEndedElw);

			return await _client.PostKiwoomRestApiAsync<KiwoomElwGetDisparityRates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka30005 | ELW조건검색요청
		/// </summary>
		/// <param name="issuerCompanyCode"></param>
		/// <param name="baseAssetCode"></param>
		/// <param name="rightsType"></param>
		/// <param name="lpCode"></param>
		/// <param name="sortType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomElwGetConditionSearchs>> GetConditionSearchsAsync(KiwoomElwCompanyCode issuerCompanyCode, string baseAssetCode, KiwoomElwRightsType rightsType, KiwoomElwCompanyCode lpCode, KiwoomElwSortType sortType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka30005";
			// ka30005는 다른 ELW TR(000~007)과 달리 권리구분을 1자리(0~7)로 받습니다.
			var body = new HttpParameterMap()
				.AddField("isscomp_cd", issuerCompanyCode)
				.AddField("bsis_aset_cd", baseAssetCode)
				.AddField("rght_tp", (int)rightsType)
				.AddField("lpcd", lpCode)
				.AddField("sort_tp", sortType);

			return await _client.PostKiwoomRestApiAsync<KiwoomElwGetConditionSearchs>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka30009 | ELW등락율순위요청
		/// </summary>
		/// <param name="sortType"></param>
		/// <param name="rightsType"></param>
		/// <param name="isExcludeEnded"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomElwGetChangeRateRanks>> GetChangeRateRanksAsync(KiwoomElwSortType sortType, KiwoomElwRightsType rightsType, bool isExcludeEnded, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka30009";
			var body = new HttpParameterMap()
				.AddField("sort_tp", sortType)
				.AddField("rght_tp", rightsType)
				.AddField("trde_end_skip", isExcludeEnded);

			return await _client.PostKiwoomRestApiAsync<KiwoomElwGetChangeRateRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka30010 | ELW잔량순위요청
		/// </summary>
		/// <param name="sortType"></param>
		/// <param name="rightsType"></param>
		/// <param name="isExcludeEnded"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomElwGetRequestRanks>> GetRequestRanksAsync(KiwoomElwSortType2 sortType, KiwoomElwRightsType rightsType, bool isExcludeEnded, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka30010";
			var body = new HttpParameterMap()
				.AddField("sort_tp", sortType)
				.AddField("rght_tp", rightsType)
				.AddField("trde_end_skip", isExcludeEnded);

			return await _client.PostKiwoomRestApiAsync<KiwoomElwGetRequestRanks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka30011 | ELW근접율요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomElwGetProximityRates>>GetProximityRatesAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka30011";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomElwGetProximityRates>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka30012 | ELW종목상세정보요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomElwGetStockInfo>> GetStockInfoAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka30012";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomElwGetStockInfo>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
