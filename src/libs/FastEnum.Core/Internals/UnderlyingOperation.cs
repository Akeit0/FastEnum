// <auto-generated>
// This .cs file is generated by T4 template. Don't change it. Change the .tt file instead.
// </auto-generated>
#nullable enable

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace FastEnumUtility.Internals;



internal interface IUnderlyingOperation<T> : IFastEnumOperation<T>
    where T : struct, Enum
{
    /// <summary>
    /// Retrieves the member information of the constants in a specified enumeration.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="result"></param>
    /// <returns></returns>
    bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result);
}



internal static class UnderlyingOperation
{
    public static IUnderlyingOperation<T> Create<T>()
        where T : struct, Enum
    {
        return Type.GetTypeCode(typeof(T)) switch
        {
            TypeCode.SByte => SByteOperation<T>.Create(),
            TypeCode.Byte => ByteOperation<T>.Create(),
            TypeCode.Int16 => Int16Operation<T>.Create(),
            TypeCode.UInt16 => UInt16Operation<T>.Create(),
            TypeCode.Int32 => Int32Operation<T>.Create(),
            TypeCode.UInt32 => UInt32Operation<T>.Create(),
            TypeCode.Int64 => Int64Operation<T>.Create(),
            TypeCode.UInt64 => UInt64Operation<T>.Create(),
            _ => throw new InvalidOperationException(),
        };
    }
}



file abstract class SByteOperation<T> : IUnderlyingOperation<T>
    where T : struct, Enum
{
    #region Factories
    public static IUnderlyingOperation<T> Create()
        => EnumInfo<T>.s_isContinuous
        ? new Continuous()
        : new Discontinuous();
    #endregion


    #region IFastEnumOperation<T>
    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string? GetName(T value)
        => this.TryGetMember(value, out var member) ? member.Name : null;


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public abstract bool IsDefined(T value);


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string ToString(T value)
    {
        if (this.TryGetMember(value, out var member))
        {
            return member.Name;
        }
        else
        {
            ref var x = ref Unsafe.As<T, sbyte>(ref value);
            return x.ToString(null, CultureInfo.InvariantCulture);
        }
    }


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryParseName(string text, out T result)
    {
        // note:
        //  - Implement case-sensitive only

        if (EnumInfo<T>.s_memberByName.TryGetValue(text, out var member))
        {
            result = member.Value;
            return true;
        }
        result = default;
        return false;
    }


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryParseValue(string text, out T result)
    {
        Unsafe.SkipInit(out result);
        ref var x = ref Unsafe.As<T, sbyte>(ref result);
        return sbyte.TryParse(text, CultureInfo.InvariantCulture, out x);
    }
    #endregion


    #region IUnderlyingOperation<T>
    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public abstract bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result);
    #endregion


    #region Nested Types
    private sealed class Continuous : SByteOperation<T>
    {
        #region Fields
        private readonly sbyte _minValue;
        private readonly sbyte _maxValue;
        #endregion


        #region Constructors
        public Continuous()
        {
            var min = EnumInfo<T>.s_minValue;
            var max = EnumInfo<T>.s_maxValue;
            this._minValue = Unsafe.As<T, sbyte>(ref min);
            this._maxValue = Unsafe.As<T, sbyte>(ref max);
        }
        #endregion


        #region Overrides
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool IsDefined(T value)
        {
            ref var val = ref Unsafe.As<T, sbyte>(ref value);
            return (this._minValue <= val) && (val <= this._maxValue);
        }


        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
        {
            var members = EnumInfo<T>.s_orderedMembers;
            ref var val = ref Unsafe.As<T, sbyte>(ref value);
            var index = val - this._minValue;
            if ((uint)index < (uint)members.Length)
            {
                result = members[index];
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }
        #endregion
    }



    private sealed class Discontinuous : SByteOperation<T>
    {
        #region Overrides
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool IsDefined(T value)
            => EnumInfo<T>.s_memberByValue.ContainsKey(value);


        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
            => EnumInfo<T>.s_memberByValue.TryGetValue(value, out result);
        #endregion
    }
    #endregion
}



