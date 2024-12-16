﻿// <auto-generated>
// This .cs file is generated by T4 template. Don't change it. Change the .tt file instead.
// </auto-generated>
#nullable enable

using System;
using System.Globalization;
using System.Linq;
using System.Text;
using FastEnumUtility.UnitTests.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FastEnumUtility.UnitTests.Cases.Reflections;



[TestClass]
public sealed class SameValueContinuousTests
{
    [TestMethod]
    public void GetValues()
    {
        var expect = Enum.GetValues<SameValueContinuousEnum>();
        var actual = FastEnum.GetValues<SameValueContinuousEnum>();
        actual.Should().BeEquivalentTo(expect);
    }


    [TestMethod]
    public void GetNames()
    {
        var expect = Enum.GetNames(typeof(SameValueContinuousEnum));
        var actual = FastEnum.GetNames<SameValueContinuousEnum>();
        actual.Should().BeEquivalentTo(expect);
    }


    [TestMethod]
    public void GetMembers()
    {
        var expect
            = Enum.GetNames<SameValueContinuousEnum>()
            .Select(static name =>
            {
                var value = Enum.Parse<SameValueContinuousEnum>(name);
                var nameUtf8 = Encoding.UTF8.GetBytes(name);
                var fieldInfo = typeof(SameValueContinuousEnum).GetField(name);
                return (value, name, nameUtf8, fieldInfo);
            })
            .ToArray();
        var actual = FastEnum.GetMembers<SameValueContinuousEnum>();

        actual.Length.Should().Be(expect.Length);
        for (var i = 0; i < expect.Length; i++)
        {
            var a = actual[i];
            var e = expect[i];
            a.Value.Should().Be(e.value);
            a.Name.Should().Be(e.name);
            a.NameUtf8.Should().Equal(e.nameUtf8);
            a.FieldInfo.Should().Be(e.fieldInfo);

            var (name, value) = a;
            value.Should().Be(e.value);
            name.Should().Be(e.name);
        }
    }


    [TestMethod]
    public void IsDefined()
    {
        //--- IsDefined(TEnum)
        FastEnum.IsDefined(SameValueContinuousEnum.A).Should().BeTrue();
        FastEnum.IsDefined(SameValueContinuousEnum.B).Should().BeTrue();
        FastEnum.IsDefined(SameValueContinuousEnum.C).Should().BeTrue();
        FastEnum.IsDefined(SameValueContinuousEnum.D).Should().BeTrue();
        FastEnum.IsDefined((SameValueContinuousEnum)123).Should().BeFalse();

        //--- Extension methods
        SameValueContinuousEnum.A.IsDefined().Should().BeTrue();
        SameValueContinuousEnum.B.IsDefined().Should().BeTrue();
        SameValueContinuousEnum.C.IsDefined().Should().BeTrue();
        SameValueContinuousEnum.D.IsDefined().Should().BeTrue();

        //--- IsDefined(ReadOnlySpan<char>)
        FastEnum.IsDefined<SameValueContinuousEnum>(nameof(SameValueContinuousEnum.A)).Should().BeTrue();
        FastEnum.IsDefined<SameValueContinuousEnum>(nameof(SameValueContinuousEnum.B)).Should().BeTrue();
        FastEnum.IsDefined<SameValueContinuousEnum>(nameof(SameValueContinuousEnum.C)).Should().BeTrue();
        FastEnum.IsDefined<SameValueContinuousEnum>(nameof(SameValueContinuousEnum.D)).Should().BeTrue();
        FastEnum.IsDefined<SameValueContinuousEnum>("123").Should().BeFalse();
        FastEnum.IsDefined<SameValueContinuousEnum>("value").Should().BeFalse();
    }


