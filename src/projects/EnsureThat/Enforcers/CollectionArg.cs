﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using EnsureThat.Annotations;
using EnsureThat.Internals;
using JetBrains.Annotations;

using NotNullAttribute = System.Diagnostics.CodeAnalysis.NotNullAttribute;

namespace EnsureThat.Enforcers
{
    [SuppressMessage("Performance", "CA1822:Mark members as static")]
    public sealed class CollectionArg
    {
        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public T HasItems<T>([ValidatedNotNull, NotNull]T value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> HasItems<T>([ValidatedNotNull, NotNull]ICollection<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public IReadOnlyCollection<T> HasItems<T>([ValidatedNotNull, NotNull]IReadOnlyCollection<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public IReadOnlyList<T> HasItems<T>([ValidatedNotNull, NotNull]IReadOnlyList<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public ISet<T> HasItems<T>([ValidatedNotNull, NotNull]ISet<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] HasItems<T>([ValidatedNotNull, NotNull]T[] value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> HasItems<T>([ValidatedNotNull, NotNull] IList<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> HasItems<TKey, TValue>([ValidatedNotNull, NotNull]IDictionary<TKey, TValue> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public Collection<T> HasItems<T>([ValidatedNotNull, NotNull] Collection<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public List<T> HasItems<T>([ValidatedNotNull, NotNull] List<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public HashSet<T> HasItems<T>([ValidatedNotNull, NotNull] HashSet<T> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public Dictionary<TKey, TValue> HasItems<TKey, TValue>([ValidatedNotNull, NotNull]Dictionary<TKey, TValue> value, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count == 0)
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_HasItemsFailed,
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] SizeIs<T>([ValidatedNotNull, NotNull]T[] value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Collections_SizeIs_Failed, expected, value.Length),
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] SizeIs<T>([ValidatedNotNull, NotNull]T[] value, long expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Length != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Collections_SizeIs_Failed, expected, value.Length),
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public T SizeIs<T>([ValidatedNotNull, NotNull]T value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public T SizeIs<T>([ValidatedNotNull, NotNull]T value, long expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null) where T : class, ICollection
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> SizeIs<T>([ValidatedNotNull, NotNull]ICollection<T> value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> SizeIs<T>([ValidatedNotNull, NotNull]ICollection<T> value, long expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> SizeIs<T>([ValidatedNotNull, NotNull] IList<T> value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> SizeIs<T>([ValidatedNotNull, NotNull]IList<T> value, long expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull, NotNull]IDictionary<TKey, TValue> value, int expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> SizeIs<TKey, TValue>([ValidatedNotNull, NotNull]IDictionary<TKey, TValue> value, long expected, [InvokerParameterName, CallerArgumentExpression(nameof(value))   ] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (value.Count != expected)
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Collections_SizeIs_Failed, expected, value.Count),
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public IDictionary<TKey, TValue> ContainsKey<TKey, TValue>([ValidatedNotNull, NotNull]IDictionary<TKey, TValue> value, TKey expectedKey, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (!value.ContainsKey(expectedKey))
                throw Ensure.ExceptionFactory.ArgumentException(
                    string.Format(DefaultFormatProvider.Strings, ExceptionMessages.Collections_ContainsKey_Failed, expectedKey),
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public IList<T> HasAny<T>([ValidatedNotNull, NotNull]IList<T> value, Func<T, bool> predicate, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_Any_Failed,
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public ICollection<T> HasAny<T>([ValidatedNotNull, NotNull]ICollection<T> value, Func<T, bool> predicate, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_Any_Failed,
                    paramName);

            return value;
        }

        [return: NotNull]
        [ContractAnnotation("value:null => halt")]
        public T[] HasAny<T>([ValidatedNotNull, NotNull]T[] value, Func<T, bool> predicate, [InvokerParameterName, CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            Ensure.Any.IsNotNull(value, paramName);

            if (!value.Any(predicate))
                throw Ensure.ExceptionFactory.ArgumentException(
                    ExceptionMessages.Collections_Any_Failed,
                    paramName);

            return value;
        }
    }
}