file abstract class ByteOperation<T> : IUnderlyingOperation<T>
    where T : struct, Enum
{
    #region Factories
    public static IUnderlyingOperation<T> Create()
        => EnumInfo<T>.s_isContinuous
        ? new Continuous()
        : new Discontinuous();
    #endregion


    #region IFastEnumOperation<T>
    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string? GetName(T value)
        => this.TryGetMember(value, out var member) ? member.Name : null;


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public abstract bool IsDefined(T value);


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string ToString(T value)
    {
        if (this.TryGetMember(value, out var member))
        {
            return member.Name;
        }
        else
        {
            ref var x = ref Unsafe.As<T, byte>(ref value);
            return x.ToString(null, CultureInfo.InvariantCulture);
        }
    }


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryParseName(string text, out T result)
    {
        // note:
        //  - Implement case-sensitive only

        if (EnumInfo<T>.s_memberByName.TryGetValue(text, out var member))
        {
            result = member.Value;
            return true;
        }
        result = default;
        return false;
    }


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryParseValue(string text, out T result)
    {
        Unsafe.SkipInit(out result);
        ref var x = ref Unsafe.As<T, byte>(ref result);
        return byte.TryParse(text, CultureInfo.InvariantCulture, out x);
    }
    #endregion


    #region IUnderlyingOperation<T>
    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public abstract bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result);
    #endregion


    #region Nested Types
    private sealed class Continuous : ByteOperation<T>
    {
        #region Fields
        private readonly byte _minValue;
        private readonly byte _maxValue;
        #endregion


        #region Constructors
        public Continuous()
        {
            var min = EnumInfo<T>.s_minValue;
            var max = EnumInfo<T>.s_maxValue;
            this._minValue = Unsafe.As<T, byte>(ref min);
            this._maxValue = Unsafe.As<T, byte>(ref max);
        }
        #endregion


        #region Overrides
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool IsDefined(T value)
        {
            ref var val = ref Unsafe.As<T, byte>(ref value);
            return (this._minValue <= val) && (val <= this._maxValue);
        }


        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
        {
            var members = EnumInfo<T>.s_orderedMembers;
            ref var val = ref Unsafe.As<T, byte>(ref value);
            var index = val - this._minValue;
            if ((uint)index < (uint)members.Length)
            {
                result = members[index];
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }
        #endregion
    }



    private sealed class Discontinuous : ByteOperation<T>
    {
        #region Overrides
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool IsDefined(T value)
            => EnumInfo<T>.s_memberByValue.ContainsKey(value);


        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
            => EnumInfo<T>.s_memberByValue.TryGetValue(value, out result);
        #endregion
    }
    #endregion
}



file abstract class Int16Operation<T> : IUnderlyingOperation<T>
    where T : struct, Enum
{
    #region Factories
    public static IUnderlyingOperation<T> Create()
        => EnumInfo<T>.s_isContinuous
        ? new Continuous()
        : new Discontinuous();
    #endregion


    #region IFastEnumOperation<T>
    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string? GetName(T value)
        => this.TryGetMember(value, out var member) ? member.Name : null;


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public abstract bool IsDefined(T value);


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string ToString(T value)
    {
        if (this.TryGetMember(value, out var member))
        {
            return member.Name;
        }
        else
        {
            ref var x = ref Unsafe.As<T, short>(ref value);
            return x.ToString(null, CultureInfo.InvariantCulture);
        }
    }


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryParseName(string text, out T result)
    {
        // note:
        //  - Implement case-sensitive only

        if (EnumInfo<T>.s_memberByName.TryGetValue(text, out var member))
        {
            result = member.Value;
            return true;
        }
        result = default;
        return false;
    }


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryParseValue(string text, out T result)
    {
        Unsafe.SkipInit(out result);
        ref var x = ref Unsafe.As<T, short>(ref result);
        return short.TryParse(text, CultureInfo.InvariantCulture, out x);
    }
    #endregion


    #region IUnderlyingOperation<T>
    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public abstract bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result);
    #endregion


    #region Nested Types
    private sealed class Continuous : Int16Operation<T>
    {
        #region Fields
        private readonly short _minValue;
        private readonly short _maxValue;
        #endregion


        #region Constructors
        public Continuous()
        {
            var min = EnumInfo<T>.s_minValue;
            var max = EnumInfo<T>.s_maxValue;
            this._minValue = Unsafe.As<T, short>(ref min);
            this._maxValue = Unsafe.As<T, short>(ref max);
        }
        #endregion


        #region Overrides
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool IsDefined(T value)
        {
            ref var val = ref Unsafe.As<T, short>(ref value);
            return (this._minValue <= val) && (val <= this._maxValue);
        }


        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
        {
            var members = EnumInfo<T>.s_orderedMembers;
            ref var val = ref Unsafe.As<T, short>(ref value);
            var index = val - this._minValue;
            if ((uint)index < (uint)members.Length)
            {
                result = members[index];
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }
        #endregion
    }



    private sealed class Discontinuous : Int16Operation<T>
    {
        #region Overrides
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool IsDefined(T value)
            => EnumInfo<T>.s_memberByValue.ContainsKey(value);


        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
            => EnumInfo<T>.s_memberByValue.TryGetValue(value, out result);
        #endregion
    }
    #endregion
}



