using KiwoomRestApi.Net.Clients.DomesticStocks;
using KiwoomRestApi.Net.Objects;
using KiwoomRestApi.Net.Objects.Commons;
using KiwoomRestApi.Net.Objects.Models;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KiwoomRestApi.Net.Clients
{
	/// <summary>
	/// 키움증권 WebSocket API 클라이언트입니다.
	/// 실시간 데이터 수신, 조건검색, 실시간 주식/계좌 정보 등의 기능을 제공합니다.
	/// <para><a href="https://openapi.kiwoom.com/guide/apiguide"/></para>
	/// </summary>
	/// <remarks>
	/// 이 클라이언트는 WebSocket을 통해 키움증권 서버와 실시간 통신을 수행합니다.
	/// 주식 시세, 계좌 잔고, 주문 체결 등의 실시간 데이터를 수신할 수 있습니다.
	/// </remarks>
	/// <example>
	/// <code>
	/// // 소켓 클라이언트 생성 및 연결
	/// var socketClient = await KiwoomSocketClient.CreateAsync(client.Token, isMock: true);
	/// 
	/// // 실시간 주식체결 수신
	/// socketClient.OnRealtimeStockExecutionReceived += (message) => 
	/// {
	///     Console.WriteLine($"체결가: {message.ElementAt(0).Values.CurrentPrice}원");
	/// };
	/// 
	/// // 실시간 주식체결 구독
	/// await socketClient.WebSocket.SubscribeAsync([KiwoomWebSocketServiceName.StockExecution], ["005930", "000660"]);
	/// </code>
	/// </example>
	public class KiwoomSocketClient : BaseSocketClient
	{
		/// <summary>
		/// WebSocket 연결 엔드포인트 경로
		/// </summary>
		private static readonly string _endpoint = ApiEndpoint.DomesticStock.Socket;

		/// <summary>
		/// WebSocket 수신 버퍼 크기 (바이트)
		/// </summary>
		private readonly int _bufferSize = 4096;

		/// <summary>
		/// 국내주식 WebSocket API 기능을 제공합니다.
		/// 실시간 데이터 구독/해제, 조건검색 등의 기능을 포함합니다.
		/// </summary>
		public KiwoomRestApiClientDomesticStockWebSocket WebSocket { get; }

		public event Action<KiwoomSocketMessage>? OnMessageReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeOrderTrade>>>? OnRealtimeOrderTradeReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeBalance>>>? OnRealtimeBalanceReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeStockTrend>>>? OnRealtimeStockTrendReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeStockTrade>>>? OnRealtimeStockTradeReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeBestQuote>>>? OnRealtimeStockBestQuoteReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeOrderBook>>>? OnRealtimeOrderBookReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeAfterMarketQuote>>>? OnRealtimeAfterMarketQuoteReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeDailyBroker>>>? OnRealtimeDailyBrokerReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeEtfNav>>>? OnRealtimeEtfNavReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeExpectedTrade>>>? OnRealtimeExpectedTradeReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeInternationalGoldPrice>>>? OnRealtimeInternationalGoldPriceReceived;
        public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeIndustryIndex>>>? OnRealtimeIndustryIndexReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeIndustryChange>>>? OnRealtimeIndustryChangeReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeStockInfo>>>? OnRealtimeStockInfoReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeElwTheoreticalPrice>>>? OnRealtimeElwTheoreticalPriceReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeMarketOpenTime>>>? OnRealtimeMarketOpenTimeReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeElwIndicator>>>? OnRealtimeElwIndicatorReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeProgramTransaction>>>? OnRealtimeProgramTransactionReceived;
		public event Action<IEnumerable<KiwoomWebSocketRealtimeSubscription<KiwoomWebSocketRealtimeViEvent>>>? OnRealtimeViEventReceived;

		public event Action<IEnumerable<KiwoomWebSocketConditionSearchList>>? OnConditionSearchListReceived;
#pragma warning disable CS0067 // 조건검색 일반 응답은 현재 실시간(Realtime) 응답으로 통합 처리되어 별도로 발생하지 않음
		public event Action<IEnumerable<KiwoomWebSocketConditionSearchRequest>>? OnConditionSearchRequestReceived;
#pragma warning restore CS0067
		public event Action<IEnumerable<KiwoomWebSocketConditionSearchRequestRealtime>>? OnConditionSearchRequestRealtimeReceived;
		public event Action<IEnumerable<KiwoomWebSocketConditionSearchRequestRealtime2>>? OnConditionSearchRequestRealtime2Received;
		public event Action<IEnumerable<KiwoomWebSocketConditionSearchClear>>? OnConditionSearchClearReceived;

		/// <summary>
		/// KiwoomSocketClient의 새 인스턴스를 초기화합니다.
		/// </summary>
		public KiwoomSocketClient() : base()
		{
			WebSocket = new KiwoomRestApiClientDomesticStockWebSocket(this);
		}

		/// <summary>
		/// 키움 WebSocket 클라이언트를 생성하고 연결을 설정합니다. (동기)
		/// </summary>
		/// <param name="token">OAuth 액세스 토큰</param>
		/// <param name="isMock">모의투자 여부 (기본값: false)</param>
		/// <returns>연결된 KiwoomSocketClient 인스턴스</returns>
		/// <exception cref="WebSocketException">WebSocket 연결 실패 시</exception>
		/// <exception cref="InvalidOperationException">로그인 실패 시</exception>
		public static KiwoomSocketClient Create(string token, bool isMock = false)
		{
			var uri = isMock ?
				new Uri(KiwoomUrls.MockSocketHost + _endpoint) :
				new Uri(KiwoomUrls.SocketHost + _endpoint);

			var socketClient = new KiwoomSocketClient();
			socketClient.ClientWebSocket.ConnectAsync(uri, CancellationToken.None).GetAwaiter().GetResult();
			socketClient._isConnect = true;
#if DEBUG
			Debug.WriteLine("Socket Connected.");
#endif

			var loginPacket = new
			{
				trnm = "LOGIN",
				token
			};
			socketClient.SendAsync(loginPacket).GetAwaiter().GetResult();

			_ = socketClient.ReceiveAsync(CancellationToken.None);

			return socketClient;
		}

		/// <summary>
		/// 키움 WebSocket 클라이언트를 생성하고 비동기로 연결을 설정합니다.
		/// </summary>
		/// <param name="token">OAuth 액세스 토큰</param>
		/// <param name="isMock">모의투자 여부 (기본값: false)</param>
		/// <returns>연결된 KiwoomSocketClient 인스턴스를 반환하는 Task</returns>
		/// <exception cref="WebSocketException">WebSocket 연결 실패 시</exception>
		/// <exception cref="InvalidOperationException">로그인 실패 시</exception>
		public static async Task<KiwoomSocketClient> CreateAsync(string token, bool isMock = false)
		{
			var uri = isMock ?
				new Uri(KiwoomUrls.MockSocketHost + _endpoint) :
				new Uri(KiwoomUrls.SocketHost + _endpoint);

			var socketClient = new KiwoomSocketClient();
			await socketClient.ClientWebSocket.ConnectAsync(uri, CancellationToken.None).ConfigureAwait(false);
			socketClient._isConnect = true;
#if DEBUG
			Debug.WriteLine("Socket Connected.");
#endif

			var loginPacket = new
			{
				trnm = "LOGIN",
				token
			};
			await socketClient.SendAsync(loginPacket).ConfigureAwait(false);

			_ = socketClient.ReceiveAsync(CancellationToken.None);

			return socketClient;
		}

		/// <summary>
		/// WebSocket으로부터 메시지를 비동기로 수신하고 처리합니다.
		/// </summary>
		/// <param name="cancellationToken">작업 취소 토큰</param>
		/// <returns>메시지 수신 작업을 나타내는 Task</returns>
		/// <exception cref="OperationCanceledException">작업이 취소된 경우</exception>
		/// <exception cref="WebSocketException">WebSocket 오류 발생 시</exception>
		public new async Task ReceiveAsync(CancellationToken cancellationToken)
		{
			var buffer = new byte[_bufferSize];
			try
			{
				while (ClientWebSocket.State == WebSocketState.Open && !cancellationToken.IsCancellationRequested)
				{
					using var ms = new MemoryStream();
					WebSocketReceiveResult result;
					do
					{
						result = await ClientWebSocket.ReceiveAsync(new ArraySegment<byte>(buffer), cancellationToken);

						if (result.MessageType == WebSocketMessageType.Close)
						{
#if DEBUG
							Debug.WriteLine("서버에서 연결 종료 요청");
#endif
							await DisconnectAsync();
							return;
						}

						ms.Write(buffer, 0, result.Count);
					} while (!result.EndOfMessage);

					ms.Seek(0, SeekOrigin.Begin);

					using var reader = new StreamReader(ms, Encoding.UTF8);
					var message = await reader.ReadToEndAsync();
					Debug.WriteLine($"{message}");

					var json = JsonConvert.DeserializeObject<KiwoomSocketMessage>(message);
					if (json == null) continue;

					switch (json.ServiceName)
					{
						case "PING":
							OnMessageReceived?.Invoke(json);
							await SendAsync(json, cancellationToken);
							break;

						case "LOGIN":
							OnMessageReceived?.Invoke(json);
							if (json.ReturnCode != 0)
							{
#if DEBUG
								Debug.WriteLine($"Login Failed: {json.ReturnMessage}");
#endif
								await DisconnectAsync();
							}
							else
							{
								_isLoggedIn = true;
							}
							break;

						case "SYSTEM":
							OnMessageReceived?.Invoke(json);
							break;

						case "REAL":
							InnerProcessForReceiveReal(message);
							break;

						case "CNSRLST":
							{
								var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage2<List<string>>>(message)?.Data?.Select(x => new KiwoomWebSocketConditionSearchList
								{
									Id = int.Parse(x[0]),
									Name = x[1]
								}).ToList();

								if (data != null)
									OnConditionSearchListReceived?.Invoke(data);
							}
							break;

						case "CNSRREQ":
							{
								var rawData = JsonConvert.DeserializeObject<JObject>(message);
								var dataNode = rawData?["data"];

								if (dataNode != null)
								{
									if (dataNode is JArray dataArray && dataArray.Count > 0)
									{
										var firstItem = dataArray[0] as JObject;

										if (firstItem?["trnm"] != null)
										{
											var data = dataNode.ToObject<IEnumerable<KiwoomWebSocketConditionSearchRequestRealtime2>>();
											if (data != null)
												OnConditionSearchRequestRealtime2Received?.Invoke(data);
										}
										else if (firstItem?["jmcode"] != null)
										{
											var data = dataNode.ToObject<IEnumerable<KiwoomWebSocketConditionSearchRequestRealtime>>();
											if (data != null)
												OnConditionSearchRequestRealtimeReceived?.Invoke(data);
										}
										else
										{
											var data = dataNode.ToObject<IEnumerable<KiwoomWebSocketConditionSearchRequest>>();
											if (data != null)
												OnConditionSearchRequestReceived?.Invoke(data);
										}
									}
								}
							}
							break;

						case "CNSRCLR":
							{
								var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage2<KiwoomWebSocketConditionSearchClear>>(message)?.Data;

								if (data != null)
									OnConditionSearchClearReceived?.Invoke(data);
							}
							break;

						default:
							OnMessageReceived?.Invoke(json);
							break;
					}
				}
			}
			catch (OperationCanceledException)
			{
#if DEBUG
				Debug.WriteLine("수신 작업 취소됨.");
#endif
			}
			catch (Exception ex)
			{
#if DEBUG
				Debug.WriteLine($"수신 중 예외 발생: {ex.Message}");
#endif
			}
		}

		/// <summary>
		/// 실시간 데이터 메시지를 파싱하고 해당하는 이벤트를 발생시킵니다.
		/// </summary>
		/// <param name="message">수신된 JSON 메시지</param>
		/// <remarks>
		/// 메시지 타입에 따라 적절한 실시간 데이터 이벤트를 발생시킵니다.
		/// 지원되는 타입: 주문체결(00), 계좌잔고(04), 주식시세(0A), 주식체결(0B) 등
		/// </remarks>
		private void InnerProcessForReceiveReal(string message)
		{
			var jsonReal = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<object>>(message);
			if (jsonReal == null || jsonReal.Data == null)
			{
				return;
			}

			foreach (var d in jsonReal.Data)
			{
				switch (d.Type)
				{
					case "00":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeOrderTrade>>(message)?.Data;
							if (data != null)
								OnRealtimeOrderTradeReceived?.Invoke(data);
						}
						break;

					case "04":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeBalance>>(message)?.Data;
							if (data != null)
								OnRealtimeBalanceReceived?.Invoke(data);
						}
						break;

					case "0A":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeStockTrend>>(message)?.Data;
							if (data != null)
								OnRealtimeStockTrendReceived?.Invoke(data);
						}
						break;

					case "0B":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeStockTrade>>(message)?.Data;
							if (data != null)
								OnRealtimeStockTradeReceived?.Invoke(data);
						}
						break;

					case "0C":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeBestQuote>>(message)?.Data;
							if (data != null)
								OnRealtimeStockBestQuoteReceived?.Invoke(data);
						}
						break;

					case "0D":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeOrderBook>>(message)?.Data;
							if (data != null)
								OnRealtimeOrderBookReceived?.Invoke(data);
						}
						break;

					case "0E":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeAfterMarketQuote>>(message)?.Data;
							if (data != null)
								OnRealtimeAfterMarketQuoteReceived?.Invoke(data);
						}
						break;

					case "0F":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeDailyBroker>>(message)?.Data;
							if (data != null)
								OnRealtimeDailyBrokerReceived?.Invoke(data);
						}
						break;

					case "0G":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeEtfNav>>(message)?.Data;
							if (data != null)
								OnRealtimeEtfNavReceived?.Invoke(data);
						}
						break;

					case "0H":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeExpectedTrade>>(message)?.Data;
							if (data != null)
								OnRealtimeExpectedTradeReceived?.Invoke(data);
						}
						break;

                    case "0I":
                        {
                            var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeInternationalGoldPrice>>(message)?.Data;
                            if (data != null)
                                OnRealtimeInternationalGoldPriceReceived?.Invoke(data);
                        }
                        break;

                    case "0J":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeIndustryIndex>>(message)?.Data;
							if (data != null)
								OnRealtimeIndustryIndexReceived?.Invoke(data);
						}
						break;

					case "0U":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeIndustryChange>>(message)?.Data;
							if (data != null)
								OnRealtimeIndustryChangeReceived?.Invoke(data);
						}
						break;

					case "0g":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeStockInfo>>(message)?.Data;
							if (data != null)
								OnRealtimeStockInfoReceived?.Invoke(data);
						}
						break;

					case "0m":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeElwTheoreticalPrice>>(message)?.Data;
							if (data != null)
								OnRealtimeElwTheoreticalPriceReceived?.Invoke(data);
						}
						break;

					case "0s":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeMarketOpenTime>>(message)?.Data;
							if (data != null)
								OnRealtimeMarketOpenTimeReceived?.Invoke(data);
						}
						break;

					case "0u":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeElwIndicator>>(message)?.Data;
							if (data != null)
								OnRealtimeElwIndicatorReceived?.Invoke(data);
						}
						break;

					case "0w":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeProgramTransaction>>(message)?.Data;
							if (data != null)
								OnRealtimeProgramTransactionReceived?.Invoke(data);
						}
						break;

					case "1h":
						{
							var data = JsonConvert.DeserializeObject<KiwoomWebSocketReceiveMessage<KiwoomWebSocketRealtimeViEvent>>(message)?.Data;
							if (data != null)
								OnRealtimeViEventReceived?.Invoke(data);
						}
						break;

					default:
						break;
				}
			}
		}
	}
}