    [TestMethod]
    public void Parse()
    {
        var parameters = new[]
        {
            (value: SameValueContinuousEnum.A, name: nameof(SameValueContinuousEnum.A), valueString: ((byte)SameValueContinuousEnum.A).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueContinuousEnum.B, name: nameof(SameValueContinuousEnum.B), valueString: ((byte)SameValueContinuousEnum.B).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueContinuousEnum.C, name: nameof(SameValueContinuousEnum.C), valueString: ((byte)SameValueContinuousEnum.C).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueContinuousEnum.D, name: nameof(SameValueContinuousEnum.D), valueString: ((byte)SameValueContinuousEnum.D).ToString(CultureInfo.InvariantCulture)),
        };
        foreach (var x in parameters)
        {
            FastEnum.Parse<SameValueContinuousEnum>(x.name).Should().Be(x.value);
            FluentActions.Invoking(() => FastEnum.Parse<SameValueContinuousEnum>(x.name.ToLower(CultureInfo.InvariantCulture))).Should().Throw<ArgumentException>();
            FastEnum.Parse<SameValueContinuousEnum>(x.name.ToUpper(CultureInfo.InvariantCulture)).Should().Be(x.value);
            FastEnum.Parse<SameValueContinuousEnum>(x.valueString).Should().Be(x.value);
            FastEnum.Parse<SameValueContinuousEnum>(x.valueString.ToLower(CultureInfo.InvariantCulture)).Should().Be(x.value);
            FastEnum.Parse<SameValueContinuousEnum>(x.valueString.ToUpper(CultureInfo.InvariantCulture)).Should().Be(x.value);
        }
        FluentActions.Invoking(static () => FastEnum.Parse<SameValueContinuousEnum>((string?)null)).Should().Throw<ArgumentException>();
        FluentActions.Invoking(static () => FastEnum.Parse<SameValueContinuousEnum>("")).Should().Throw<ArgumentException>();
        FluentActions.Invoking(static () => FastEnum.Parse<SameValueContinuousEnum>(" ")).Should().Throw<ArgumentException>();
        FluentActions.Invoking(static () => FastEnum.Parse<SameValueContinuousEnum>("ABCDE")).Should().Throw<ArgumentException>();
        FastEnum.Parse<SameValueContinuousEnum>("123").Should().Be((SameValueContinuousEnum)123);
    }


    [TestMethod]
    public void ParseIgnoreCase()
    {
        var parameters = new[]
        {
            (value: SameValueContinuousEnum.A, name: nameof(SameValueContinuousEnum.A), valueString: ((byte)SameValueContinuousEnum.A).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueContinuousEnum.B, name: nameof(SameValueContinuousEnum.B), valueString: ((byte)SameValueContinuousEnum.B).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueContinuousEnum.C, name: nameof(SameValueContinuousEnum.C), valueString: ((byte)SameValueContinuousEnum.C).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueContinuousEnum.D, name: nameof(SameValueContinuousEnum.D), valueString: ((byte)SameValueContinuousEnum.D).ToString(CultureInfo.InvariantCulture)),
        };
        foreach (var x in parameters)
        {
            FastEnum.Parse<SameValueContinuousEnum>(x.name).Should().Be(x.value);
            FastEnum.Parse<SameValueContinuousEnum>(x.name.ToLower(CultureInfo.InvariantCulture), true).Should().Be(x.value);
            FastEnum.Parse<SameValueContinuousEnum>(x.name.ToUpper(CultureInfo.InvariantCulture), true).Should().Be(x.value);
            FastEnum.Parse<SameValueContinuousEnum>(x.valueString).Should().Be(x.value);
            FastEnum.Parse<SameValueContinuousEnum>(x.valueString.ToLower(CultureInfo.InvariantCulture), true).Should().Be(x.value);
            FastEnum.Parse<SameValueContinuousEnum>(x.valueString.ToUpper(CultureInfo.InvariantCulture), true).Should().Be(x.value);
        }
        FluentActions.Invoking(static () => FastEnum.Parse<SameValueContinuousEnum>((string?)null, true)).Should().Throw<ArgumentException>();
        FluentActions.Invoking(static () => FastEnum.Parse<SameValueContinuousEnum>("", true)).Should().Throw<ArgumentException>();
        FluentActions.Invoking(static () => FastEnum.Parse<SameValueContinuousEnum>(" ", true)).Should().Throw<ArgumentException>();
        FluentActions.Invoking(static () => FastEnum.Parse<SameValueContinuousEnum>("ABCDE", true)).Should().Throw<ArgumentException>();
        FastEnum.Parse<SameValueContinuousEnum>("123").Should().Be((SameValueContinuousEnum)123);
    }


