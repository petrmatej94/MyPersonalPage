function initializeTradingViewChart() {
    new TradingView.widget({
        container_id: "tradingview-chart",
        autosize: true,
        symbol: "CME:6E1!",
        interval: "D",
        timezone: "Etc/UTC",
        theme: "dark",
        style: "1",
        locale: "en",
        toolbar_bg: "#f1f3f6",
        enable_publishing: false,
        hide_side_toolbar: true,
        allow_symbol_change: true,
    });
}
