// <auto-generated>
// This .cs file is generated by T4 template. Don't change it. Change the .tt file instead.
// </auto-generated>
#nullable enable

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace FastEnumUtility.Internals;



internal static class UnderlyingOperation<T>
    where T : struct, Enum
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string? GetName(T value)
    {
        switch (EnumInfo<T>.s_typeCode)
        {
            case TypeCode.SByte:
                return SByteOperation.GetName(value);
            case TypeCode.Byte:
                return ByteOperation.GetName(value);
            case TypeCode.Int16:
                return Int16Operation.GetName(value);
            case TypeCode.UInt16:
                return UInt16Operation.GetName(value);
            case TypeCode.Int32:
                return Int32Operation.GetName(value);
            case TypeCode.UInt32:
                return UInt32Operation.GetName(value);
            case TypeCode.Int64:
                return Int64Operation.GetName(value);
            case TypeCode.UInt64:
                return UInt64Operation.GetName(value);
            default:
                ThrowHelper.ThrowUnexpectedCodeReached();
                return null;
        }
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool IsDefined(T value)
    {
        return EnumInfo<T>.s_typeCode switch
        {
            TypeCode.SByte => SByteOperation.IsDefined(value),
            TypeCode.Byte => ByteOperation.IsDefined(value),
            TypeCode.Int16 => Int16Operation.IsDefined(value),
            TypeCode.UInt16 => UInt16Operation.IsDefined(value),
            TypeCode.Int32 => Int32Operation.IsDefined(value),
            TypeCode.UInt32 => UInt32Operation.IsDefined(value),
            TypeCode.Int64 => Int64Operation.IsDefined(value),
            TypeCode.UInt64 => UInt64Operation.IsDefined(value),
            _ => false,
        };
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static string ToNumberString(T value)
    {
        switch (EnumInfo<T>.s_typeCode)
        {
            case TypeCode.SByte:
                return SByteOperation.ToNumberString(value);
            case TypeCode.Byte:
                return ByteOperation.ToNumberString(value);
            case TypeCode.Int16:
                return Int16Operation.ToNumberString(value);
            case TypeCode.UInt16:
                return UInt16Operation.ToNumberString(value);
            case TypeCode.Int32:
                return Int32Operation.ToNumberString(value);
            case TypeCode.UInt32:
                return UInt32Operation.ToNumberString(value);
            case TypeCode.Int64:
                return Int64Operation.ToNumberString(value);
            case TypeCode.UInt64:
                return UInt64Operation.ToNumberString(value);
            default:
                ThrowHelper.ThrowUnexpectedCodeReached();
                return null!;
        }
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool TryParseValue(ReadOnlySpan<char> text, out T result)
    {
        switch (EnumInfo<T>.s_typeCode)
        {
            case TypeCode.SByte:
                return SByteOperation.TryParseValue(text, out result);
            case TypeCode.Byte:
                return ByteOperation.TryParseValue(text, out result);
            case TypeCode.Int16:
                return Int16Operation.TryParseValue(text, out result);
            case TypeCode.UInt16:
                return UInt16Operation.TryParseValue(text, out result);
            case TypeCode.Int32:
                return Int32Operation.TryParseValue(text, out result);
            case TypeCode.UInt32:
                return UInt32Operation.TryParseValue(text, out result);
            case TypeCode.Int64:
                return Int64Operation.TryParseValue(text, out result);
            case TypeCode.UInt64:
                return UInt64Operation.TryParseValue(text, out result);
            default:
                result = default;
                return false;
        }
    }


    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
    {
        switch (EnumInfo<T>.s_typeCode)
        {
            case TypeCode.SByte:
                return SByteOperation.TryGetMember(value, out result);
            case TypeCode.Byte:
                return ByteOperation.TryGetMember(value, out result);
            case TypeCode.Int16:
                return Int16Operation.TryGetMember(value, out result);
            case TypeCode.UInt16:
                return UInt16Operation.TryGetMember(value, out result);
            case TypeCode.Int32:
                return Int32Operation.TryGetMember(value, out result);
            case TypeCode.UInt32:
                return UInt32Operation.TryGetMember(value, out result);
            case TypeCode.Int64:
                return Int64Operation.TryGetMember(value, out result);
            case TypeCode.UInt64:
                return UInt64Operation.TryGetMember(value, out result);
            default:
                result = default;
                return false;
        }
    }


    #region Nested Types
    private static class SByteOperation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string? GetName(T value)
            => TryGetMember(value, out var member) ? member.Name : null;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined(T value)
        {
            if (EnumInfo<T>.s_isContinuous)
            {
                var min = toNumber(EnumInfo<T>.s_minValue);
                var max = toNumber(EnumInfo<T>.s_maxValue);
                var val = toNumber(value);
                return (min <= val) && (val <= max);
            }
            else
            {
                return EnumInfo<T>.s_memberByValue!.ContainsKey(value);
            }


            #region Local Functions
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static sbyte toNumber(T value)
            {
                var x = Unsafe.BitCast<T, sbyte>(value);
                return x;
            }
            #endregion
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToNumberString(T value)
        {
            var x = Unsafe.BitCast<T, sbyte>(value);
            return x.ToString(null, CultureInfo.InvariantCulture);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryParseValue(ReadOnlySpan<char> text, out T result)
        {
            Unsafe.SkipInit(out result);
            ref var x = ref Unsafe.As<T, sbyte>(ref result);
            return sbyte.TryParse(text, CultureInfo.InvariantCulture, out x);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
        {
            if (EnumInfo<T>.s_isContinuous)
            {
                var val = toNumber(value);
                var min = toNumber(EnumInfo<T>.s_minValue);
                var index = (int)(val - min);
                var members = EnumInfo<T>.s_orderedMembers;
                if ((uint)index < (uint)members.Length)
                {
                    result = members.At(index);
                    return true;
                }
                else
                {
                    result = null;
                    return false;
                }
            }
            else
            {
                return EnumInfo<T>.s_memberByValue!.TryGetValue(value, out result);
            }


            #region Local Functions
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static sbyte toNumber(T value)
            {
                var x = Unsafe.BitCast<T, sbyte>(value);
                return x;
            }
            #endregion
        }
    }



    private static class ByteOperation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string? GetName(T value)
            => TryGetMember(value, out var member) ? member.Name : null;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined(T value)
        {
            if (EnumInfo<T>.s_isContinuous)
            {
                var min = toNumber(EnumInfo<T>.s_minValue);
                var max = toNumber(EnumInfo<T>.s_maxValue);
                var val = toNumber(value);
                return (min <= val) && (val <= max);
            }
            else
            {
                return EnumInfo<T>.s_memberByValue!.ContainsKey(value);
            }


            #region Local Functions
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static byte toNumber(T value)
            {
                var x = Unsafe.BitCast<T, byte>(value);
                return x;
            }
            #endregion
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToNumberString(T value)
        {
            var x = Unsafe.BitCast<T, byte>(value);
            return x.ToString(null, CultureInfo.InvariantCulture);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryParseValue(ReadOnlySpan<char> text, out T result)
        {
            Unsafe.SkipInit(out result);
            ref var x = ref Unsafe.As<T, byte>(ref result);
            return byte.TryParse(text, CultureInfo.InvariantCulture, out x);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
        {
            if (EnumInfo<T>.s_isContinuous)
            {
                var val = toNumber(value);
                var min = toNumber(EnumInfo<T>.s_minValue);
                var index = (int)(val - min);
                var members = EnumInfo<T>.s_orderedMembers;
                if ((uint)index < (uint)members.Length)
                {
                    result = members.At(index);
                    return true;
                }
                else
                {
                    result = null;
                    return false;
                }
            }
            else
            {
                return EnumInfo<T>.s_memberByValue!.TryGetValue(value, out result);
            }


            #region Local Functions
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static byte toNumber(T value)
            {
                var x = Unsafe.BitCast<T, byte>(value);
                return x;
            }
            #endregion
        }
    }



    private static class Int16Operation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string? GetName(T value)
            => TryGetMember(value, out var member) ? member.Name : null;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined(T value)
        {
            if (EnumInfo<T>.s_isContinuous)
            {
                var min = toNumber(EnumInfo<T>.s_minValue);
                var max = toNumber(EnumInfo<T>.s_maxValue);
                var val = toNumber(value);
                return (min <= val) && (val <= max);
            }
            else
            {
                return EnumInfo<T>.s_memberByValue!.ContainsKey(value);
            }


            #region Local Functions
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static short toNumber(T value)
            {
                var x = Unsafe.BitCast<T, short>(value);
                return x;
            }
            #endregion
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToNumberString(T value)
        {
            var x = Unsafe.BitCast<T, short>(value);
            return x.ToString(null, CultureInfo.InvariantCulture);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryParseValue(ReadOnlySpan<char> text, out T result)
        {
            Unsafe.SkipInit(out result);
            ref var x = ref Unsafe.As<T, short>(ref result);
            return short.TryParse(text, CultureInfo.InvariantCulture, out x);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
        {
            if (EnumInfo<T>.s_isContinuous)
            {
                var val = toNumber(value);
                var min = toNumber(EnumInfo<T>.s_minValue);
                var index = (int)(val - min);
                var members = EnumInfo<T>.s_orderedMembers;
                if ((uint)index < (uint)members.Length)
                {
                    result = members.At(index);
                    return true;
                }
                else
                {
                    result = null;
                    return false;
                }
            }
            else
            {
                return EnumInfo<T>.s_memberByValue!.TryGetValue(value, out result);
            }


            #region Local Functions
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static short toNumber(T value)
            {
                var x = Unsafe.BitCast<T, short>(value);
                return x;
            }
            #endregion
        }
    }



    private static class UInt16Operation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string? GetName(T value)
            => TryGetMember(value, out var member) ? member.Name : null;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined(T value)
        {
            if (EnumInfo<T>.s_isContinuous)
            {
                var min = toNumber(EnumInfo<T>.s_minValue);
                var max = toNumber(EnumInfo<T>.s_maxValue);
                var val = toNumber(value);
                return (min <= val) && (val <= max);
            }
            else
            {
                return EnumInfo<T>.s_memberByValue!.ContainsKey(value);
            }


            #region Local Functions
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static ushort toNumber(T value)
            {
                var x = Unsafe.BitCast<T, ushort>(value);
                return x;
            }
            #endregion
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToNumberString(T value)
        {
            var x = Unsafe.BitCast<T, ushort>(value);
            return x.ToString(null, CultureInfo.InvariantCulture);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryParseValue(ReadOnlySpan<char> text, out T result)
        {
            Unsafe.SkipInit(out result);
            ref var x = ref Unsafe.As<T, ushort>(ref result);
            return ushort.TryParse(text, CultureInfo.InvariantCulture, out x);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
        {
            if (EnumInfo<T>.s_isContinuous)
            {
                var val = toNumber(value);
                var min = toNumber(EnumInfo<T>.s_minValue);
                var index = (int)(val - min);
                var members = EnumInfo<T>.s_orderedMembers;
                if ((uint)index < (uint)members.Length)
                {
                    result = members.At(index);
                    return true;
                }
                else
                {
                    result = null;
                    return false;
                }
            }
            else
            {
                return EnumInfo<T>.s_memberByValue!.TryGetValue(value, out result);
            }


            #region Local Functions
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static ushort toNumber(T value)
            {
                var x = Unsafe.BitCast<T, ushort>(value);
                return x;
            }
            #endregion
        }
    }



    private static class Int32Operation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string? GetName(T value)
            => TryGetMember(value, out var member) ? member.Name : null;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined(T value)
        {
            if (EnumInfo<T>.s_isContinuous)
            {
                var min = toNumber(EnumInfo<T>.s_minValue);
                var max = toNumber(EnumInfo<T>.s_maxValue);
                var val = toNumber(value);
                return (min <= val) && (val <= max);
            }
            else
            {
                return EnumInfo<T>.s_memberByValue!.ContainsKey(value);
            }


            #region Local Functions
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static int toNumber(T value)
            {
                var x = Unsafe.BitCast<T, int>(value);
                return x;
            }
            #endregion
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToNumberString(T value)
        {
            var x = Unsafe.BitCast<T, int>(value);
            return x.ToString(null, CultureInfo.InvariantCulture);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryParseValue(ReadOnlySpan<char> text, out T result)
        {
            Unsafe.SkipInit(out result);
            ref var x = ref Unsafe.As<T, int>(ref result);
            return int.TryParse(text, CultureInfo.InvariantCulture, out x);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
        {
            if (EnumInfo<T>.s_isContinuous)
            {
                var val = toNumber(value);
                var min = toNumber(EnumInfo<T>.s_minValue);
                var index = (int)(val - min);
                var members = EnumInfo<T>.s_orderedMembers;
                if ((uint)index < (uint)members.Length)
                {
                    result = members.At(index);
                    return true;
                }
                else
                {
                    result = null;
                    return false;
                }
            }
            else
            {
                return EnumInfo<T>.s_memberByValue!.TryGetValue(value, out result);
            }


            #region Local Functions
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static int toNumber(T value)
            {
                var x = Unsafe.BitCast<T, int>(value);
                return x;
            }
            #endregion
        }
    }



    private static class UInt32Operation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string? GetName(T value)
            => TryGetMember(value, out var member) ? member.Name : null;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined(T value)
        {
            if (EnumInfo<T>.s_isContinuous)
            {
                var min = toNumber(EnumInfo<T>.s_minValue);
                var max = toNumber(EnumInfo<T>.s_maxValue);
                var val = toNumber(value);
                return (min <= val) && (val <= max);
            }
            else
            {
                return EnumInfo<T>.s_memberByValue!.ContainsKey(value);
            }


            #region Local Functions
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static uint toNumber(T value)
            {
                var x = Unsafe.BitCast<T, uint>(value);
                return x;
            }
            #endregion
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToNumberString(T value)
        {
            var x = Unsafe.BitCast<T, uint>(value);
            return x.ToString(null, CultureInfo.InvariantCulture);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryParseValue(ReadOnlySpan<char> text, out T result)
        {
            Unsafe.SkipInit(out result);
            ref var x = ref Unsafe.As<T, uint>(ref result);
            return uint.TryParse(text, CultureInfo.InvariantCulture, out x);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
        {
            if (EnumInfo<T>.s_isContinuous)
            {
                var val = toNumber(value);
                var min = toNumber(EnumInfo<T>.s_minValue);
                var index = (int)(val - min);
                var members = EnumInfo<T>.s_orderedMembers;
                if ((uint)index < (uint)members.Length)
                {
                    result = members.At(index);
                    return true;
                }
                else
                {
                    result = null;
                    return false;
                }
            }
            else
            {
                return EnumInfo<T>.s_memberByValue!.TryGetValue(value, out result);
            }


            #region Local Functions
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static uint toNumber(T value)
            {
                var x = Unsafe.BitCast<T, uint>(value);
                return x;
            }
            #endregion
        }
    }



    private static class Int64Operation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string? GetName(T value)
            => TryGetMember(value, out var member) ? member.Name : null;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined(T value)
        {
            if (EnumInfo<T>.s_isContinuous)
            {
                var min = toNumber(EnumInfo<T>.s_minValue);
                var max = toNumber(EnumInfo<T>.s_maxValue);
                var val = toNumber(value);
                return (min <= val) && (val <= max);
            }
            else
            {
                return EnumInfo<T>.s_memberByValue!.ContainsKey(value);
            }


            #region Local Functions
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static long toNumber(T value)
            {
                var x = Unsafe.BitCast<T, long>(value);
                return x;
            }
            #endregion
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToNumberString(T value)
        {
            var x = Unsafe.BitCast<T, long>(value);
            return x.ToString(null, CultureInfo.InvariantCulture);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryParseValue(ReadOnlySpan<char> text, out T result)
        {
            Unsafe.SkipInit(out result);
            ref var x = ref Unsafe.As<T, long>(ref result);
            return long.TryParse(text, CultureInfo.InvariantCulture, out x);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
        {
            if (EnumInfo<T>.s_isContinuous)
            {
                var val = toNumber(value);
                var min = toNumber(EnumInfo<T>.s_minValue);
                var index = (int)(val - min);
                var members = EnumInfo<T>.s_orderedMembers;
                if ((uint)index < (uint)members.Length)
                {
                    result = members.At(index);
                    return true;
                }
                else
                {
                    result = null;
                    return false;
                }
            }
            else
            {
                return EnumInfo<T>.s_memberByValue!.TryGetValue(value, out result);
            }


            #region Local Functions
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static long toNumber(T value)
            {
                var x = Unsafe.BitCast<T, long>(value);
                return x;
            }
            #endregion
        }
    }



    private static class UInt64Operation
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string? GetName(T value)
            => TryGetMember(value, out var member) ? member.Name : null;


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsDefined(T value)
        {
            if (EnumInfo<T>.s_isContinuous)
            {
                var min = toNumber(EnumInfo<T>.s_minValue);
                var max = toNumber(EnumInfo<T>.s_maxValue);
                var val = toNumber(value);
                return (min <= val) && (val <= max);
            }
            else
            {
                return EnumInfo<T>.s_memberByValue!.ContainsKey(value);
            }


            #region Local Functions
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static ulong toNumber(T value)
            {
                var x = Unsafe.BitCast<T, ulong>(value);
                return x;
            }
            #endregion
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string ToNumberString(T value)
        {
            var x = Unsafe.BitCast<T, ulong>(value);
            return x.ToString(null, CultureInfo.InvariantCulture);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryParseValue(ReadOnlySpan<char> text, out T result)
        {
            Unsafe.SkipInit(out result);
            ref var x = ref Unsafe.As<T, ulong>(ref result);
            return ulong.TryParse(text, CultureInfo.InvariantCulture, out x);
        }


        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
        {
            if (EnumInfo<T>.s_isContinuous)
            {
                var val = toNumber(value);
                var min = toNumber(EnumInfo<T>.s_minValue);
                var index = (int)(val - min);
                var members = EnumInfo<T>.s_orderedMembers;
                if ((uint)index < (uint)members.Length)
                {
                    result = members.At(index);
                    return true;
                }
                else
                {
                    result = null;
                    return false;
                }
            }
            else
            {
                return EnumInfo<T>.s_memberByValue!.TryGetValue(value, out result);
            }


            #region Local Functions
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            static ulong toNumber(T value)
            {
                var x = Unsafe.BitCast<T, ulong>(value);
                return x;
            }
            #endregion
        }
    }



    #endregion
}