    [TestMethod]
    public void TryParse()
    {
        var parameters = new[]
        {
            (value: SameValueContinuousEnum.A, name: nameof(SameValueContinuousEnum.A), valueString: ((byte)SameValueContinuousEnum.A).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueContinuousEnum.B, name: nameof(SameValueContinuousEnum.B), valueString: ((byte)SameValueContinuousEnum.B).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueContinuousEnum.C, name: nameof(SameValueContinuousEnum.C), valueString: ((byte)SameValueContinuousEnum.C).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueContinuousEnum.D, name: nameof(SameValueContinuousEnum.D), valueString: ((byte)SameValueContinuousEnum.D).ToString(CultureInfo.InvariantCulture)),
        };
        foreach (var x in parameters)
        {
            FastEnum.TryParse<SameValueContinuousEnum>(x.name, out var r1).Should().BeTrue();
            r1.Should().Be(x.value);

            FastEnum.TryParse<SameValueContinuousEnum>(x.name.ToLower(CultureInfo.InvariantCulture), out var _).Should().BeFalse();
            FastEnum.TryParse<SameValueContinuousEnum>(x.name.ToUpper(CultureInfo.InvariantCulture), out var _).Should().BeTrue();

            FastEnum.TryParse<SameValueContinuousEnum>(x.valueString, out var r2).Should().BeTrue();
            r2.Should().Be(x.value);

            FastEnum.TryParse<SameValueContinuousEnum>(x.valueString.ToLower(CultureInfo.InvariantCulture), out var r3).Should().BeTrue();
            r3.Should().Be(x.value);

            FastEnum.TryParse<SameValueContinuousEnum>(x.valueString.ToUpper(CultureInfo.InvariantCulture), out var r4).Should().BeTrue();
            r4.Should().Be(x.value);
        }
        FastEnum.TryParse<SameValueContinuousEnum>((string?)null, out var _).Should().BeFalse();
        FastEnum.TryParse<SameValueContinuousEnum>("", out var _).Should().BeFalse();
        FastEnum.TryParse<SameValueContinuousEnum>(" ", out var _).Should().BeFalse();
        FastEnum.TryParse<SameValueContinuousEnum>("ABCDE", out var _).Should().BeFalse();
        FastEnum.TryParse<SameValueContinuousEnum>("123", out var r).Should().BeTrue();
        r.Should().Be((SameValueContinuousEnum)123);
    }


    [TestMethod]
    public void TryParseIgnoreCase()
    {
        var parameters = new[]
        {
            (value: SameValueContinuousEnum.A, name: nameof(SameValueContinuousEnum.A), valueString: ((byte)SameValueContinuousEnum.A).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueContinuousEnum.B, name: nameof(SameValueContinuousEnum.B), valueString: ((byte)SameValueContinuousEnum.B).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueContinuousEnum.C, name: nameof(SameValueContinuousEnum.C), valueString: ((byte)SameValueContinuousEnum.C).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueContinuousEnum.D, name: nameof(SameValueContinuousEnum.D), valueString: ((byte)SameValueContinuousEnum.D).ToString(CultureInfo.InvariantCulture)),
        };
        foreach (var x in parameters)
        {
            FastEnum.TryParse<SameValueContinuousEnum>(x.name, true, out var r1).Should().BeTrue();
            r1.Should().Be(x.value);

            FastEnum.TryParse<SameValueContinuousEnum>(x.name.ToLower(CultureInfo.InvariantCulture), true, out var r2).Should().BeTrue();
            r2.Should().Be(x.value);

            FastEnum.TryParse<SameValueContinuousEnum>(x.name.ToUpper(CultureInfo.InvariantCulture), true, out var r3).Should().BeTrue();
            r3.Should().Be(x.value);

            FastEnum.TryParse<SameValueContinuousEnum>(x.valueString, true, out var r4).Should().BeTrue();
            r4.Should().Be(x.value);

            FastEnum.TryParse<SameValueContinuousEnum>(x.valueString.ToLower(CultureInfo.InvariantCulture), true, out var r5).Should().BeTrue();
            r5.Should().Be(x.value);

            FastEnum.TryParse<SameValueContinuousEnum>(x.valueString.ToUpper(CultureInfo.InvariantCulture), true, out var r6).Should().BeTrue();
            r6.Should().Be(x.value);
        }
        FastEnum.TryParse<SameValueContinuousEnum>((string?)null, true, out var _).Should().BeFalse();
        FastEnum.TryParse<SameValueContinuousEnum>("", true, out var _).Should().BeFalse();
        FastEnum.TryParse<SameValueContinuousEnum>(" ", true, out var _).Should().BeFalse();
        FastEnum.TryParse<SameValueContinuousEnum>("ABCDE", true, out var _).Should().BeFalse();
        FastEnum.TryParse<SameValueContinuousEnum>("123", true, out var r).Should().BeTrue();
        r.Should().Be((SameValueContinuousEnum)123);
    }


