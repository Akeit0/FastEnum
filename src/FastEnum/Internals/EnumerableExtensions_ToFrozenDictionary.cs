﻿// <auto-generated>
// This .cs file is generated by T4 template. Don't change it. Change the .tt file instead.
// </auto-generated>
using System;
using System.Collections.Generic;

namespace FastEnumUtility.Internals;



/// <summary>
/// Provides <see cref="IEnumerable{T}"/> extension methods.
/// </summary>
internal static partial class EnumerableExtensions
{
    #region FrozenDictionary
    /// <summary>
    /// Converts to <see cref="FrozenDictionary{TKey, TValue}"/>.
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <returns></returns>
    public static FrozenDictionary<TKey, TValue> ToFrozenDictionary<TKey, TValue>(this IEnumerable<TValue> source, Func<TValue, TKey> keySelector)
        => FrozenDictionary<TKey, TValue>.Create(source, keySelector);


    /// <summary>
    /// Converts to <see cref="FrozenDictionary{TKey, TValue}"/>.
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <param name="valueSelector"></param>
    /// <returns></returns>
    public static FrozenDictionary<TKey, TValue> ToFrozenDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector)
        => FrozenDictionary<TKey, TValue>.Create(source, keySelector, valueSelector);
    #endregion


    #region String Specialized FrozenDictionary
    /// <summary>
    /// Converts to <see cref="FrozenStringKeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <returns></returns>
    public static FrozenStringKeyDictionary<TValue> ToFrozenStringKeyDictionary<TValue>(this IEnumerable<TValue> source, Func<TValue, string> keySelector)
        => FrozenStringKeyDictionary<TValue>.Create(source, keySelector);


    /// <summary>
    /// Converts to <see cref="FrozenStringKeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <param name="valueSelector"></param>
    /// <returns></returns>
    public static FrozenStringKeyDictionary<TValue> ToFrozenStringKeyDictionary<TSource, TValue>(this IEnumerable<TSource> source, Func<TSource, string> keySelector, Func<TSource, TValue> valueSelector)
        => FrozenStringKeyDictionary<TValue>.Create(source, keySelector, valueSelector);
    #endregion


    #region SByte Specialized FrozenDictionary
    /// <summary>
    /// Converts to <see cref="FrozenSByteKeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <returns></returns>
    public static FrozenSByteKeyDictionary<TValue> ToFrozenSByteKeyDictionary<TValue>(this IEnumerable<TValue> source, Func<TValue, sbyte> keySelector)
        => FrozenSByteKeyDictionary<TValue>.Create(source, keySelector);


    /// <summary>
    /// Converts to <see cref="FrozenSByteKeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <param name="valueSelector"></param>
    /// <returns></returns>
    public static FrozenSByteKeyDictionary<TValue> ToFrozenSByteKeyDictionary<TSource, TValue>(this IEnumerable<TSource> source, Func<TSource, sbyte> keySelector, Func<TSource, TValue> valueSelector)
        => FrozenSByteKeyDictionary<TValue>.Create(source, keySelector, valueSelector);
    #endregion


    #region Byte Specialized FrozenDictionary
    /// <summary>
    /// Converts to <see cref="FrozenByteKeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <returns></returns>
    public static FrozenByteKeyDictionary<TValue> ToFrozenByteKeyDictionary<TValue>(this IEnumerable<TValue> source, Func<TValue, byte> keySelector)
        => FrozenByteKeyDictionary<TValue>.Create(source, keySelector);


    /// <summary>
    /// Converts to <see cref="FrozenByteKeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <param name="valueSelector"></param>
    /// <returns></returns>
    public static FrozenByteKeyDictionary<TValue> ToFrozenByteKeyDictionary<TSource, TValue>(this IEnumerable<TSource> source, Func<TSource, byte> keySelector, Func<TSource, TValue> valueSelector)
        => FrozenByteKeyDictionary<TValue>.Create(source, keySelector, valueSelector);
    #endregion


    #region Int16 Specialized FrozenDictionary
    /// <summary>
    /// Converts to <see cref="FrozenInt16KeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <returns></returns>
    public static FrozenInt16KeyDictionary<TValue> ToFrozenInt16KeyDictionary<TValue>(this IEnumerable<TValue> source, Func<TValue, short> keySelector)
        => FrozenInt16KeyDictionary<TValue>.Create(source, keySelector);


    /// <summary>
    /// Converts to <see cref="FrozenInt16KeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <param name="valueSelector"></param>
    /// <returns></returns>
    public static FrozenInt16KeyDictionary<TValue> ToFrozenInt16KeyDictionary<TSource, TValue>(this IEnumerable<TSource> source, Func<TSource, short> keySelector, Func<TSource, TValue> valueSelector)
        => FrozenInt16KeyDictionary<TValue>.Create(source, keySelector, valueSelector);
    #endregion


    #region UInt16 Specialized FrozenDictionary
    /// <summary>
    /// Converts to <see cref="FrozenUInt16KeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <returns></returns>
    public static FrozenUInt16KeyDictionary<TValue> ToFrozenUInt16KeyDictionary<TValue>(this IEnumerable<TValue> source, Func<TValue, ushort> keySelector)
        => FrozenUInt16KeyDictionary<TValue>.Create(source, keySelector);


    /// <summary>
    /// Converts to <see cref="FrozenUInt16KeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <param name="valueSelector"></param>
    /// <returns></returns>
    public static FrozenUInt16KeyDictionary<TValue> ToFrozenUInt16KeyDictionary<TSource, TValue>(this IEnumerable<TSource> source, Func<TSource, ushort> keySelector, Func<TSource, TValue> valueSelector)
        => FrozenUInt16KeyDictionary<TValue>.Create(source, keySelector, valueSelector);
    #endregion


    #region Int32 Specialized FrozenDictionary
    /// <summary>
    /// Converts to <see cref="FrozenInt32KeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <returns></returns>
    public static FrozenInt32KeyDictionary<TValue> ToFrozenInt32KeyDictionary<TValue>(this IEnumerable<TValue> source, Func<TValue, int> keySelector)
        => FrozenInt32KeyDictionary<TValue>.Create(source, keySelector);


    /// <summary>
    /// Converts to <see cref="FrozenInt32KeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <param name="valueSelector"></param>
    /// <returns></returns>
    public static FrozenInt32KeyDictionary<TValue> ToFrozenInt32KeyDictionary<TSource, TValue>(this IEnumerable<TSource> source, Func<TSource, int> keySelector, Func<TSource, TValue> valueSelector)
        => FrozenInt32KeyDictionary<TValue>.Create(source, keySelector, valueSelector);
    #endregion


    #region UInt32 Specialized FrozenDictionary
    /// <summary>
    /// Converts to <see cref="FrozenUInt32KeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <returns></returns>
    public static FrozenUInt32KeyDictionary<TValue> ToFrozenUInt32KeyDictionary<TValue>(this IEnumerable<TValue> source, Func<TValue, uint> keySelector)
        => FrozenUInt32KeyDictionary<TValue>.Create(source, keySelector);


    /// <summary>
    /// Converts to <see cref="FrozenUInt32KeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <param name="valueSelector"></param>
    /// <returns></returns>
    public static FrozenUInt32KeyDictionary<TValue> ToFrozenUInt32KeyDictionary<TSource, TValue>(this IEnumerable<TSource> source, Func<TSource, uint> keySelector, Func<TSource, TValue> valueSelector)
        => FrozenUInt32KeyDictionary<TValue>.Create(source, keySelector, valueSelector);
    #endregion


    #region Int64 Specialized FrozenDictionary
    /// <summary>
    /// Converts to <see cref="FrozenInt64KeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <returns></returns>
    public static FrozenInt64KeyDictionary<TValue> ToFrozenInt64KeyDictionary<TValue>(this IEnumerable<TValue> source, Func<TValue, long> keySelector)
        => FrozenInt64KeyDictionary<TValue>.Create(source, keySelector);


    /// <summary>
    /// Converts to <see cref="FrozenInt64KeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <param name="valueSelector"></param>
    /// <returns></returns>
    public static FrozenInt64KeyDictionary<TValue> ToFrozenInt64KeyDictionary<TSource, TValue>(this IEnumerable<TSource> source, Func<TSource, long> keySelector, Func<TSource, TValue> valueSelector)
        => FrozenInt64KeyDictionary<TValue>.Create(source, keySelector, valueSelector);
    #endregion


    #region UInt64 Specialized FrozenDictionary
    /// <summary>
    /// Converts to <see cref="FrozenUInt64KeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <returns></returns>
    public static FrozenUInt64KeyDictionary<TValue> ToFrozenUInt64KeyDictionary<TValue>(this IEnumerable<TValue> source, Func<TValue, ulong> keySelector)
        => FrozenUInt64KeyDictionary<TValue>.Create(source, keySelector);


    /// <summary>
    /// Converts to <see cref="FrozenUInt64KeyDictionary{TValue}"/>.
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    /// <param name="source"></param>
    /// <param name="keySelector"></param>
    /// <param name="valueSelector"></param>
    /// <returns></returns>
    public static FrozenUInt64KeyDictionary<TValue> ToFrozenUInt64KeyDictionary<TSource, TValue>(this IEnumerable<TSource> source, Func<TSource, ulong> keySelector, Func<TSource, TValue> valueSelector)
        => FrozenUInt64KeyDictionary<TValue>.Create(source, keySelector, valueSelector);
    #endregion
}
