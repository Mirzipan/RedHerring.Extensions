﻿using System.Runtime.CompilerServices;

namespace RedHerring.Extensions.Mathematics;

public static class FloatExtensions
{
    #region Equality

    /// <summary>
    /// Returns true if this is zero or within the tolerance interval.
    /// </summary>
    /// <param name="this"></param>
    /// <param name="tolerance"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsZero(this float @this, float tolerance = float.Epsilon) => Math.Abs(@this) <= tolerance;

    /// <summary>
    /// Returns true if this is neither NaN nor Infinity.
    /// </summary>
    /// <param name="this"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsValid(this float @this) => !float.IsNaN(@this) && !float.IsInfinity(@this);

    /// <summary>
    /// Returns true if this and the other value are equal enough.
    /// </summary>
    /// <param name="this"></param>
    /// <param name="other"></param>
    /// <param name="tolerance">Optional value that specifies how close this and the other value need to be in order to be considered equal.</param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool Approximately(this float @this, float other, float tolerance = float.Epsilon)
    {
        return Math.Abs(@this - other) <= Math.Abs(tolerance);
    }

    #endregion Equality

    #region Queries

    /// <summary>
    /// Returns true if this is between 0 and 1.
    /// </summary>
    /// <param name="this"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsBetween01(this float @this) => IsBetween(@this, 0f, 1f);

    /// <summary>
    /// Returns true if this is between min and max
    /// </summary>
    /// <param name="this"></param>
    /// <param name="min">Lower bound (inclusive)</param>
    /// <param name="max">Upped bound (inclusive)</param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsBetween(this float @this, float min, float max)
    {
        return @this >= min && @this <= max;
    }

    #endregion Queries

    #region Manipulation

    /// <summary>
    /// Clamps this between 0 and 1.
    /// </summary>
    /// <param name="this"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Clamp01(this float @this) => Math.Clamp(@this, 0f, 1f);

    /// <summary>
    /// Clamps this between min and max values.
    /// </summary>
    /// <param name="this"></param>
    /// <param name="min">Lower bound</param>
    /// <param name="max">Upped bound</param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Clamp(this float @this, float min, float max) => Math.Clamp(@this, min, max);

    /// <summary>
    /// Rounds this to the nearest integer. 
    /// </summary>
    /// <param name="this"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Round(this float @this) =>  (float) Math.Round(@this);

    /// <summary>
    /// Rounds this to the nearest integer. 
    /// </summary>
    /// <param name="this"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int RoundToInt(this float @this) => (int) Math.Round(@this);

    /// <summary>
    /// Rounds this to the nearest integer greater than or equal to this. 
    /// </summary>
    /// <param name="this"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Ceil(this float @this) => (float) Math.Ceiling(@this);

    /// <summary>
    /// Rounds this to the nearest integer greater than or equal to this. 
    /// </summary>
    /// <param name="this"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int CeilToInt(this float @this) => (int) Math.Ceiling(@this);

    /// <summary>
    /// Rounds this to the nearest integer smaller than or equal to this. 
    /// </summary>
    /// <param name="this"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Floor(this float @this) => (float) Math.Floor(@this);

    /// <summary>
    /// Rounds this to the nearest integer smaller than or equal to this. 
    /// </summary>
    /// <param name="this"></param>
    /// <returns></returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int FloorToInt(this float @this) => (int) Math.Floor(@this);

    /// <summary>
    /// Returns -1 for negative numbers, 1 for positive numbers and 0 for zero.
    /// </summary>
    /// <param name="this"></param>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float Sign(this float @this) => Math.Sign(@this);
        
    #endregion Manipulation
}