    [TestMethod]
    public void ToMember()
    {
        {
            var value = SameValueContinuousEnum.A;
            var name = nameof(SameValueContinuousEnum.A);
            var nameUtf8 = Encoding.UTF8.GetBytes(name);
            var member = value.ToMember()!;
            var info = typeof(SameValueContinuousEnum).GetField(name);

            member.Should().NotBeNull();
            member.Name.Should().Be(name);
            member.NameUtf8.Should().Equal(nameUtf8);
            member.Value.Should().Be(value);
            member.FieldInfo.Should().Be(info);
        }
        {
            var value = SameValueContinuousEnum.B;
            var name = nameof(SameValueContinuousEnum.B);  // If the same value exists, we can't control what is correct.
            var nameUtf8 = Encoding.UTF8.GetBytes(name);
            var member = value.ToMember()!;
            var info = typeof(SameValueContinuousEnum).GetField(name);

            member.Should().NotBeNull();
            member.Name.Should().Be(name);
            member.NameUtf8.Should().Equal(nameUtf8);
            member.Value.Should().Be(value);
            member.FieldInfo.Should().Be(info);
        }
        {
            var value = SameValueContinuousEnum.C;
            var name = nameof(SameValueContinuousEnum.B);  // If the same value exists, we can't control what is correct.
            var nameUtf8 = Encoding.UTF8.GetBytes(name);
            var member = value.ToMember()!;
            var info = typeof(SameValueContinuousEnum).GetField(name);

            member.Should().NotBeNull();
            member.Name.Should().Be(name);
            member.NameUtf8.Should().Equal(nameUtf8);
            member.Value.Should().Be(value);
            member.FieldInfo.Should().Be(info);
        }
        {
            var value = SameValueContinuousEnum.D;
            var name = nameof(SameValueContinuousEnum.D);
            var nameUtf8 = Encoding.UTF8.GetBytes(name);
            var member = value.ToMember()!;
            var info = typeof(SameValueContinuousEnum).GetField(name);

            member.Should().NotBeNull();
            member.Name.Should().Be(name);
            member.NameUtf8.Should().Equal(nameUtf8);
            member.Value.Should().Be(value);
            member.FieldInfo.Should().Be(info);
        }
    }


    [TestMethod]
    public void ToName()
    {
        var values = Enum.GetValues<SameValueContinuousEnum>();
        foreach (var x in values)
        {
            var expect = Enum.GetName(x);
            var actual = x.ToName();
            actual.Should().Be(expect);
        }
    }


    [TestMethod]
    public void FastToString()
    {
        var values = Enum.GetValues<SameValueContinuousEnum>();
        foreach (var x in values)
        {
            var expect = Enum.GetName(x);
            var actual = x.FastToString();
            actual.Should().Be(expect);
        }
    }
}



[TestClass]
public sealed class SameValueDiscontinuousTests
{
    [TestMethod]
    public void GetValues()
    {
        var expect = Enum.GetValues<SameValueDiscontinuousEnum>();
        var actual = FastEnum.GetValues<SameValueDiscontinuousEnum>();
        actual.Should().BeEquivalentTo(expect);
    }