file abstract class UInt16Operation<T> : IUnderlyingOperation<T>
    where T : struct, Enum
{
    #region Factories
    public static IUnderlyingOperation<T> Create()
        => EnumInfo<T>.s_isContinuous
        ? new Continuous()
        : new Discontinuous();
    #endregion


    #region IFastEnumOperation<T>
    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string? GetName(T value)
        => this.TryGetMember(value, out var member) ? member.Name : null;


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public abstract bool IsDefined(T value);


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string ToString(T value)
    {
        if (this.TryGetMember(value, out var member))
        {
            return member.Name;
        }
        else
        {
            ref var x = ref Unsafe.As<T, ushort>(ref value);
            return x.ToString(null, CultureInfo.InvariantCulture);
        }
    }


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryParseName(string text, out T result)
    {
        // note:
        //  - Implement case-sensitive only

        if (EnumInfo<T>.s_memberByName.TryGetValue(text, out var member))
        {
            result = member.Value;
            return true;
        }
        result = default;
        return false;
    }


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryParseValue(string text, out T result)
    {
        Unsafe.SkipInit(out result);
        ref var x = ref Unsafe.As<T, ushort>(ref result);
        return ushort.TryParse(text, CultureInfo.InvariantCulture, out x);
    }
    #endregion


    #region IUnderlyingOperation<T>
    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public abstract bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result);
    #endregion


    #region Nested Types
    private sealed class Continuous : UInt16Operation<T>
    {
        #region Fields
        private readonly ushort _minValue;
        private readonly ushort _maxValue;
        #endregion


        #region Constructors
        public Continuous()
        {
            var min = EnumInfo<T>.s_minValue;
            var max = EnumInfo<T>.s_maxValue;
            this._minValue = Unsafe.As<T, ushort>(ref min);
            this._maxValue = Unsafe.As<T, ushort>(ref max);
        }
        #endregion


        #region Overrides
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool IsDefined(T value)
        {
            ref var val = ref Unsafe.As<T, ushort>(ref value);
            return (this._minValue <= val) && (val <= this._maxValue);
        }


        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
        {
            var members = EnumInfo<T>.s_orderedMembers;
            ref var val = ref Unsafe.As<T, ushort>(ref value);
            var index = val - this._minValue;
            if ((uint)index < (uint)members.Length)
            {
                result = members[index];
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }
        #endregion
    }



    private sealed class Discontinuous : UInt16Operation<T>
    {
        #region Overrides
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool IsDefined(T value)
            => EnumInfo<T>.s_memberByValue.ContainsKey(value);


        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
            => EnumInfo<T>.s_memberByValue.TryGetValue(value, out result);
        #endregion
    }
    #endregion
}



file abstract class Int32Operation<T> : IUnderlyingOperation<T>
    where T : struct, Enum
{
    #region Factories
    public static IUnderlyingOperation<T> Create()
        => EnumInfo<T>.s_isContinuous
        ? new Continuous()
        : new Discontinuous();
    #endregion


    #region IFastEnumOperation<T>
    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string? GetName(T value)
        => this.TryGetMember(value, out var member) ? member.Name : null;


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public abstract bool IsDefined(T value);


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string ToString(T value)
    {
        if (this.TryGetMember(value, out var member))
        {
            return member.Name;
        }
        else
        {
            ref var x = ref Unsafe.As<T, int>(ref value);
            return x.ToString(null, CultureInfo.InvariantCulture);
        }
    }


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryParseName(string text, out T result)
    {
        // note:
        //  - Implement case-sensitive only

        if (EnumInfo<T>.s_memberByName.TryGetValue(text, out var member))
        {
            result = member.Value;
            return true;
        }
        result = default;
        return false;
    }


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryParseValue(string text, out T result)
    {
        Unsafe.SkipInit(out result);
        ref var x = ref Unsafe.As<T, int>(ref result);
        return int.TryParse(text, CultureInfo.InvariantCulture, out x);
    }
    #endregion


    #region IUnderlyingOperation<T>
    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public abstract bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result);
    #endregion


    #region Nested Types
    private sealed class Continuous : Int32Operation<T>
    {
        #region Fields
        private readonly int _minValue;
        private readonly int _maxValue;
        #endregion


        #region Constructors
        public Continuous()
        {
            var min = EnumInfo<T>.s_minValue;
            var max = EnumInfo<T>.s_maxValue;
            this._minValue = Unsafe.As<T, int>(ref min);
            this._maxValue = Unsafe.As<T, int>(ref max);
        }
        #endregion


        #region Overrides
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool IsDefined(T value)
        {
            ref var val = ref Unsafe.As<T, int>(ref value);
            return (this._minValue <= val) && (val <= this._maxValue);
        }


        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
        {
            var members = EnumInfo<T>.s_orderedMembers;
            ref var val = ref Unsafe.As<T, int>(ref value);
            var index = val - this._minValue;
            if ((uint)index < (uint)members.Length)
            {
                result = members[index];
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }
        #endregion
    }



    private sealed class Discontinuous : Int32Operation<T>
    {
        #region Overrides
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool IsDefined(T value)
            => EnumInfo<T>.s_memberByValue.ContainsKey(value);


        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
            => EnumInfo<T>.s_memberByValue.TryGetValue(value, out result);
        #endregion
    }
    #endregion
}



