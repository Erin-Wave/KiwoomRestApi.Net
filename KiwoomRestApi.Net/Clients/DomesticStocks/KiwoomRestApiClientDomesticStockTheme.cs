using KiwoomRestApi.Net.Enums.DomesticStock.Theme;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;
using KiwoomRestApi.Net.Objects.Models.DomesticStock;

using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	/// <summary>
	/// 테마 API 클라이언트
	/// 현재 2개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientDomesticStockTheme(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.Theme;

		/// <summary>
		/// | ka90001 | 테마그룹별요청
		/// </summary>
		/// <param name="queryType"></param>
		/// <param name="daysBefore"></param>
		/// <param name="ChangeProfitType"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="stockCode"></param>
		/// <param name="themeName">※ 키움 API에서 삭제 예정인 파라미터입니다.</param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomThemeGetGroups>> GetGroupsAsync(KiwoomThemeQueryType queryType, int daysBefore, KiwoomThemeChangeProfitType ChangeProfitType, KiwoomThemeStockExchangeType stockExchangeType, string stockCode = "", string themeName = "", CancellationToken cancellationToken = default)
		{
			const string apiId = "ka90001";
			var body = new HttpParameterMap()
				.AddField("qry_tp", queryType)
				.AddField("date_tp", daysBefore)
				.AddField("flu_pl_amt_tp", ChangeProfitType)
				.AddField("stex_tp", stockExchangeType)
				.AddField("stk_cd", stockCode)
				.AddField("thema_nm", themeName);

			return await _client.PostKiwoomRestApiAsync<KiwoomThemeGetGroups>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka90002 | 테마구성종목요청
		/// </summary>
		/// <param name="themeGroupCode"></param>
		/// <param name="stockExchangeType"></param>
		/// <param name="daysBefore"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomThemeGetComponentStocks>> GetComponentStocksAsync(string themeGroupCode, KiwoomThemeStockExchangeType stockExchangeType, int daysBefore = 1, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka90002";
			var body = new HttpParameterMap()
				.AddField("thema_grp_cd", themeGroupCode)
				.AddField("stex_tp", stockExchangeType)
				.AddField("date_tp", daysBefore);

			return await _client.PostKiwoomRestApiAsync<KiwoomThemeGetComponentStocks>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
