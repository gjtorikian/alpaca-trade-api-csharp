﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace Alpaca.Markets
{
    /// <summary>
    /// Encapsulates data required for placing the market order on the Alpaca REST API.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public sealed class MarketOrder : SimpleOrderBase
    {
        internal MarketOrder(
            String symbol,
            Int64 quantity,
            OrderSide side)
            : base(
                symbol, quantity, side,
                OrderType.Market)
        {
        }

        /// <summary>
        /// Creates new buy market order using specified symbol and quantity.
        /// </summary>
        /// <param name="symbol">Order asset name.</param>
        /// <param name="quantity">Order quantity.</param>
        /// <returns>The new <see cref="MarketOrder"/> object instance.</returns>
        public static MarketOrder Buy(
            String symbol,
            Int64 quantity) =>
            new (
                symbol, quantity, OrderSide.Buy);

        /// <summary>
        /// Creates new sell market order using specified symbol and quantity.
        /// </summary>
        /// <param name="symbol">Order asset name.</param>
        /// <param name="quantity">Order quantity.</param>
        /// <returns>The new <see cref="MarketOrder"/> object instance.</returns>
        public static MarketOrder Sell(
            String symbol,
            Int64 quantity) =>
            new (
                symbol, quantity, OrderSide.Sell);
    }
}