file abstract class UInt32Operation<T> : IUnderlyingOperation<T>
    where T : struct, Enum
{
    #region Factories
    public static IUnderlyingOperation<T> Create()
        => EnumInfo<T>.s_isContinuous
        ? new Continuous()
        : new Discontinuous();
    #endregion


    #region IFastEnumOperation<T>
    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string? GetName(T value)
        => this.TryGetMember(value, out var member) ? member.Name : null;


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public abstract bool IsDefined(T value);


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string ToString(T value)
    {
        if (this.TryGetMember(value, out var member))
        {
            return member.Name;
        }
        else
        {
            ref var x = ref Unsafe.As<T, uint>(ref value);
            return x.ToString(null, CultureInfo.InvariantCulture);
        }
    }


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryParseName(string text, out T result)
    {
        // note:
        //  - Implement case-sensitive only

        if (EnumInfo<T>.s_memberByName.TryGetValue(text, out var member))
        {
            result = member.Value;
            return true;
        }
        result = default;
        return false;
    }


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryParseValue(string text, out T result)
    {
        Unsafe.SkipInit(out result);
        ref var x = ref Unsafe.As<T, uint>(ref result);
        return uint.TryParse(text, CultureInfo.InvariantCulture, out x);
    }
    #endregion


    #region IUnderlyingOperation<T>
    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public abstract bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result);
    #endregion


    #region Nested Types
    private sealed class Continuous : UInt32Operation<T>
    {
        #region Fields
        private readonly uint _minValue;
        private readonly uint _maxValue;
        #endregion


        #region Constructors
        public Continuous()
        {
            var min = EnumInfo<T>.s_minValue;
            var max = EnumInfo<T>.s_maxValue;
            this._minValue = Unsafe.As<T, uint>(ref min);
            this._maxValue = Unsafe.As<T, uint>(ref max);
        }
        #endregion


        #region Overrides
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool IsDefined(T value)
        {
            ref var val = ref Unsafe.As<T, uint>(ref value);
            return (this._minValue <= val) && (val <= this._maxValue);
        }


        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
        {
            var members = EnumInfo<T>.s_orderedMembers;
            ref var val = ref Unsafe.As<T, uint>(ref value);
            var index = val - this._minValue;
            if ((uint)index < (uint)members.Length)
            {
                result = members[index];
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }
        #endregion
    }



    private sealed class Discontinuous : UInt32Operation<T>
    {
        #region Overrides
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool IsDefined(T value)
            => EnumInfo<T>.s_memberByValue.ContainsKey(value);


        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
            => EnumInfo<T>.s_memberByValue.TryGetValue(value, out result);
        #endregion
    }
    #endregion
}