    [TestMethod]
    public void GetNames()
    {
        var expect = Enum.GetNames(typeof(SameValueDiscontinuousEnum));
        var actual = FastEnum.GetNames<SameValueDiscontinuousEnum>();
        actual.Should().BeEquivalentTo(expect);
    }


    [TestMethod]
    public void GetMembers()
    {
        var expect
            = Enum.GetNames<SameValueDiscontinuousEnum>()
            .Select(static name =>
            {
                var value = Enum.Parse<SameValueDiscontinuousEnum>(name);
                var nameUtf8 = Encoding.UTF8.GetBytes(name);
                var fieldInfo = typeof(SameValueDiscontinuousEnum).GetField(name);
                return (value, name, nameUtf8, fieldInfo);
            })
            .ToArray();
        var actual = FastEnum.GetMembers<SameValueDiscontinuousEnum>();

        actual.Length.Should().Be(expect.Length);
        for (var i = 0; i < expect.Length; i++)
        {
            var a = actual[i];
            var e = expect[i];
            a.Value.Should().Be(e.value);
            a.Name.Should().Be(e.name);
            a.NameUtf8.Should().Equal(e.nameUtf8);
            a.FieldInfo.Should().Be(e.fieldInfo);

            var (name, value) = a;
            value.Should().Be(e.value);
            name.Should().Be(e.name);
        }
    }


    [TestMethod]
    public void IsDefined()
    {
        //--- IsDefined(TEnum)
        FastEnum.IsDefined(SameValueDiscontinuousEnum.A).Should().BeTrue();
        FastEnum.IsDefined(SameValueDiscontinuousEnum.B).Should().BeTrue();
        FastEnum.IsDefined(SameValueDiscontinuousEnum.C).Should().BeTrue();
        FastEnum.IsDefined(SameValueDiscontinuousEnum.D).Should().BeTrue();
        FastEnum.IsDefined((SameValueDiscontinuousEnum)123).Should().BeFalse();

        //--- Extension methods
        SameValueDiscontinuousEnum.A.IsDefined().Should().BeTrue();
        SameValueDiscontinuousEnum.B.IsDefined().Should().BeTrue();
        SameValueDiscontinuousEnum.C.IsDefined().Should().BeTrue();
        SameValueDiscontinuousEnum.D.IsDefined().Should().BeTrue();

        //--- IsDefined(ReadOnlySpan<char>)
        FastEnum.IsDefined<SameValueDiscontinuousEnum>(nameof(SameValueDiscontinuousEnum.A)).Should().BeTrue();
        FastEnum.IsDefined<SameValueDiscontinuousEnum>(nameof(SameValueDiscontinuousEnum.B)).Should().BeTrue();
        FastEnum.IsDefined<SameValueDiscontinuousEnum>(nameof(SameValueDiscontinuousEnum.C)).Should().BeTrue();
        FastEnum.IsDefined<SameValueDiscontinuousEnum>(nameof(SameValueDiscontinuousEnum.D)).Should().BeTrue();
        FastEnum.IsDefined<SameValueDiscontinuousEnum>("123").Should().BeFalse();
        FastEnum.IsDefined<SameValueDiscontinuousEnum>("value").Should().BeFalse();
    }


