using KiwoomRestApi.Net.Enums;
using KiwoomRestApi.Net.Enums.DomesticStock.Chart;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;
using KiwoomRestApi.Net.Objects.Models.DomesticStock;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients.DomesticStocks
{
	/// <summary>
	/// 차트 API 클라이언트
	/// 현재 27개
	/// </summary>
	/// <param name="client"></param>
	public class KiwoomRestApiClientDomesticStockChart(KiwoomRestApiClient client) : BaseClient
	{
		private readonly KiwoomRestApiClient _client = client;
		private readonly string _endpoint = ApiEndpoint.DomesticStock.Chart;

		/// <summary>
		/// | ka10060 | 종목별투자자기관별차트요청
		/// </summary>
		/// <param name="date"></param>
		/// <param name="stockCode"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="transactionType"></param>
		/// <param name="unitType"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetInvestorInstitutionCharts>> GetStockInvestorInstitutionChartsAsync(DateTime date, string stockCode, KiwoomChartAmountQuantityType amountQuantityType, KiwoomChartTransactionType transactionType, KiwoomChartUnitType unitType, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10060";
			var body = new HttpParameterMap()
				.AddField("dt", date)
				.AddField("stk_cd", stockCode)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("trde_tp", transactionType)
				.AddField("unit_tp", unitType);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetInvestorInstitutionCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10064 | 장중투자자별매매차트요청
		/// </summary>
		/// <param name="marketType"></param>
		/// <param name="amountQuantityType"></param>
		/// <param name="transactionType"></param>
		/// <param name="stockCode"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetIntradayInvestorTradeCharts>> GetIntradayInvestorTradeChartsAsync(KiwoomChartMarketType marketType, KiwoomChartAmountQuantityType amountQuantityType, KiwoomChartTransactionType transactionType, string stockCode, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10064";
			var body = new HttpParameterMap()
				.AddField("mrkt_tp", marketType)
				.AddField("amt_qty_tp", amountQuantityType)
				.AddField("trde_tp", transactionType)
				.AddField("stk_cd", stockCode);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIntradayInvestorTradeCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka10079 | 주식틱차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetTickCharts>> GetTickChartsAsync(string stockCode, int tickCount, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10079";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("tic_scope", tickCount)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetTickCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 주식틱차트조회요청(기간)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetTickChartItem>> GetTickChartsByRangeAsync(string stockCode, int tickCount, DateTime startDate, DateTime endDate, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetTickChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetTickChartsAsync(stockCode, tickCount, isUpdateStockPrice, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.TradeTime >= startDate && x.TradeTime <= endDate));

				if (result.Data.Items.Last().TradeTime < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka10080 | 주식분봉차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="date"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetMinuteCharts>> GetMinuteChartsAsync(string stockCode, int tickCount, DateTime date, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10080";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("tic_scope", tickCount)
				.AddField("upd_stkpc_tp", isUpdateStockPrice)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetMinuteCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 주식분봉차트조회요청(기간)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetTickChartItem>> GetMinuteChartsByRangeAsync(string stockCode, int tickCount, DateTime startDate, DateTime endDate, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetTickChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetMinuteChartsAsync(stockCode, tickCount, endDate, isUpdateStockPrice, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.TradeTime >= startDate && x.TradeTime <= endDate));

				if (result.Data.Items.Last().TradeTime < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka10081 | 주식일봉차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetDailyCharts>> GetDailyChartsAsync(string stockCode, DateTime date, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10081";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetDailyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 주식일봉차트조회요청(기간)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetChartItem>> GetDailyChartsByRangeAsync(string stockCode, DateTime startDate, DateTime endDate, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetDailyChartsAsync(stockCode, endDate, isUpdateStockPrice, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka10082 | 주식주봉차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetWeeklyCharts>> GetWeeklyChartsAsync(string stockCode, DateTime date, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10082";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetWeeklyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 주식주봉차트조회요청(기간)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetChartItem>> GetWeeklyChartsByRangeAsync(string stockCode, DateTime startDate, DateTime endDate, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetWeeklyChartsAsync(stockCode, endDate, isUpdateStockPrice, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka10083 | 주식월봉차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetMonthlyCharts>> GetMonthlyChartsAsync(string stockCode, DateTime date, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10083";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetMonthlyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 주식월봉차트조회요청(기간)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetChartItem>> GetMonthlyChartsByRangeAsync(string stockCode, DateTime startDate, DateTime endDate, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetMonthlyChartsAsync(stockCode, endDate, isUpdateStockPrice, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka10094 | 주식년봉차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetYearlyCharts>> GetYearlyChartsAsync(string stockCode, DateTime date, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka10094";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetYearlyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 주식년봉차트조회요청(기간)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetYearChartItem>> GetYearlyChartsByRangeAsync(string stockCode, DateTime startDate, DateTime endDate, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetYearChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetYearlyChartsAsync(stockCode, endDate, isUpdateStockPrice, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka11079 | 주식틱차트정규장조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetRegularMarketTickCharts>> GetRegularMarketTickChartsAsync(string stockCode, int tickCount, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka11079";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("tic_scope", tickCount)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetRegularMarketTickCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 주식틱차트정규장조회요청(기간)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetTickChartItem>> GetRegularMarketTickChartsByRangeAsync(string stockCode, int tickCount, DateTime startDate, DateTime endDate, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetTickChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetRegularMarketTickChartsAsync(stockCode, tickCount, isUpdateStockPrice, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.TradeTime >= startDate && x.TradeTime <= endDate));

				if (result.Data.Items.Last().TradeTime < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka11080 | 주식분봉차트정규장조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="date"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetRegularMarketMinuteCharts>> GetRegularMarketMinuteChartsAsync(string stockCode, int tickCount, DateTime date, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka11080";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("tic_scope", tickCount)
				.AddField("upd_stkpc_tp", isUpdateStockPrice)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetRegularMarketMinuteCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 주식분봉차트정규장조회요청(기간)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetTickChartItem>> GetRegularMarketMinuteChartsByRangeAsync(string stockCode, int tickCount, DateTime startDate, DateTime endDate, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetTickChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetRegularMarketMinuteChartsAsync(stockCode, tickCount, endDate, isUpdateStockPrice, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.TradeTime >= startDate && x.TradeTime <= endDate));

				if (result.Data.Items.Last().TradeTime < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka11081 | 주식일봉차트정규장조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetRegularMarketDailyCharts>> GetRegularMarketDailyChartsAsync(string stockCode, DateTime date, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka11081";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetRegularMarketDailyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 주식일봉차트정규장조회요청(기간)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetChartItem>> GetRegularMarketDailyChartsByRangeAsync(string stockCode, DateTime startDate, DateTime endDate, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetRegularMarketDailyChartsAsync(stockCode, endDate, isUpdateStockPrice, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka11082 | 주식주봉차트정규장조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetRegularMarketWeeklyCharts>> GetRegularMarketWeeklyChartsAsync(string stockCode, DateTime date, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka11082";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetRegularMarketWeeklyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 주식주봉차트정규장조회요청(기간)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetChartItem>> GetRegularMarketWeeklyChartsByRangeAsync(string stockCode, DateTime startDate, DateTime endDate, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetRegularMarketWeeklyChartsAsync(stockCode, endDate, isUpdateStockPrice, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka11083 | 주식월봉차트정규장조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetRegularMarketMonthlyCharts>> GetRegularMarketMonthlyChartsAsync(string stockCode, DateTime date, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka11083";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetRegularMarketMonthlyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 주식월봉차트정규장조회요청(기간)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetChartItem>> GetRegularMarketMonthlyChartsByRangeAsync(string stockCode, DateTime startDate, DateTime endDate, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetRegularMarketMonthlyChartsAsync(stockCode, endDate, isUpdateStockPrice, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka11094 | 주식년봉차트정규장조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetRegularMarketYearlyCharts>> GetRegularMarketYearlyChartsAsync(string stockCode, DateTime date, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka11094";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetRegularMarketYearlyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 주식년봉차트정규장조회요청(기간)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetYearChartItem>> GetRegularMarketYearlyChartsByRangeAsync(string stockCode, DateTime startDate, DateTime endDate, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetYearChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetRegularMarketYearlyChartsAsync(stockCode, endDate, isUpdateStockPrice, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka20004 | 업종틱차트조회요청
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetIndustryTickCharts>> GetIndustryTickChartsAsync(KiwoomChartIndustryCode industryCode, int tickCount, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20004";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("tic_scope", tickCount);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIndustryTickCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 업종틱차트조회요청(기간)
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetIndustryTickChartItem>> GetIndustryTickChartsByRangeAsync(KiwoomChartIndustryCode industryCode, int tickCount, DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetIndustryTickChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetIndustryTickChartsAsync(industryCode, tickCount, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.TradeTime >= startDate && x.TradeTime <= endDate));

				if (result.Data.Items.Last().TradeTime < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka20005 | 업종분봉조회요청
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetIndustryMinuteCharts>> GetIndustryMinuteChartsAsync(KiwoomChartIndustryCode industryCode, int tickCount, DateTime date, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20005";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("tic_scope", tickCount)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIndustryMinuteCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 업종분봉조회요청(기간)
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetIndustryMinuteChartItem>> GetIndustryMinuteChartsByRangeAsync(KiwoomChartIndustryCode industryCode, int tickCount, DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetIndustryMinuteChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetIndustryMinuteChartsAsync(industryCode, tickCount, endDate, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.TradeTime >= startDate && x.TradeTime <= endDate));

				if (result.Data.Items.Last().TradeTime < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka20006 | 업종일봉조회요청
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetIndustryDailyCharts>> GetIndustryDailyChartsAsync(KiwoomChartIndustryCode industryCode, DateTime date, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20006";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIndustryDailyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 업종일봉조회요청(기간)
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetIndustryChartItem>> GetIndustryDailyChartsByRangeAsync(KiwoomChartIndustryCode industryCode, DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetIndustryChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetIndustryDailyChartsAsync(industryCode, endDate, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka20007 | 업종주봉조회요청
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetIndustryWeeklyCharts>> GetIndustryWeeklyChartsAsync(KiwoomChartIndustryCode industryCode, DateTime date, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20007";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIndustryWeeklyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 업종주봉조회요청(기간)
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetIndustryChartItem>> GetIndustryWeeklyChartsByRangeAsync(KiwoomChartIndustryCode industryCode, DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetIndustryChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetIndustryWeeklyChartsAsync(industryCode, endDate, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka20008 | 업종월봉조회요청
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetIndustryMonthlyCharts>> GetIndustryMonthlyChartsAsync(KiwoomChartIndustryCode industryCode, DateTime date, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20008";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIndustryMonthlyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 업종월봉조회요청(기간)
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetIndustryChartItem>> GetIndustryMonthlyChartsByRangeAsync(KiwoomChartIndustryCode industryCode, DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetIndustryChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetIndustryMonthlyChartsAsync(industryCode, endDate, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka20019 | 업종년봉조회요청
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="date"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetIndustryYearlyCharts>> GetIndustryYearlyChartsAsync(KiwoomChartIndustryCode industryCode, DateTime date, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka20019";
			var body = new HttpParameterMap()
				.AddField("inds_cd", industryCode)
				.AddField("base_dt", date);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetIndustryYearlyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 업종년봉조회요청(기간)
		/// </summary>
		/// <param name="industryCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetIndustryChartItem>> GetIndustryYearlyChartsByRangeAsync(KiwoomChartIndustryCode industryCode, DateTime startDate, DateTime endDate, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetIndustryChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetIndustryYearlyChartsAsync(industryCode, endDate, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka50079 | 금현물틱차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetGoldSpotTickCharts>> GetGoldSpotTickChartsAsync(KiwoomGoldSpotStockCode stockCode, int tickCount, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka50079";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("tic_scope", tickCount)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetGoldSpotTickCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 금현물틱차트조회요청(기간)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetGoldSpotTickChartItem>> GetGoldSpotTickChartsByRangeAsync(KiwoomGoldSpotStockCode stockCode, int tickCount, DateTime startDate, DateTime endDate, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetGoldSpotTickChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetGoldSpotTickChartsAsync(stockCode, tickCount, isUpdateStockPrice, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.TradeTime >= startDate && x.TradeTime <= endDate));

				if (result.Data.Items.Last().TradeTime < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka50080 | 금현물분봉차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetGoldSpotMinuteCharts>> GetGoldSpotMinuteChartsAsync(KiwoomGoldSpotStockCode stockCode, int tickCount, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka50080";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("tic_scope", tickCount)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetGoldSpotMinuteCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 금현물분봉차트조회요청(기간)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetGoldSpotMinuteChartItem>> GetGoldSpotMinuteChartsByRangeAsync(KiwoomGoldSpotStockCode stockCode, int tickCount, DateTime startDate, DateTime endDate, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetGoldSpotMinuteChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetGoldSpotMinuteChartsAsync(stockCode, tickCount, isUpdateStockPrice, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.TradeTime >= startDate && x.TradeTime <= endDate));

				if (result.Data.Items.Last().TradeTime < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka50081 | 금현물일봉차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetGoldSpotDailyCharts>> GetGoldSpotDailyChartsAsync(KiwoomGoldSpotStockCode stockCode, DateTime date, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka50081";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetGoldSpotDailyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 금현물일봉차트조회요청(기간)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetGoldSpotDailyChartItem>> GetGoldSpotDailyChartsByRangeAsync(KiwoomGoldSpotStockCode stockCode, DateTime startDate, DateTime endDate, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetGoldSpotDailyChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetGoldSpotDailyChartsAsync(stockCode, endDate, isUpdateStockPrice, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka50082 | 금현물주봉차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetGoldSpotWeeklyCharts>> GetGoldSpotWeeklyChartsAsync(KiwoomGoldSpotStockCode stockCode, DateTime date, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka50082";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetGoldSpotWeeklyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 금현물주봉차트조회요청(기간)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetGoldSpotChartItem>> GetGoldSpotWeeklyChartsByRangeAsync(KiwoomGoldSpotStockCode stockCode, DateTime startDate, DateTime endDate, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetGoldSpotChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetGoldSpotWeeklyChartsAsync(stockCode, endDate, isUpdateStockPrice, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka50083 | 금현물월봉차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="date"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetGoldSpotMonthlyCharts>> GetGoldSpotMonthlyChartsAsync(KiwoomGoldSpotStockCode stockCode, DateTime date, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka50083";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("base_dt", date)
				.AddField("upd_stkpc_tp", isUpdateStockPrice);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetGoldSpotMonthlyCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// 금현물월봉차트조회요청(기간)
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <param name="isUpdateStockPrice"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<List<KiwoomChartGetGoldSpotChartItem>> GetGoldSpotMonthlyChartsByRangeAsync(KiwoomGoldSpotStockCode stockCode, DateTime startDate, DateTime endDate, bool isUpdateStockPrice, CancellationToken cancellationToken = default)
		{
			var results = new List<KiwoomChartGetGoldSpotChartItem>();
			_client.NextKey = string.Empty;
			_client.ContYn = false;

			while (true)
			{
				var result = await GetGoldSpotMonthlyChartsAsync(stockCode, endDate, isUpdateStockPrice, cancellationToken)
					.ConfigureAwait(false);

				if (result?.Data?.Items == null || !result.Data.Items.Any()) break;

				results.AddRange(result.Data.Items.Where(x => x.Date >= startDate && x.Date <= endDate));

				if (result.Data.Items.Last().Date < startDate) break;
				if (string.IsNullOrEmpty(result.NextKey)) break;

				_client.NextKey = result.NextKey;
				_client.ContYn = true;

				await Task.Delay(_client.PagingDelay, cancellationToken);
			}

			return results;
		}

		/// <summary>
		/// | ka50091 | 금현물당일틱차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetGoldSpotTodayTickCharts>> GetGoldSpotTodayTickChartsAsync(KiwoomGoldSpotStockCode stockCode, int tickCount, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka50091";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("tic_scope", tickCount);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetGoldSpotTodayTickCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// | ka50092 | 금현물당일분봉차트조회요청
		/// </summary>
		/// <param name="stockCode"></param>
		/// <param name="tickCount"></param>
		/// <param name="cancellationToken"></param>
		/// <returns></returns>
		public async Task<KiwoomRestApiResponse<KiwoomChartGetGoldSpotTodayMinuteCharts>> GetGoldSpotTodayMinuteChartsAsync(KiwoomGoldSpotStockCode stockCode, int tickCount, CancellationToken cancellationToken = default)
		{
			const string apiId = "ka50092";
			var body = new HttpParameterMap()
				.AddField("stk_cd", stockCode)
				.AddField("tic_scope", tickCount);

			return await _client.PostKiwoomRestApiAsync<KiwoomChartGetGoldSpotTodayMinuteCharts>(_endpoint, apiId, body, cancellationToken).ConfigureAwait(false);
		}
	}
}