file abstract class Int64Operation<T> : IUnderlyingOperation<T>
    where T : struct, Enum
{
    #region Factories
    public static IUnderlyingOperation<T> Create()
        => EnumInfo<T>.s_isContinuous
        ? new Continuous()
        : new Discontinuous();
    #endregion


    #region IFastEnumOperation<T>
    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string? GetName(T value)
        => this.TryGetMember(value, out var member) ? member.Name : null;


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public abstract bool IsDefined(T value);


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string ToString(T value)
    {
        if (this.TryGetMember(value, out var member))
        {
            return member.Name;
        }
        else
        {
            ref var x = ref Unsafe.As<T, long>(ref value);
            return x.ToString(null, CultureInfo.InvariantCulture);
        }
    }


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryParseName(string text, out T result)
    {
        // note:
        //  - Implement case-sensitive only

        if (EnumInfo<T>.s_memberByName.TryGetValue(text, out var member))
        {
            result = member.Value;
            return true;
        }
        result = default;
        return false;
    }


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryParseValue(string text, out T result)
    {
        Unsafe.SkipInit(out result);
        ref var x = ref Unsafe.As<T, long>(ref result);
        return long.TryParse(text, CultureInfo.InvariantCulture, out x);
    }
    #endregion


    #region IUnderlyingOperation<T>
    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public abstract bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result);
    #endregion


    #region Nested Types
    private sealed class Continuous : Int64Operation<T>
    {
        #region Fields
        private readonly long _minValue;
        private readonly long _maxValue;
        #endregion


        #region Constructors
        public Continuous()
        {
            var min = EnumInfo<T>.s_minValue;
            var max = EnumInfo<T>.s_maxValue;
            this._minValue = Unsafe.As<T, long>(ref min);
            this._maxValue = Unsafe.As<T, long>(ref max);
        }
        #endregion


        #region Overrides
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool IsDefined(T value)
        {
            ref var val = ref Unsafe.As<T, long>(ref value);
            return (this._minValue <= val) && (val <= this._maxValue);
        }


        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
        {
            var members = EnumInfo<T>.s_orderedMembers;
            ref var val = ref Unsafe.As<T, long>(ref value);
            var index = val - this._minValue;
            if ((uint)index < (uint)members.Length)
            {
                result = members[index];
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }
        #endregion
    }



    private sealed class Discontinuous : Int64Operation<T>
    {
        #region Overrides
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool IsDefined(T value)
            => EnumInfo<T>.s_memberByValue.ContainsKey(value);


        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
            => EnumInfo<T>.s_memberByValue.TryGetValue(value, out result);
        #endregion
    }
    #endregion
}



file abstract class UInt64Operation<T> : IUnderlyingOperation<T>
    where T : struct, Enum
{
    #region Factories
    public static IUnderlyingOperation<T> Create()
        => EnumInfo<T>.s_isContinuous
        ? new Continuous()
        : new Discontinuous();
    #endregion


    #region IFastEnumOperation<T>
    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string? GetName(T value)
        => this.TryGetMember(value, out var member) ? member.Name : null;


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public abstract bool IsDefined(T value);


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public string ToString(T value)
    {
        if (this.TryGetMember(value, out var member))
        {
            return member.Name;
        }
        else
        {
            ref var x = ref Unsafe.As<T, ulong>(ref value);
            return x.ToString(null, CultureInfo.InvariantCulture);
        }
    }


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryParseName(string text, out T result)
    {
        // note:
        //  - Implement case-sensitive only

        if (EnumInfo<T>.s_memberByName.TryGetValue(text, out var member))
        {
            result = member.Value;
            return true;
        }
        result = default;
        return false;
    }


    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public bool TryParseValue(string text, out T result)
    {
        Unsafe.SkipInit(out result);
        ref var x = ref Unsafe.As<T, ulong>(ref result);
        return ulong.TryParse(text, CultureInfo.InvariantCulture, out x);
    }
    #endregion


    #region IUnderlyingOperation<T>
    /// <inheritdoc/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public abstract bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result);
    #endregion


    #region Nested Types
    private sealed class Continuous : UInt64Operation<T>
    {
        #region Fields
        private readonly ulong _minValue;
        private readonly ulong _maxValue;
        #endregion


        #region Constructors
        public Continuous()
        {
            var min = EnumInfo<T>.s_minValue;
            var max = EnumInfo<T>.s_maxValue;
            this._minValue = Unsafe.As<T, ulong>(ref min);
            this._maxValue = Unsafe.As<T, ulong>(ref max);
        }
        #endregion


        #region Overrides
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool IsDefined(T value)
        {
            ref var val = ref Unsafe.As<T, ulong>(ref value);
            return (this._minValue <= val) && (val <= this._maxValue);
        }


        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
        {
            var members = EnumInfo<T>.s_orderedMembers;
            ref var val = ref Unsafe.As<T, ulong>(ref value);
            var index = val - this._minValue;
            if ((uint)index < (uint)members.Length)
            {
                result = members[index];
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }
        #endregion
    }



    private sealed class Discontinuous : UInt64Operation<T>
    {
        #region Overrides
        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool IsDefined(T value)
            => EnumInfo<T>.s_memberByValue.ContainsKey(value);


        /// <inheritdoc/>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override bool TryGetMember(T value, [NotNullWhen(true)] out Member<T>? result)
            => EnumInfo<T>.s_memberByValue.TryGetValue(value, out result);
        #endregion
    }
    #endregion
}