    [TestMethod]
    public void Parse()
    {
        var parameters = new[]
        {
            (value: SameValueDiscontinuousEnum.A, name: nameof(SameValueDiscontinuousEnum.A), valueString: ((byte)SameValueDiscontinuousEnum.A).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueDiscontinuousEnum.B, name: nameof(SameValueDiscontinuousEnum.B), valueString: ((byte)SameValueDiscontinuousEnum.B).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueDiscontinuousEnum.C, name: nameof(SameValueDiscontinuousEnum.C), valueString: ((byte)SameValueDiscontinuousEnum.C).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueDiscontinuousEnum.D, name: nameof(SameValueDiscontinuousEnum.D), valueString: ((byte)SameValueDiscontinuousEnum.D).ToString(CultureInfo.InvariantCulture)),
        };
        foreach (var x in parameters)
        {
            FastEnum.Parse<SameValueDiscontinuousEnum>(x.name).Should().Be(x.value);
            FluentActions.Invoking(() => FastEnum.Parse<SameValueDiscontinuousEnum>(x.name.ToLower(CultureInfo.InvariantCulture))).Should().Throw<ArgumentException>();
            FastEnum.Parse<SameValueDiscontinuousEnum>(x.name.ToUpper(CultureInfo.InvariantCulture)).Should().Be(x.value);
            FastEnum.Parse<SameValueDiscontinuousEnum>(x.valueString).Should().Be(x.value);
            FastEnum.Parse<SameValueDiscontinuousEnum>(x.valueString.ToLower(CultureInfo.InvariantCulture)).Should().Be(x.value);
            FastEnum.Parse<SameValueDiscontinuousEnum>(x.valueString.ToUpper(CultureInfo.InvariantCulture)).Should().Be(x.value);
        }
        FluentActions.Invoking(static () => FastEnum.Parse<SameValueDiscontinuousEnum>((string?)null)).Should().Throw<ArgumentException>();
        FluentActions.Invoking(static () => FastEnum.Parse<SameValueDiscontinuousEnum>("")).Should().Throw<ArgumentException>();
        FluentActions.Invoking(static () => FastEnum.Parse<SameValueDiscontinuousEnum>(" ")).Should().Throw<ArgumentException>();
        FluentActions.Invoking(static () => FastEnum.Parse<SameValueDiscontinuousEnum>("ABCDE")).Should().Throw<ArgumentException>();
        FastEnum.Parse<SameValueDiscontinuousEnum>("123").Should().Be((SameValueDiscontinuousEnum)123);
    }


    [TestMethod]
    public void ParseIgnoreCase()
    {
        var parameters = new[]
        {
            (value: SameValueDiscontinuousEnum.A, name: nameof(SameValueDiscontinuousEnum.A), valueString: ((byte)SameValueDiscontinuousEnum.A).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueDiscontinuousEnum.B, name: nameof(SameValueDiscontinuousEnum.B), valueString: ((byte)SameValueDiscontinuousEnum.B).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueDiscontinuousEnum.C, name: nameof(SameValueDiscontinuousEnum.C), valueString: ((byte)SameValueDiscontinuousEnum.C).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueDiscontinuousEnum.D, name: nameof(SameValueDiscontinuousEnum.D), valueString: ((byte)SameValueDiscontinuousEnum.D).ToString(CultureInfo.InvariantCulture)),
        };
        foreach (var x in parameters)
        {
            FastEnum.Parse<SameValueDiscontinuousEnum>(x.name).Should().Be(x.value);
            FastEnum.Parse<SameValueDiscontinuousEnum>(x.name.ToLower(CultureInfo.InvariantCulture), true).Should().Be(x.value);
            FastEnum.Parse<SameValueDiscontinuousEnum>(x.name.ToUpper(CultureInfo.InvariantCulture), true).Should().Be(x.value);
            FastEnum.Parse<SameValueDiscontinuousEnum>(x.valueString).Should().Be(x.value);
            FastEnum.Parse<SameValueDiscontinuousEnum>(x.valueString.ToLower(CultureInfo.InvariantCulture), true).Should().Be(x.value);
            FastEnum.Parse<SameValueDiscontinuousEnum>(x.valueString.ToUpper(CultureInfo.InvariantCulture), true).Should().Be(x.value);
        }
        FluentActions.Invoking(static () => FastEnum.Parse<SameValueDiscontinuousEnum>((string?)null, true)).Should().Throw<ArgumentException>();
        FluentActions.Invoking(static () => FastEnum.Parse<SameValueDiscontinuousEnum>("", true)).Should().Throw<ArgumentException>();
        FluentActions.Invoking(static () => FastEnum.Parse<SameValueDiscontinuousEnum>(" ", true)).Should().Throw<ArgumentException>();
        FluentActions.Invoking(static () => FastEnum.Parse<SameValueDiscontinuousEnum>("ABCDE", true)).Should().Throw<ArgumentException>();
        FastEnum.Parse<SameValueDiscontinuousEnum>("123").Should().Be((SameValueDiscontinuousEnum)123);
    }


