﻿using System;
using Randomizer.Interfaces.ValueTypes;

namespace Randomizer.Types
{
    public class RandomShortGenerator : RandomGeneratorBase, IRandomShort
    {
        public void InitSeed(int seed)
        {
            this.randomizer = new Random(seed);
        }

        public short GenerateValue()
        {
            short randomPositive = (short)randomizer.Next(0, short.MaxValue);
            short randomNegative = (short)randomizer.Next(short.MinValue, 0);
            if (IsConditionToReachLimit())
            {
                return short.MaxValue;
            }

            return (short)(randomPositive + randomNegative);
        }

        public short GenerateValue(short min, short max)
        {
            short randomPositive = (short)randomizer.Next(0, max);
            short randomNegative = (short)randomizer.Next(min, 0);
            if (IsConditionToReachLimit())
            {
                return min;
            }

            return (short)(randomPositive + randomNegative);
        }

        public short GeneratePositiveValue()
        {
            if (IsConditionToReachLimit())
            {
                return short.MaxValue;
            }

            return (short)randomizer.Next(0, short.MaxValue);
        }

        public short GenerateNegativeValue()
        {
            if (IsConditionToReachLimit())
            {
                return 0;
            }

            return (short)randomizer.Next(short.MinValue, 0);
        }
    }
}
