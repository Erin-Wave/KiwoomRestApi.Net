using KiwoomRestApi.Net.Enums.DomesticStock.ForeignInstitution;
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
	/// 기관/외국인 API 클라이언트
	/// 현재 3개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientDomesticStockForeignInstitution(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.ForeignInstitution;

		/// <summary>
		/// | ka10008 | 주식외국인종목별매매동향
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomForeignInstitutionGetStockForeigners>> GetStockForeignersAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10008";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomForeignInstitutionGetStockForeigners>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10009 | 주식기관요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		[Obsolete("ka10009 TR은 2026-06-18에 삭제되었습니다. 기관 매매 정보는 MarketCondition.GetStockInstitutionTransactionTrendsAsync(ka10045)를 사용하세요.")]
		public async Task<KiwoomRestApiResponse<KiwoomForeignInstitutionGetStockInstitutions>> GetStockInstitutionsAsync(string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10009";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomForeignInstitutionGetStockInstitutions>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10131 | 기관외국인연속매매현황요청
		/// </summary>
		/// <param name="stockExchangeType"></param>
		/// <param name="marketType"></param>
		/// <param name="stockIndustryType"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="period">기간: 0이면 startDate, endDate로 조회</param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomForeignInstitutionGetContinuousTransactions>> GetContinuousTransactionsAsync(KiwoomForeignInstitutionStockExchangeType stockExchangeType, KiwoomForeignInstitutionMarketType marketType,  KiwoomForeignInstitutionStockIndustryType stockIndustryType, KiwoomForeignInstitutionAmountQuantityType amountQuantityType, int period = 0, DateTime? startDate = null, DateTime? endDate = null, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10131";
			var body = new HttpParameterMap()
				.AddField("dt", period)
				.AddField("stex_tp", stockExchangeType)
				.AddField("mrkt_tp", marketType)
				.AddField("netslmt_tp", "2") // 순매수(고정값)
				.AddField("stk_inds_tp", stockIndustryType)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("strt_dt", startDate)
				.AddField("end_dt", endDate);

			return await _client.PostKiwoomRestApiAsync<KiwoomForeignInstitutionGetContinuousTransactions>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

        /// <summary>
        /// | ka52301 | 금현물투자자현황
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<KiwoomRestApiResponse<KiwoomForeignInstitutionGetGoldSpotInvestorStatus>> GetGoldSpotInvestorStatusAsync(CancellationToken cancellationToken = default)
        {
            const string apiId = "ka52301";
			var body = new HttpParameterMap();

            return await _client.PostKiwoomRestApiAsync<KiwoomForeignInstitutionGetGoldSpotInvestorStatus>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
        }
    }
}