    [TestMethod]
    public void TryParse()
    {
        var parameters = new[]
        {
            (value: SameValueDiscontinuousEnum.A, name: nameof(SameValueDiscontinuousEnum.A), valueString: ((byte)SameValueDiscontinuousEnum.A).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueDiscontinuousEnum.B, name: nameof(SameValueDiscontinuousEnum.B), valueString: ((byte)SameValueDiscontinuousEnum.B).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueDiscontinuousEnum.C, name: nameof(SameValueDiscontinuousEnum.C), valueString: ((byte)SameValueDiscontinuousEnum.C).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueDiscontinuousEnum.D, name: nameof(SameValueDiscontinuousEnum.D), valueString: ((byte)SameValueDiscontinuousEnum.D).ToString(CultureInfo.InvariantCulture)),
        };
        foreach (var x in parameters)
        {
            FastEnum.TryParse<SameValueDiscontinuousEnum>(x.name, out var r1).Should().BeTrue();
            r1.Should().Be(x.value);

            FastEnum.TryParse<SameValueDiscontinuousEnum>(x.name.ToLower(CultureInfo.InvariantCulture), out var _).Should().BeFalse();
            FastEnum.TryParse<SameValueDiscontinuousEnum>(x.name.ToUpper(CultureInfo.InvariantCulture), out var _).Should().BeTrue();

            FastEnum.TryParse<SameValueDiscontinuousEnum>(x.valueString, out var r2).Should().BeTrue();
            r2.Should().Be(x.value);

            FastEnum.TryParse<SameValueDiscontinuousEnum>(x.valueString.ToLower(CultureInfo.InvariantCulture), out var r3).Should().BeTrue();
            r3.Should().Be(x.value);

            FastEnum.TryParse<SameValueDiscontinuousEnum>(x.valueString.ToUpper(CultureInfo.InvariantCulture), out var r4).Should().BeTrue();
            r4.Should().Be(x.value);
        }
        FastEnum.TryParse<SameValueDiscontinuousEnum>((string?)null, out var _).Should().BeFalse();
        FastEnum.TryParse<SameValueDiscontinuousEnum>("", out var _).Should().BeFalse();
        FastEnum.TryParse<SameValueDiscontinuousEnum>(" ", out var _).Should().BeFalse();
        FastEnum.TryParse<SameValueDiscontinuousEnum>("ABCDE", out var _).Should().BeFalse();
        FastEnum.TryParse<SameValueDiscontinuousEnum>("123", out var r).Should().BeTrue();
        r.Should().Be((SameValueDiscontinuousEnum)123);
    }


    [TestMethod]
    public void TryParseIgnoreCase()
    {
        var parameters = new[]
        {
            (value: SameValueDiscontinuousEnum.A, name: nameof(SameValueDiscontinuousEnum.A), valueString: ((byte)SameValueDiscontinuousEnum.A).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueDiscontinuousEnum.B, name: nameof(SameValueDiscontinuousEnum.B), valueString: ((byte)SameValueDiscontinuousEnum.B).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueDiscontinuousEnum.C, name: nameof(SameValueDiscontinuousEnum.C), valueString: ((byte)SameValueDiscontinuousEnum.C).ToString(CultureInfo.InvariantCulture)),
            (value: SameValueDiscontinuousEnum.D, name: nameof(SameValueDiscontinuousEnum.D), valueString: ((byte)SameValueDiscontinuousEnum.D).ToString(CultureInfo.InvariantCulture)),
        };
        foreach (var x in parameters)
        {
            FastEnum.TryParse<SameValueDiscontinuousEnum>(x.name, true, out var r1).Should().BeTrue();
            r1.Should().Be(x.value);

            FastEnum.TryParse<SameValueDiscontinuousEnum>(x.name.ToLower(CultureInfo.InvariantCulture), true, out var r2).Should().BeTrue();
            r2.Should().Be(x.value);

            FastEnum.TryParse<SameValueDiscontinuousEnum>(x.name.ToUpper(CultureInfo.InvariantCulture), true, out var r3).Should().BeTrue();
            r3.Should().Be(x.value);

            FastEnum.TryParse<SameValueDiscontinuousEnum>(x.valueString, true, out var r4).Should().BeTrue();
            r4.Should().Be(x.value);

            FastEnum.TryParse<SameValueDiscontinuousEnum>(x.valueString.ToLower(CultureInfo.InvariantCulture), true, out var r5).Should().BeTrue();
            r5.Should().Be(x.value);

            FastEnum.TryParse<SameValueDiscontinuousEnum>(x.valueString.ToUpper(CultureInfo.InvariantCulture), true, out var r6).Should().BeTrue();
            r6.Should().Be(x.value);
        }
        FastEnum.TryParse<SameValueDiscontinuousEnum>((string?)null, true, out var _).Should().BeFalse();
        FastEnum.TryParse<SameValueDiscontinuousEnum>("", true, out var _).Should().BeFalse();
        FastEnum.TryParse<SameValueDiscontinuousEnum>(" ", true, out var _).Should().BeFalse();
        FastEnum.TryParse<SameValueDiscontinuousEnum>("ABCDE", true, out var _).Should().BeFalse();
        FastEnum.TryParse<SameValueDiscontinuousEnum>("123", true, out var r).Should().BeTrue();
        r.Should().Be((SameValueDiscontinuousEnum)123);
    }


