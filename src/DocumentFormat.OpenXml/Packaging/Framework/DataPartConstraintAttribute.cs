﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;

namespace DocumentFormat.OpenXml.Packaging
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    internal sealed class DataPartConstraintAttribute : Attribute, IConstraintAttribute
    {
        public DataPartConstraintAttribute(Type constraintType, bool minOccursIsNonZero, bool maxOccursGreatThanOne)
        {
            ConstraintType = constraintType;
            MinOccursIsNonZero = minOccursIsNonZero;
            MaxOccursGreatThanOne = maxOccursGreatThanOne;
        }

        public Type ConstraintType { get; }

        public bool MinOccursIsNonZero { get; }

        public bool MaxOccursGreatThanOne { get; }
    }
}