    [TestMethod]
    public void ToMember()
    {
        {
            var value = SameValueDiscontinuousEnum.A;
            var name = nameof(SameValueDiscontinuousEnum.A);
            var nameUtf8 = Encoding.UTF8.GetBytes(name);
            var member = value.ToMember()!;
            var info = typeof(SameValueDiscontinuousEnum).GetField(name);

            member.Should().NotBeNull();
            member.Name.Should().Be(name);
            member.NameUtf8.Should().Equal(nameUtf8);
            member.Value.Should().Be(value);
            member.FieldInfo.Should().Be(info);
        }
        {
            var value = SameValueDiscontinuousEnum.B;
            var name = nameof(SameValueDiscontinuousEnum.B);  // If the same value exists, we can't control what is correct.
            var nameUtf8 = Encoding.UTF8.GetBytes(name);
            var member = value.ToMember()!;
            var info = typeof(SameValueDiscontinuousEnum).GetField(name);

            member.Should().NotBeNull();
            member.Name.Should().Be(name);
            member.NameUtf8.Should().Equal(nameUtf8);
            member.Value.Should().Be(value);
            member.FieldInfo.Should().Be(info);
        }
        {
            var value = SameValueDiscontinuousEnum.C;
            var name = nameof(SameValueDiscontinuousEnum.B);  // If the same value exists, we can't control what is correct.
            var nameUtf8 = Encoding.UTF8.GetBytes(name);
            var member = value.ToMember()!;
            var info = typeof(SameValueDiscontinuousEnum).GetField(name);

            member.Should().NotBeNull();
            member.Name.Should().Be(name);
            member.NameUtf8.Should().Equal(nameUtf8);
            member.Value.Should().Be(value);
            member.FieldInfo.Should().Be(info);
        }
        {
            var value = SameValueDiscontinuousEnum.D;
            var name = nameof(SameValueDiscontinuousEnum.D);
            var nameUtf8 = Encoding.UTF8.GetBytes(name);
            var member = value.ToMember()!;
            var info = typeof(SameValueDiscontinuousEnum).GetField(name);

            member.Should().NotBeNull();
            member.Name.Should().Be(name);
            member.NameUtf8.Should().Equal(nameUtf8);
            member.Value.Should().Be(value);
            member.FieldInfo.Should().Be(info);
        }
    }


    [TestMethod]
    public void ToName()
    {
        var values = Enum.GetValues<SameValueDiscontinuousEnum>();
        foreach (var x in values)
        {
            var expect = Enum.GetName(x);
            var actual = x.ToName();
            actual.Should().Be(expect);
        }
    }


    [TestMethod]
    public void FastToString()
    {
        var values = Enum.GetValues<SameValueDiscontinuousEnum>();
        foreach (var x in values)
        {
            var expect = Enum.GetName(x);
            var actual = x.FastToString();
            actual.Should().Be(expect);
        }
    }
}



